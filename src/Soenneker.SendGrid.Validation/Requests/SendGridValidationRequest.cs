using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Requests;

/// <summary>
/// Represents the send grid validation request record.
/// </summary>
public record SendGridValidationRequest
{
    /// <summary>
    /// Gets or sets email.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; } = default!;

    /// <summary>
    /// Gets or sets source.
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; } = default!;
}