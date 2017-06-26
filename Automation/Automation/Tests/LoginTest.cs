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
    public class LoginTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            //We already have a Driver Instance because the SetUpFixture will have created it.
            //However I like to assign to a local property.
            _driver = DriverSetup.Driver;
            _driver.Navigate().GoToUrl(TestConfiguration.ApplicationUrl);
        }


        [Test]
        public void BadEmailAddressTest()
        {
            var loginPage = new LoginPage(_driver);

        }
    }
}
