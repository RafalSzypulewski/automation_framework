using NUnit.Framework;
using OpenQA.Selenium;
using Automation.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    [SetUpFixture]
    public class DriverSetup
    {
        internal static IWebDriver Driver;

        [SetUp]
        public void StartTestServer()
        {
            Driver = new TestDriverFactory().CreateDriver();
        }

        [TearDown]
        public void StopTestServer()
        {
            Driver.Quit();
        }
    }
}
