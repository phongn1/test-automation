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
using OpenQA.Selenium.Support.PageObjects;


namespace AutomationFramework.iCatiActions
{
   public class iCatiProgramming
    {
        private IWebDriver driver;
        Actions action;
        iCatiPageObjects page;
        iCatiProgrammingObjects progObjects;
        WebDriverWait wait;
       

        public iCatiProgramming(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(browser, this);         
            action = new Actions(driver);
            page = new iCatiPageObjects(driver);
            progObjects = new iCatiProgrammingObjects(driver);
            wait = new WebDriverWait(driver, new TimeSpan(100000000));
        }

        //Programming > Find
        public void Nav_Find_Programming()
        {
            progObjects.Menu_Programming.Click();
            progObjects.Menu_Programming_Find.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='gridPrograms']/div[1]/div/table/thead/tr[2]/th[1]/span/span/span/span/input[1]"))).SendKeys("6577");
            progObjects.programName_box.Click();
            driver.FindElement(By.XPath("//*[@id='gridPrograms']/div[2]/table/tbody/tr/td[1]")).Click();
        }

        //Programming Tools > asscociate studies
        public void Tools_AssocStudies()
        {
            driver.Manage().Window.Maximize();
            progObjects.Btn_Tools.Click();
            progObjects.tools_asssociatestudies.Click();
        }

        // Tools > pages
        public void Tools_Pages()
        {
            driver.Manage().Window.Maximize();
            progObjects.Btn_Tools.Click();
            progObjects.tools_pages.Click();
        }

        // Tools > Questions
        public void Tools_questions()
        {
            driver.Manage().Window.Maximize();
            progObjects.Btn_Tools.Click();
            progObjects.tools_questions.Click();
        }

        // Tools > Options
        public void Tools_options()
        {
            driver.Manage().Window.Maximize();
            progObjects.Btn_Tools.Click();
            progObjects.tools_options.Click();
        }

        // Tools > Random Page Blocks
        public void Tools_RandomBlocks()
        {
            driver.Manage().Window.Maximize();
            progObjects.Btn_Tools.Click();
            progObjects.tools_pageBlocks.Click();
        }
    }
}
