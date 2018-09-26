using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using NUnit.Framework.Interfaces;
using AutomationFramework;
using AutomationFramework.PageMethods;

namespace DssSmokeTest.iCati_Tests
{
    class Stage_iCati_Management_SmokeTest
    {
        ExtentTest test;
        ExtentReports report = new ExtentReports("C:\\Automation\\Reports\\STageIcatiSmokeTest.html", true);
        IWebDriver driver;      
        iCatiActions icatiDo;
        WebDriverWait wait;
        Actions action;
        InternetExplorerOptions options;

        [SetUp]
        public void Initialize()
        {
            options = new InternetExplorerOptions { IgnoreZoomLevel = true, EnsureCleanSession = true
                , IntroduceInstabilityByIgnoringProtectedModeSettings = true };
            driver = new InternetExplorerDriver(@"C:\Visual Studio 2015\Projects", options);
            icatiDo = new iCatiActions(driver);
            wait = new WebDriverWait(driver, new TimeSpan(150000000));
            action = new Actions(driver);
        }

        //Management > user activity old
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void old_user_activity()
        {

            test = report.StartTest("Management > User Activity Old");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_UserActivity_Old();
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='tblMain']/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Interviewer Status"), "User Activity(Old) Page not found");
            test.Log(LogStatus.Info, "User Activity (Old) Page found");
            driver.Close();
        }

        //Management > user activity new
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void user_activity_New ()
        {
            test = report.StartTest("Management > User Activity New");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_UserActivity_New();
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmInput']/table/tbody/tr/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Workstations"));
            test.Log(LogStatus.Info, "User Activity New Page found");
            driver.Close();
        }

        //Management > Interview times
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Interview_Times()
        {
            test = report.StartTest("Management > Interview Times");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_InterviewTimes();
                  
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form[1]/table/tbody/tr[1]/th[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Field"));
            test.Log(LogStatus.Info, "Interview Times Page found");
            driver.Close();
        }

        //Management > overnet call backs audit tool
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void callback_Tool()
        {
            test = report.StartTest("Management > Overnight Callbacks");        
            icatiDo.iCati_stg_Login();         
            icatiDo.Nav_CallbackTool();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_CallbacksGridView']/tbody/tr[1]/th[7]/a"))).Text;
            Assert.IsTrue(pageSource.Contains("DSS Call Back Time"));
            test.Log(LogStatus.Info, "Overnight Call Backs Page found");
            driver.Close();
        }

        //Management > Open Sample records Live
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void OpenSample_Live ()
        {
            test = report.StartTest("Management > Open Sample Records > Live");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_OpenSampleLive();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Open Sample (Checked Out)"));
            test.Log(LogStatus.Info, "Open Sample Live Page found");
            driver.Close();
        }

        //Management > Open Sample records Practice
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void OpenSample_practice()
        {
            test = report.StartTest("Management > Open Sample Records > Practice");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_OpenSamplePractice();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Open Practice Sample (Checked Out)"));
            test.Log(LogStatus.Info, "Open Sample Practice Page found");
            driver.Close();

        }
        //Management > Search recordings
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void SearchRecordings()
        {
            test = report.StartTest("Management > Search Recordings");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_SearchRecordings();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='navbar-fixed-top']/table/tbody/tr[1]/td[2]/span"))).Text;
            Assert.IsTrue(pageSource.Contains("Find Recordings"), pageSource + " Was found instead");
            test.Log(LogStatus.Info, "Search Recordings Page found");
            driver.Close();
        }

        //Management > Examine system errors
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void ExamineSysErrors()
        {
            test = report.StartTest("Management > Examine System Errors");
            icatiDo.iCati_stg_Login();
            icatiDo.New_Nav_ExamineSysErrors();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form[1]/table/tbody/tr[1]/th[2]"))).Text;
            Assert.IsTrue(pageSource.Contains("Filter"));
            test.Log(LogStatus.Info, "Examine System Errors Page found");
            driver.Close();
        }

        //Management > Review "Remove from list" Dispositions
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Remove_Dispositions()
        {
            test = report.StartTest("Management > Review Remove Disp List");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Review_Dispositions();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_Label6']"))).Text;
            Assert.IsTrue(pageSource.Contains("Remove From List"), pageSource + " Was found Instead" );
            test.Log(LogStatus.Info, "Review 'Remove From List' Dispositions Page found");
            driver.Close();

            //*[@id="ctl00_content_main_Label6"]
        }

        //Management > QA > QA Callback
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_callback()
        {
            test = report.StartTest("Management > QA > QA Callback");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_QAcallback();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_content_setup']/center/table/tbody/tr[1]/th[2]"))).Text;
            Assert.IsTrue(pageSource.Contains("Dial"));
            test.Log(LogStatus.Info, "QA Call back Page found");
            driver.Close();
        }
 
