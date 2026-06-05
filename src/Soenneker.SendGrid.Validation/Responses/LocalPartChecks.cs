using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

/// <summary>
/// Represents the local part checks record.
/// </summary>
public record LocalPartChecks
{
    /// <summary>
    /// Gets or sets a value indicating whether the instance is suspected role address.
    /// </summary>
    [JsonPropertyName("is_suspected_role_address")]
    public bool IsSuspectedRoleAddress { get; set; }
}