using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

public record EmailValidationChecks
{
    [JsonPropertyName("domain")]
    public DomainChecks? Domain { get; set; }

    [JsonPropertyName("local_part")]
    public LocalPartChecks? LocalPart { get; set; }

    [JsonPropertyName("additional")]
    public AdditionalChecks? Additional { get; set; }
}