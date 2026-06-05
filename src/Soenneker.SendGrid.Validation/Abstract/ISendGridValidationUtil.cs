using System.Threading.Tasks;
using System.Threading;
using Soenneker.SendGrid.Validation.Responses;

namespace Soenneker.SendGrid.Validation.Abstract;

/// <summary>
/// A .NET typesafe implementation of SendGrid's Validation API
/// </summary>
public interface ISendGridValidationUtil
{
    /// <summary>
    /// Executes the validate operation.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <param name="source">The source.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<EmailValidationResult?> Validate(string email, string source, CancellationToken cancellationToken = default);
    /// <summary>
    /// Gets verdict.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <param name="source">The source.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<bool> GetVerdict(string email, string source, CancellationToken cancellationToken = default);
}
