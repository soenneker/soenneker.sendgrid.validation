using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

public record LocalPartChecks
{
    [JsonPropertyName("is_suspected_role_address")]
    public bool IsSuspectedRoleAddress { get; set; }
}