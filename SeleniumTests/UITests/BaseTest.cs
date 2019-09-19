using Model.W3;
using NUnit.Framework;

namespace SeleniumTests
{
    public class BaseTest
    {

        public W3Site Site;

        [OneTimeSetUp]
        public void Setup() => Site = new W3Site();

        [OneTimeTearDown]
        public void Close() => Site.Dispose();
    }
}
