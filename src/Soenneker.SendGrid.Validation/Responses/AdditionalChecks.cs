using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

/// <summary>
/// Represents the additional checks record.
/// </summary>
public record AdditionalChecks
{
    /// <summary>
    /// Gets or sets a value indicating whether the instance has known bounces.
    /// </summary>
    [JsonPropertyName("has_known_bounces")]
    public bool HasKnownBounces { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the instance has suspected bounces.
    /// </summary>
    [JsonPropertyName("has_suspected_bounces")]
    public bool HasSuspectedBounces { get; set; }

    /// <summary>
    /// Gets or sets source.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}