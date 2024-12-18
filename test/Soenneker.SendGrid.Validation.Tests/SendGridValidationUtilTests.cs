using Soenneker.SendGrid.Validation.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.SendGrid.Validation.Tests;

[Collection("Collection")]
public class SendGridValidationUtilTests : FixturedUnitTest
{
    private readonly ISendGridValidationUtil _util;

    public SendGridValidationUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ISendGridValidationUtil>();
    }
}
