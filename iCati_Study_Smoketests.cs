using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using AutomationFramework;
using AutomationFramework.PageMethods;
using NUnit.Framework.Interfaces;

namespace DssSmokeTest.iCati_Tests
{
    class iCati_Study_Smoketests
    {
        ExtentTest test;
        ExtentReports report = new ExtentReports("C:\\Automation\\Reports\\icatiStudyTests.html", true);
        IWebDriver driver;
        iCatiActions icatiDo;
        WebDriverWait wait;
        Actions action;
        InternetExplorerOptions options;

        [SetUp]
        public void Initialize()
        {
            options = new InternetExplorerOptions { IgnoreZoomLevel = true, IntroduceInstabilityByIgnoringProtectedModeSettings = true, EnsureCleanSession = true };
            driver = new InternetExplorerDriver(@"C:\Visual Studio 2015\Projects",options);
            icatiDo = new iCatiActions(driver);
            wait = new WebDriverWait(driver, new TimeSpan(100000000));
            action = new Actions(driver);
        }

        //Find Study by project ID 22059
        [Test]
        [Category("icatiStudySmokeTest")]
        public void study_find_by_projectID ()
        {
            test = report.StartTest("Find Study by ProjectID");
            icatiDo.iCati_Login();
            icatiDo.Nav_Study_FindStudy();
            icatiDo.FindByProjectID();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='panel-title text-center']"))).Text;
            Assert.IsTrue(pageSource.Contains("Study Details: DSS22059 iCati 2.0 Test Project ***DO NOT USE*** (10007)"), pageSource + " Study was found instead");
            test.Log(LogStatus.Info, "User Activity (Old) Page found");
            driver.Close();           
        }

        //Find by studyID
        [Test]
        [Category("icatiStudySmokeTest")]
        public void study_find_by_studyID()
        {
            test = report.StartTest("Find Study by StudyID");
            icatiDo.iCati_Login();
            icatiDo.Nav_Study_FindStudy();
            icatiDo.FindByStudyID();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='panel-title text-center']"))).Text;
            Assert.IsTrue(pageSource.Contains("Study Details: DSS22059 iCati 2.0 Test Project ***DO NOT USE*** (10007)"), pageSource + " Was found instead");
            test.Log(LogStatus.Info, "User Activity (Old) Page found");
            driver.Close();
        }

        //Find by study name
        [Test]
        [Category("icatiStudySmokeTest")]
        public void study_find_by_name()
        {
            test = report.StartTest("Find Study by StudyID");
            icatiDo.iCati_Login();
            icatiDo.Nav_Study_FindStudy();
            icatiDo.FindByName();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='col-lg-10 col-md-10']/h1[@class='panel-title text-center']"))).Text;
            Assert.IsTrue(pageSource.Contains("Study Details: DSS22059 iCati 2.0 Test Project ***DO NOT USE*** (10007)"), pageSource + " Was instead found");
            test.Log(LogStatus.Info, "User Activity (Old) Page found");
            driver.Close();
        }

        //FIlter by Modes active

        //FIlter by Call

        //New Study - Create new Study
        [Test]
        [Category("icatiStudySmokeTest")]
        public void study_new_study()
        {
            test = report.StartTest("Study > new study");
            icatiDo.iCati_Login();
            icatiDo.Nav_Study_NewStudy();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/section[1]/div/form/div[1]/div[1]/h1"))).Text;
            Assert.IsTrue(pageSource.Contains("New Study Properties"), pageSource + "New Study Page not found");
            test.Log(LogStatus.Info, "New study Page found");
            driver.Close();
        }

        //Project Study Groups
        [Test]
        [Category("icatiStudySmokeTest")]
        public void study_projectStudy_group()
        {
            test = report.StartTest("Study > Project_Study Groups");
            icatiDo.iCati_Login();
            icatiDo.Nav_Study_Project_Study_Group(); 

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='aspnetForm']/h2"))).Text;
            Assert.IsTrue(pageSource.Contains("Project/Study Groups"), pageSource + "Project/Study Groups Page not found");
            test.Log(LogStatus.Info, "Project/Study Groups Page found");
            driver.Close();
        }

        //Call Groups Create New group
        [Test, Order(1)]
        [Category("icatiStudySmokeTest")]
        public void callgroup_new()
        {
            test = report.StartTest("Create Call Group");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Study_CallGroups();
            icatiDo.create_call_group();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmCallGroups']/div/div[2]/div/div[1]/ul/li"))).Text;
            Assert.IsTrue(pageSource.Contains("Call group has been added/updated successfully!"), pageSource + "Could not create call group");
            test.Log(LogStatus.Info, "Call group successfully created");
            driver.Close();
        }

        //Call Groups add study
        [Test, Order(2)]
        [Category("icatiStudySmokeTest")]
        public void callgroup_addStudy()
        {
            test = report.StartTest("Add Study to call group");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Study_CallGroups();
            icatiDo.add_study_callgroup();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='alert alert-success alert-dismissable']/ul/li"))).Text;
            Assert.IsTrue(pageSource.Contains("Selected studies have been added to the group successfully!"), "Could not add study to call group");
            test.Log(LogStatus.Info, "Study successfully added to call group");
            driver.Close();
        }

        //Call Groups Remove studies
        [Test, Order(3)]
        [Category("icatiStudySmokeTest")]
        public void callgroup_removeStudy()
        {
            test = report.StartTest("Remove Study from call group");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Study_CallGroups();
            icatiDo.remove_study_callgroup();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmCallGroups']/div/div[2]/div/div[1]/ul/li"))).Text;
            Assert.IsTrue(pageSource.Contains("Selected studies have been removed successfully!"), "Could not Remove study to call group");
            test.Log(LogStatus.Info, "Study successfully Removed from call group");
            driver.Close();
        }

        //Call groups Delete Group
        [Test, Order(4)]
        [Category("icatiStudySmokeTest")]
        public void callgroup_deleteGroup()
        {
            test = report.StartTest("Delete Call Group");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Study_CallGroups();
            icatiDo.delete_callGroup();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmCallGroups']/div/div[2]/div/span/b"))).Text;
            Assert.IsTrue(pageSource.Contains("Please select a study from above dropdown list."), "Could not delete call group");
            test.Log(LogStatus.Info, "call group successfully deleted");
            driver.Close();
        }

        //Outsource Tools

        //Bulk Editor

        //Study bulk editor
        [Test]
        [Category("icatiStudySmokeTest")]
        public void study_bulk_editor()
        {
            test = report.StartTest("Study Bulk Editor");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_study_bulk_editor();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//section[2]/div/h3"))).Text;
            Assert.IsTrue(pageSource.Contains("Study Bulk Editor"), "Could not find study bulk editor");
            test.Log(LogStatus.Info, "Study Bulk Editor page found");
            driver.Close();
        }


        [TearDown]
        public void endTest()
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
