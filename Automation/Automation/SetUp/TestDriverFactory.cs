using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.SetUp
{
    public class TestDriverFactory
    {
        private IWebDriver _driver;
        public IWebDriver CreateDriver()
        {

            if (TestConfiguration.Browser == "chrome")
            {
                _driver = new ChromeDriver(@"Drivers");
            }
            return _driver;
        }
    }
}
