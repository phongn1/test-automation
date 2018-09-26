using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using AutomationFramework;
using System.Configuration;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using System.IO;
using AutomationFramework.PageObjects;

namespace AutomationFramework.PageMethods
{
    // Adding to vault
    public class iCatiUserActions
    {
        private IWebDriver driver;
        Actions action;
        ICatiUserObjects userPage;
        iCatiProgrammingObjects progObjects;
        WebDriverWait wait;

        public iCatiUserActions(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            action = new Actions(driver);
            userPage = new ICatiUserObjects(driver);
            progObjects = new iCatiProgrammingObjects(driver);
            wait = new WebDriverWait(driver, new TimeSpan(100000000));
        }

        public void Nav_FIndUser()
        {
            userPage.Menu_User.Click();
            userPage.Menu_FindUser.Click();
        }

        public void Nav_NewUser()
        {
            userPage.Menu_User.Click();
            userPage.Menu_NewUser.Click();
        }




    }
}
