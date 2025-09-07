using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Soenneker.Extensions.Configuration;
using Soenneker.Extensions.HttpClient;
using Soenneker.Extensions.ValueTask;
using Soenneker.SendGrid.Client.Validation.Abstract;
using Soenneker.SendGrid.Validation.Abstract;
using Soenneker.SendGrid.Validation.Requests;
using Soenneker.SendGrid.Validation.Responses;

namespace Soenneker.SendGrid.Validation;

///<inheritdoc cref="ISendGridValidationUtil"/>
public sealed class SendGridValidationUtil : ISendGridValidationUtil
{
    private readonly ILogger<SendGridValidationUtil> _logger;
    private readonly ISendGridValidationClientUtil _sendGridValidationClientUtil;
    private readonly bool _log;
    private readonly bool _enabled;

    public SendGridValidationUtil(IConfiguration configuration, ILogger<SendGridValidationUtil> logger, ISendGridValidationClientUtil sendGridValidationClientUtil)
    {
        _logger = logger;
        _sendGridValidationClientUtil = sendGridValidationClientUtil;

        _enabled = configuration.GetValueStrict<bool>("SendGrid:Validation:Enabled");
        _log = configuration.GetValue<bool>("SendGrid:Validation:LogEnabled");
    }

    public async ValueTask<EmailValidationResult?> Validate(string email, string source, CancellationToken cancellationToken = default)
    {
        if (!_enabled)
        {
            if (_log)
                _logger.LogDebug("==SendGridValidation: Disabled via config, passing email ({email})", email);

            return null;
        }

        if (_log)
            _logger.LogDebug("==SendGridValidation: Validating email ({email}) for source ({source})...", email, source);

        try
        {
            HttpClient client = await _sendGridValidationClientUtil.Get(cancellationToken).NoSync();

            var request = new SendGridValidationRequest { Email = email, Source = source };

            EmailValidationResult? result = await client
                .SendToTypeWithRetry<EmailValidationResult>(HttpMethod.Post, "validations/email", request, 2, _logger, null, _log, cancellationToken).NoSync();

            if (result?.Result == null)
            {
                if (_log)
                    _logger.LogError("==SendGridValidation: Response was null for ({email}), passing", email);

                return null;
            }

            if (_log)
                _logger.LogDebug("==SendGridValidation: Result for email ({email}): {verdict}", email, result.Result.Verdict);

            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "==SendGridValidation: Error validating email {email} from {source}", email, source);
        }

        if (_log)
            _logger.LogWarning("==SendGridValidation: Falls out of catch ({email})", email);

        return null;
    }

    public async ValueTask<bool> GetVerdict(string email, string source, CancellationToken cancellationToken = default)
    {
        if (!_enabled)
        {
            if (_log)
                _logger.LogDebug("==SendGridValidation: Disabled via config, passing email ({email})", email);

            return true;
        }

        EmailValidationResult? result = await Validate(email, source, cancellationToken).NoSync();

        if (result?.Result == null)
            return true;

        bool rtnResult = result.Result.Verdict == "Valid";

        return rtnResult;
    }
}