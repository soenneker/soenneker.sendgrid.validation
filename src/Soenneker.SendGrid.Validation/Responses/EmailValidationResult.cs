using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

/// <summary>
/// Represents the email validation result record.
/// </summary>
public record EmailValidationResult
{
    /// <summary>
    /// Gets or sets result.
    /// </summary>
    [JsonPropertyName("result")]
    public EmailValidationResultDetails? Result { get; set; }
}