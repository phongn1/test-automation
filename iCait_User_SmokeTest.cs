using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using AutomationFramework.PageObjects;
using AutomationFramework.PageMethods;
using NUnit.Framework.Interfaces;

namespace DssSmokeTest.iCati_Tests
{
    public class iCait_User_SmokeTest : BaseTest
    {
        ExtentReports report = new ExtentReports("C:\\Automation\\Reports\\icatiUserTests.html", true);
        IWebDriver driver;
        iCatiActions icatiDo;
        iCatiUserActions UserActions;
        ICatiUserObjects UserObjects;
        WebDriverWait wait;
        Actions action;
        InternetExplorerOptions options;
        BaseTest tearDown;
        ExtentTest createTest;


        [SetUp]
        public void Initialize()
        {
            options = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true,
                EnsureCleanSession = true,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            driver = new InternetExplorerDriver(@"C:\Users\pnguyen\Documents\Visual Studio 2015", options);
            icatiDo = new iCatiActions(driver);
            wait = new WebDriverWait(driver, new TimeSpan(150000000));
            action = new Actions(driver);
            UserActions = new iCatiUserActions(driver);
            UserObjects = new ICatiUserObjects(driver);
            tearDown = new BaseTest(driver);
            

        }

        // Find User
        [Test]
        public void findUser()
        {
            test = report.StartTest("Find User");
            icatiDo.iCati_stg_Login();
            UserActions.Nav_FIndUser();

            var pageData = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='indexForm']/div[2]/h1"))).Text;
            Assert.AreEqual("Find User", pageData);
        }

        // New User
        [Test]
        public void newUser()
        {
            test = report.StartTest("New User");
            icatiDo.iCati_stg_Login();
            UserActions.Nav_NewUser();
        }

        // Assign Studies/Group

        //Groups

        // Shift/Station Scheduling 

        // Change My  Password 

        // Sign out
        [TearDown]
        public void Report()
        {
            tearDown.GetResult();
        }

        /*
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
    */

    }  
}
