using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageObjects
{
    class LoginPage
    {
        private IWebDriver _driver;
        [FindsBy(How = How.Id, Using = "usernameFieldId")]
        private IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "submitFieldId")]
        private IWebElement submitButton { get; set; }

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("usernameFieldId")).Displayed);
        }

        public LoginPage ClickLoginExpectingError()
        {
            submitButton.Click();
            return new LoginPage(_driver);
        }
    }
}
