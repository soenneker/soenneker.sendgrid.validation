using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

public record EmailValidationResultDetails
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("verdict")]
    public string? Verdict { get; set; }

    [JsonPropertyName("score")]
    public double Score { get; set; }

    [JsonPropertyName("local")]
    public string? Local { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("suggestion")]
    public string? Suggestion { get; set; }

    [JsonPropertyName("checks")]
    public EmailValidationChecks? Checks { get; set; }

    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; set; }
}