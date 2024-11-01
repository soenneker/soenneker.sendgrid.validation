using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

public record AdditionalChecks
{
    [JsonPropertyName("has_known_bounces")]
    public bool HasKnownBounces { get; set; }

    [JsonPropertyName("has_suspected_bounces")]
    public bool HasSuspectedBounces { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}