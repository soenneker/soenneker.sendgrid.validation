using System.Text.Json.Serialization;

namespace Soenneker.SendGrid.Validation.Responses;

public record EmailValidationResult
{
    [JsonPropertyName("result")]
    public EmailValidationResultDetails? Result { get; set; }
}