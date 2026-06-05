using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

/// <summary>
/// Represents the domain checks record.
/// </summary>
public record DomainChecks
{
    /// <summary>
    /// Gets or sets a value indicating whether the instance has valid address syntax.
    /// </summary>
    [JsonPropertyName("has_valid_address_syntax")]
    public bool HasValidAddressSyntax { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the instance has mx or a record.
    /// </summary>
    [JsonPropertyName("has_mx_or_a_record")]
    public bool HasMxOrARecord { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the instance is suspected disposable address.
    /// </summary>
    [JsonPropertyName("is_suspected_disposable_address")]
    public bool IsSuspectedDisposableAddress { get; set; }
}