using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Requests;

public record SendGridValidationRequest
{
    [JsonPropertyName("email")]
    public string Email { get; set; } = default!;

    [JsonPropertyName("source")]
    public string Source { get; set; } = default!;
}