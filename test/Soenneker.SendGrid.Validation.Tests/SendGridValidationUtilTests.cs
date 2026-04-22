using Soenneker.SendGrid.Validation.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.SendGrid.Validation.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class SendGridValidationUtilTests : HostedUnitTest
{
    private readonly ISendGridValidationUtil _util;

    public SendGridValidationUtilTests(Host host) : base(host)
    {
        _util = Resolve<ISendGridValidationUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
