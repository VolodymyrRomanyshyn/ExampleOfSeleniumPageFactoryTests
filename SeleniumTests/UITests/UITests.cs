using Model.W3;
using Model.W3.Elements;
using NUnit.Framework;
using SeleniumTests;

namespace Tests
{
    public class UITests : BaseTest
    {
        W3Table Table;

        [OneTimeSetUp]
        public void TestSetup()
        {
            Site.W3SchoolsPage.OpenUrl();
            var MainPage = Site.W3SchoolsPage;
            MainPage.LeftSideButtons.Tables.MoveToElementAndClick();
            Table = Site.W3TablePage.Table;
        }

        [Test]
        public void TableTest1()
        {
            Assert.True(Table.FindCountryByCompany("Centro comercial Moctezuma").VisibleText.Equals("Mexico"));
        }

        [Test]
        public void TableTest2()
        {
            Assert.True(Table[1][0].VisibleText.Equals("Alfreds Futterkiste"));
        }

    }
}