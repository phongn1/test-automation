using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using AutomationFramework;
using System.Configuration;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.PageMethods
{
   public class SapphireActions
    {
        IWebDriver driver;
        Actions action;
        SapphireObjects page;

        public SapphireActions (IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(browser, this);
            action = new Actions(driver);
            page = new SapphireObjects(driver);
        }

        public void LoginSapphire_Stg()
        {
            driver.Url = ConfigurationManager.AppSettings["SapphireStg"];
            driver.Manage().Window.Maximize();
            page.UserName.SendKeys("pnguyen");
            page.Password.SendKeys("Sunday123!");
            page.SignIn.Click();
        }

        public void LoginSapphire_Prd ()
        {
            driver.Url = ConfigurationManager.AppSettings["SapphireProd"];
            driver.Manage().Window.Maximize();
            page.UserName.SendKeys("pnguyen");
            page.Password.SendKeys("Sunday123!");
            page.SignIn.Click();
        }
    }
}
