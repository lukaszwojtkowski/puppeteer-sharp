using System.Threading.Tasks;
using PuppeteerSharp.Tests.Attributes;
using PuppeteerSharp.Nunit;
using NUnit.Framework;

namespace PuppeteerSharp.Tests.BrowserTests
{
    public class TargetTests : PuppeteerBrowserBaseTest
    {
        public TargetTests(): base()
        {
        }

        [PuppeteerTest("browser.spec.ts", "Browser.target", "should return browser target")]
        [PuppeteerTimeout]
        public void ShouldReturnBrowserTarget()
            => Assert.AreEqual(TargetType.Browser, Browser.Target.Type);
    }
}