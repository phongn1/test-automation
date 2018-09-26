using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageMethods
{
    public class SMSactions
    {
        private IWebDriver driver;

        public SMSactions(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public void search_sms_project()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(200000000));
            Actions action = new Actions(driver);
            var page = new OmniPageObjects(driver);
            var omniDo = new Omni2Actions(driver);
            omniDo.loginOmni();
            omniDo.Nav_sms_searchProjects();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("id_project"))).SendKeys("2878");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("btnGo"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='div_results']/table/tbody/tr[2]/td[1]"))).Click();
        }
    }
}
