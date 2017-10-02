using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Automation.Users;

namespace Automation.PageObjects
{
    class SearchPage
    {
        private IWebDriver _driver;
        
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchField { get; set; }

        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Name("q")).Displayed);
        }

        public void FillInSearchField(string text)
        {
            SearchField.SendKeys(text);
        }

        public SearchPage SubmitSearch()
        {
            SearchField.SendKeys(Keys.Return);
            return new SearchPage(_driver);
        }


      
    }
}
