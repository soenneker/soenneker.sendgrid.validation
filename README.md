[![](https://img.shields.io/nuget/v/soenneker.sendgrid.validation.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sendgrid.validation/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sendgrid.validation/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sendgrid.validation/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sendgrid.validation.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sendgrid.validation/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sendgrid.validation/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.sendgrid.validation/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.SendGrid.Validation

Returns SendGrid's detailed email-address validation result or a simplified fail-open verdict.

## Installation

```bash
dotnet add package Soenneker.SendGrid.Validation
```

## Configuration

```json
{
  "SendGrid": {
    "ValidationApiKey": "SG.xxxxxxxxx",
    "Validation": {
      "Enabled": true,
      "LogEnabled": false
    }
  }
}
```

## Usage

```csharp
using Soenneker.SendGrid.Validation.Abstract;
using Soenneker.SendGrid.Validation.Registrars;

services.AddSendGridValidationUtilAsSingleton();

public sealed class SignupValidator
{
    private readonly ISendGridValidationUtil _validation;

    public SignupValidator(ISendGridValidationUtil validation)
    {
        _validation = validation;
    }

    public ValueTask<bool> Accept(
        string email,
        CancellationToken cancellationToken)
    {
        return _validation.GetVerdict(
            email,
            source: "signup",
            cancellationToken: cancellationToken);
    }
}
```

`Validate` returns the full SendGrid response, or `null` when validation is disabled, the API fails after retries, or no result is returned. `GetVerdict` returns `false` only when SendGrid explicitly returns a verdict other than `Valid`; disabled or unavailable validation returns `true`. Requested cancellation is propagated rather than treated as a passing verdict.
