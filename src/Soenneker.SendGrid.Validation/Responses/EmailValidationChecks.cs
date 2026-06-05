using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

/// <summary>
/// Represents the email validation checks record.
/// </summary>
public record EmailValidationChecks
{
    /// <summary>
    /// Gets or sets domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public DomainChecks? Domain { get; set; }

    /// <summary>
    /// Gets or sets local part.
    /// </summary>
    [JsonPropertyName("local_part")]
    public LocalPartChecks? LocalPart { get; set; }

    /// <summary>
    /// Gets or sets additional.
    /// </summary>
    [JsonPropertyName("additional")]
    public AdditionalChecks? Additional { get; set; }
}