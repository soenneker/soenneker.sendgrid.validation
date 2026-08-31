using System.Threading.Tasks;
using System.Threading;
using Soenneker.SendGrid.Validation.Responses;

namespace Soenneker.SendGrid.Validation.Abstract;

/// <summary>
/// Validates email addresses through SendGrid Email Address Validation.
/// </summary>
public interface ISendGridValidationUtil
{
    /// <summary>
    /// Gets the detailed SendGrid validation response, or <see langword="null"/> when validation is disabled or unavailable.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <param name="source">The source.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<EmailValidationResult?> Validate(string email, string source, CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns whether the address should be accepted under the utility's fail-open policy.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <param name="source">The source.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns><see langword="false"/> only when SendGrid returns a non-valid verdict; otherwise <see langword="true"/>.</returns>
    ValueTask<bool> GetVerdict(string email, string source, CancellationToken cancellationToken = default);
}
