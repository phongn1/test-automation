using NUnit.Framework;
using System.Configuration;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using NUnit.Framework.Interfaces;
using System.Linq;
using AutomationFramework.PageMethods;
using AutomationFramework.iCatiActions;

namespace DssSmokeTest.Tests
{
    class iCati_Programming_SmokeTest
    {
        ExtentTest test;
        ExtentReports report = new ExtentReports("C:\\Automation\\Reports\\icatiProgramming.html", true);
        IWebDriver driver;
        iCatiActions icatiDo;
        iCatiProgramming program;
        WebDriverWait wait;
        Actions action;
        InternetExplorerOptions options;

        [SetUp]
        public void Initialize()
        {
           
            options = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true,
                EnsureCleanSession = true
                ,IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            driver = new InternetExplorerDriver(@"C:\Visual Studio 2015\Projects", options);
            icatiDo = new iCatiActions(driver);
            wait = new WebDriverWait(driver, new TimeSpan(150000000));
            action = new Actions(driver);
            program = new iCatiProgramming(driver);

        }

        //Validate Datamap Tools Menu
        [Test]
        public void Tools_AssociateStudies()
        {
            test = report.StartTest("Tools - Associate Studies");
            var wait = new WebDriverWait(driver, new TimeSpan(150000000));

            icatiDo.iCati_stg_Login();
            //Search Programs by programID 
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_AssocStudies();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmDataMapTools']/div[2]/div[1]/label"))).Text;
            Assert.AreEqual("Currently Associated Studies", pageSource);
            test.Log(LogStatus.Info, "Associate studies Page found");
            driver.Quit();
        }

        //Pages
        [Test]
        public void Tools_Pages()
        {
            test = report.StartTest("Tools - Pages");
            icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_Pages();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[2]/div/div[2]/div/div[1]/div/span"))).Text;
            Assert.AreEqual("DSS22059 iCATI 2.0 Test Project ***DO NOT USE*** ( 6577 )", pageSource);
            test.Log(LogStatus.Info, "Tools > Pages found");
            driver.Quit();
        }

        //Questions 
        [Test]
        public void Tools_Questions()
        {
            test = report.StartTest("Tools - Questions");
            icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_questions();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[2]/div/div[2]/label"))).Text;
            Assert.AreEqual("Program Last Tested On:", pageSource);
            test.Log(LogStatus.Info, "Tools > Questions found");
            driver.Quit();
        }

        //Options  
        [Test]
        public void Tools_Options()
        {
            test = report.StartTest("Tools - Options");
            icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_options();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[2]/div/form/div/div/div[2]/div[3]/label"))).Text;
            Assert.AreEqual("Code Language", pageSource);
            test.Log(LogStatus.Info, "Code Language");
            driver.Quit();
        }

        //Random page blocks 
        [Test]
        public void Tools_RandomBlocks()
        {
            test = report.StartTest("Tools - Random Page Blocks");
            icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_RandomBlocks();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmDataMapTools']/div/div/div[1]"))).Text;
            Assert.AreEqual("Random Page Blocks", pageSource);
            test.Log(LogStatus.Info, pageSource + " Page found");
            driver.Quit();
        }

        //Import Text File(idm)

        //Import Spanish Text file

        //Save as

        //Dispositions

        //Variables

        //Reports - Details (with rules & pages)

        //Reports - Details (without rules & pages)

        //SPSS


        [TearDown]
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
