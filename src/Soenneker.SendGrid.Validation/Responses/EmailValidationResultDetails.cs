using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

/// <summary>
/// Represents the email validation result details record.
/// </summary>
public record EmailValidationResultDetails
{
    /// <summary>
    /// Gets or sets email.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets verdict.
    /// </summary>
    [JsonPropertyName("verdict")]
    public string? Verdict { get; set; }

    /// <summary>
    /// Gets or sets score.
    /// </summary>
    [JsonPropertyName("score")]
    public double Score { get; set; }

    /// <summary>
    /// Gets or sets local.
    /// </summary>
    [JsonPropertyName("local")]
    public string? Local { get; set; }

    /// <summary>
    /// Gets or sets host.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Gets or sets suggestion.
    /// </summary>
    [JsonPropertyName("suggestion")]
    public string? Suggestion { get; set; }

    /// <summary>
    /// Gets or sets checks.
    /// </summary>
    [JsonPropertyName("checks")]
    public EmailValidationChecks? Checks { get; set; }

    /// <summary>
    /// Gets or sets ip address.
    /// </summary>
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; set; }
}