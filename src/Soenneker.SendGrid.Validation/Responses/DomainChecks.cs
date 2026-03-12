using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

public record DomainChecks
{
    [JsonPropertyName("has_valid_address_syntax")]
    public bool HasValidAddressSyntax { get; set; }

    [JsonPropertyName("has_mx_or_a_record")]
    public bool HasMxOrARecord { get; set; }

    [JsonPropertyName("is_suspected_disposable_address")]
    public bool IsSuspectedDisposableAddress { get; set; }
}