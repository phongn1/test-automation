
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework
{
    public class DssLiveObjects
    {
        private IWebDriver driver;

        public DssLiveObjects(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        //  UserName
        [FindsBy(How = How.Id, Using = "DssId")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "DssId")]
        [CacheLookup]
        public IWebElement StgUserName { get; set; }

        // DssLive Password
        [FindsBy(How = How.Id, Using = "Password")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        [CacheLookup]
        public IWebElement StgPassword { get; set; }

        // DssLive login button
        [FindsBy(How = How.Id, Using = "btnLogin")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        [CacheLookup]
        public IWebElement StgSubmit { get; set; }


    
}
}
