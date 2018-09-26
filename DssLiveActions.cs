using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using AutomationFramework;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.PageMethods
{
    public class DssLiveActions
    {
        IWebDriver driver;
        DssLiveObjects page;
        WebDriverWait wait;

        public DssLiveActions (IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            page = new DssLiveObjects(driver);
            wait = new WebDriverWait(driver, new TimeSpan(150000000));
        }

        public void LoginDssLive_Prd()
        {
            driver.Url = ConfigurationManager.AppSettings["DssLivePrd"];
            driver.Manage().Window.Maximize();
            page.UserName.SendKeys("45775959");
            page.Password.SendKeys("XJ482P3L64");
            page.Submit.Click();
        }

        public void LoginDssLive_Stg()
        {
            driver.Url = ConfigurationManager.AppSettings["DssLive2Stg"];
            driver.Manage().Window.Maximize();
            page.StgUserName.SendKeys("83333275");
            page.StgPassword.SendKeys("9HPMKWYEGA");
            page.StgSubmit.Click();
        }

    }
}
