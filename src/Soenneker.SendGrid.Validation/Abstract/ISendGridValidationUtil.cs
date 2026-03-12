using System.Threading.Tasks;
using System.Threading;
using Soenneker.SendGrid.Validation.Responses;

namespace Soenneker.SendGrid.Validation.Abstract;

/// <summary>
/// A .NET typesafe implementation of SendGrid's Validation API
/// </summary>
public interface ISendGridValidationUtil
{
    ValueTask<EmailValidationResult?> Validate(string email, string source, CancellationToken cancellationToken = default);
    ValueTask<bool> GetVerdict(string email, string source, CancellationToken cancellationToken = default);
}