        //Management > QA > QA Management
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_Management()
        {
            test = report.StartTest("Management > QA > QA management");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_QAMgmt();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_paramtab']/table/tbody/tr/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Filter Parameters"));
            test.Log(LogStatus.Info, "QA Management Page found");
            driver.Close();
        }

        //Management > QA > QA
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_qualityAssurance()
        {
            test = report.StartTest("Management > QA > Quality Assurance");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_QA_QA();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='aspnetForm']/table/tbody/tr[1]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Interviewer"));
            test.Log(LogStatus.Info, "QA Page found");
            driver.Close();

        }

        //Management > QA > Reports > Project
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_reports_project()
        {
            test = report.StartTest("Management > QA >Reports > Project");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_qa_reports();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='ctl00_content_main_div1']/div"))).Text;
            Assert.IsTrue(pageSource.Contains("This table shows the same columns as in the previous column, except that the results have been grouped by vendor"));
            test.Log(LogStatus.Info, "QA Project Reports page found");
            driver.Close();
        }

        //Management > QA > Reports > Interviewer
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_reports_project_Interviewer ()
        {
            test = report.StartTest("Management > QA >Reports > Interviewer");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_qa_reports_Interviewer();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='ctl00_content_main_divFilter']/table/tbody/tr[3]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Scorecard"), pageSource + " Was found");
            test.Log(LogStatus.Info, "QA Reports Interviewer page found");
            driver.Close();
        }

        //Management > QA > Reports > Reviews
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_reports_project_Reviews ()
        {
            test = report.StartTest("Management > QA >Reports > Reviews");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_qa_reports_Reviews();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_divFilter']/table/tbody/tr[3]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Interviewer"), pageSource + " was found");
            test.Log(LogStatus.Info, "QA Reports Review page found");
            driver.Close();
        }

        //Management > QA > Reports > Vendor
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_reports_project_vendor()
        {
            test = report.StartTest("Management > QA >Reports > Vendor");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_qa_reports_vendor();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_divFilter']/table/tbody/tr[1]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Vendor"), pageSource + " was found");
            test.Log(LogStatus.Info, "QA Reports Review page found");
            driver.Close();
        }

        //Management > Search Internet Surveys
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void search_isurvey()
        {
            test = report.StartTest("Management > Search Internet Surveys");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_search_isurvey();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='criteria']"))).SendKeys("118230827");

            action.SendKeys(Keys.Enter).Perform();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/p/span"))).Text;
            Assert.IsTrue(pageSource.Contains("Internet Survey Search"), pageSource + " Was found");
            test.Log(LogStatus.Info, "Internet survey Search found");

            driver.Close();
        }

        //Management > Search Surveys new
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void search_survey_new()
        {
            test = report.StartTest("Management > Search Survey New");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_search_surveys();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//form[@id='indexForm']/div/div[1]/p"))).Text;
            Assert.IsTrue(pageSource.Contains("Sign in to your account"), pageSource + " Was found");
            test.Log(LogStatus.Info, "icati Phone login found");

            driver.Close();
        }

        //Management > Vendor > Users
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void vendor_users()
        {
            test = report.StartTest("Vendor Users");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Vendor();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Users"))).Click();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/table/tbody/tr[1]/td/form/table/tbody/tr[1]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Users Located at DSS Research"), pageSource + " Was found");
            test.Log(LogStatus.Info, "Vendor Users page found");

            driver.Close();
        }

        //Management > Vendor > Assign study/groups
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void vendor_assign_study ()
        {
            test = report.StartTest("Vendor > Assign Study/Groups");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Vendor();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Assign Study/Groups"))).Click();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form/table/tbody/tr/td[3]/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Studies/Groups"), pageSource + " Was found");
            test.Log(LogStatus.Info, "Vendor Assign Study/Groups page found");

            driver.Close();
        }

        //Management > Monitor > Single call Monitor Report
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Monitor_single()
        {
            test = report.StartTest("Management > Monitor > Single");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Monitor_single();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form[1]/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Call Monitor Reporting"), pageSource + " Was found");
            test.Log(LogStatus.Info, "Single Call Monitor Reporting page found");

            driver.Close();
        }

        //Management > Monitor > Bach call Monitor Reports
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Monitor_Batch()
        {
            test = report.StartTest("Management > Monitor > Batch");
            icatiDo.iCati_stg_Login();
            icatiDo.Nav_Monitor_batch();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/menu/li[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Select the Interviewers you wish to print Call Monitor Reports for."), pageSource + " Was found");
            test.Log(LogStatus.Info, "Batch Call Monitor Reporting page found");

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

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(@"C:\Automation\Screenshots\" + "Fail" + DateTime.Now.ToString("YYYYddMMHHMMSS"), ScreenshotImageFormat.Png);
            }

            test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            report.EndTest(test);
            report.Flush();
            driver.Quit();
        }
    }
}
