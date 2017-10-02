using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Automation.SetUp;
using System.Threading;
using Automation.PageObjects;

namespace Automation.Tests
{
    [TestFixture]
    public class SearchTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = DriverSetup.Driver;
            _driver.Navigate().GoToUrl(TestConfiguration.ApplicationUrl);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void SuccesfulSearchTest()
        {
            var searchpPage = new SearchPage(_driver);
            searchpPage.FillInSearchField("search text");
            SearchPage searchResult = searchpPage.SubmitSearch();
            



        }
    }
}
