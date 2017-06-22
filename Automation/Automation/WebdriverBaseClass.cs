using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class WebdriverBaseClass
    {
        public static IWebDriver driver;
        public static string AppUrl = "https://127.0.0.1";

        public static int globalTimeoutInSec = 10;



        public void SetUpTest()
        {
            if (driver == null)
            {
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, globalTimeoutInSec);
                driver.Navigate().GoToUrl(AppUrl);
            }

        }

        public void TeardownTest()
        {
            if (driver != null)
            {
                try
                {
                    driver.Close();
                    driver.Quit();
                    driver = null;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
