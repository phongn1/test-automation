using NUnit.Framework;
using System.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
        ExtentReports extent;
        //Extenttests test = new Extenttests("C:\\Automation\\tests\\icatiProgramming.html", true);
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
            var htmltester = new ExtentHtmlReporter("C:\\Temp\\Test3test.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmltester);

        }

        //Validate Datamap Tools Menu
        [Test]
        public void Tools_AssociateStudies()
        {
            test = extent.CreateTest("Tools - Associate Studies");
            var wait = new WebDriverWait(driver, new TimeSpan(150000000));

            //icatiDo.iCati_stg_Login();
            //Search Programs by programID 
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_AssocStudies();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmDataMapTools']/div[2]/div[1]/label"))).Text;
            Assert.AreEqual("Currently Associated Studies", pageSource);
            test.Log(Status.Info, "Associate studies Page found");
            driver.Quit();
        }

        //Pages
        [Test]
        public void Tools_Pages()
        {
            test = extent.CreateTest("Tools - Pages");
            //icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_Pages();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[2]/div/div[2]/div/div[1]/div/span"))).Text;
            Assert.AreEqual("DSS22059 iCATI 2.0 Test Project ***DO NOT USE*** ( 6577 )", pageSource);
            test.Log(Status.Info, "Tools > Pages found");
            driver.Quit();
        }

        //Questions 
        [Test]
        public void Tools_Questions()
        {
            test = extent.CreateTest("Tools - Questions");
            //icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_questions();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[2]/div/div[2]/label"))).Text;
            Assert.AreEqual("Program Last Tested On:", pageSource);
            test.Log(Status.Info, "Tools > Questions found");
            driver.Quit();
        }

        //Options  
        [Test]
        public void Tools_Options()
        {
            test = extent.CreateTest("Tools - Options");
            //icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_options();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[2]/div/form/div/div/div[2]/div[3]/label"))).Text;
            Assert.AreEqual("Code Language", pageSource);
            test.Log(Status.Info, "Code Language");
            driver.Quit();
        }

        //Random page blocks 
        [Test]
        public void Tools_RandomBlocks()
        {
            test = extent.CreateTest("Tools - Random Page Blocks");
            //icatiDo.iCati_stg_Login();
            program.Nav_Find_Programming();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            program.Tools_RandomBlocks();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmDataMapTools']/div/div/div[1]"))).Text;
            Assert.AreEqual("Random Page Blocks", pageSource);
            test.Log(Status.Info, pageSource + " Page found");
            driver.Quit();
        }

        //Import Text File(idm)

        //Import Spanish Text file

        //Save as

        //Dispositions

        //Variables

        //tests - Details (with rules & pages)

        //tests - Details (without rules & pages)

        //SPSS


        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.Message)
                ? ""
                : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

            Status Status;

            switch (status)
            {
                case TestStatus.Failed:
                    Status = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    Status = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    Status = Status.Skip;
                    break;
                default:
                    Status = Status.Pass;
                    break;
            }

            test.Log(Status, "Test ended with " + Status + stacktrace);
            //test.(test);
            extent.Flush();
        }

    }


}
