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
using RelevantCodes.ExtentReports;
using NUnit.Framework.Interfaces;

namespace AutomationFramework.PageMethods
{
    public class BaseTest
    {
        ExtentReports report = new ExtentReports("C:\\Automation\\Reports\\icatiUserTests.html", true);
        ExtentTest test;

        IWebDriver driver;

        public BaseTest(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);

        }


        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.Message)
                ? ""
                : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

            LogStatus logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = LogStatus.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = LogStatus.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = LogStatus.Skip;
                    break;
                default:
                    logstatus = LogStatus.Pass;
                    break;
            }

            test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            report.EndTest(test);
            report.Flush();
        }
    }
}
