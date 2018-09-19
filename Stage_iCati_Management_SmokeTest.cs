using NUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using NUnit.Framework.Interfaces;
using AutomationFramework;
using AutomationFramework.PageMethods;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace DssSmokeTest.iCati_Tests
{
    class Stage_iCati_Management_SmokeTest
    {
        ExtentTest test;
        ExtentReports extent;
        IWebDriver driver;      
        static iCatiActions icatiDo;
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
                ,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            driver = new InternetExplorerDriver(@"C:\Visual Studio 2015\Projects", options);
            icatiDo = new iCatiActions(driver);
            wait = new WebDriverWait(driver, new TimeSpan(150000000));
            action = new Actions(driver);
            var htmltester = new ExtentHtmlReporter("C:\\Temp\\Test4test.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmltester);
        }

        //Management > user activity old
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void old_user_activity()
        {

            test = extent.CreateTest("Management > User Activity Old");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_UserActivity_Old();
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='tblMain']/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Interviewer Status"), "User Activity(Old) Page not found");
            test.Log(Status.Info, "User Activity (Old) Page found");
            driver.Close();
        }

        //Management > user activity new
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void user_activity_New ()
        {
            test = extent.CreateTest("Management > User Activity New");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_UserActivity_New();
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='frmInput']/table/tbody/tr/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Workstations"));
            test.Log(Status.Info, "User Activity New Page found");
            driver.Close();
        }

        //Management > Interview times
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Interview_Times()
        {
            test = extent.CreateTest("Management > Interview Times");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_InterviewTimes();
                  
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form[1]/table/tbody/tr[1]/th[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Field"));
            test.Log(Status.Info, "Interview Times Page found");
            driver.Close();
        }

        //Management > overnet call backs audit tool
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void callback_Tool()
        {
            test = extent.CreateTest("Management > Overnight Callbacks");
            iCatiActions.iCati_stg_Login();         
            icatiDo.Nav_CallbackTool();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_CallbacksGridView']/tbody/tr[1]/th[7]/a"))).Text;
            Assert.IsTrue(pageSource.Contains("DSS Call Back Time"));
            test.Log(Status.Info, "Overnight Call Backs Page found");
            driver.Close();
        }

        //Management > Open Sample records Live
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void OpenSample_Live ()
        {
            test = extent.CreateTest("Management > Open Sample Records > Live");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_OpenSampleLive();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Open Sample (Checked Out)"));
            test.Log(Status.Info, "Open Sample Live Page found");
            driver.Close();
        }

        //Management > Open Sample records Practice
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void OpenSample_practice()
        {
            test = extent.CreateTest("Management > Open Sample Records > Practice");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_OpenSamplePractice();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Open Practice Sample (Checked Out)"));
            test.Log(Status.Info, "Open Sample Practice Page found");
            driver.Close();

        }
        //Management > Search recordings
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void SearchRecordings()
        {
            test = extent.CreateTest("Management > Search Recordings");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_SearchRecordings();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='navbar-fixed-top']/table/tbody/tr[1]/td[2]/span"))).Text;
            Assert.IsTrue(pageSource.Contains("Find Recordings"), pageSource + " Was found instead");
            test.Log(Status.Info, "Search Recordings Page found");
            driver.Close();
        }

        //Management > Examine system errors
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void ExamineSysErrors()
        {
            test = extent.CreateTest("Management > Examine System Errors");
            iCatiActions.iCati_stg_Login();
            icatiDo.New_Nav_ExamineSysErrors();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form[1]/table/tbody/tr[1]/th[2]"))).Text;
            Assert.IsTrue(pageSource.Contains("Filter"));
            test.Log(Status.Info, "Examine System Errors Page found");
            driver.Close();
        }

        //Management > Review "Remove from list" Dispositions
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Remove_Dispositions()
        {
            test = extent.CreateTest("Management > Review Remove Disp List");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_Review_Dispositions();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_Label6']"))).Text;
            Assert.IsTrue(pageSource.Contains("Remove From List"), pageSource + " Was found Instead" );
            test.Log(Status.Info, "Review 'Remove From List' Dispositions Page found");
            driver.Close();

            //*[@id="ctl00_content_main_Label6"]
        }

        //Management > QA > QA Callback
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_callback()
        {
            test = extent.CreateTest("Management > QA > QA Callback");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_QAcallback();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_content_setup']/center/table/tbody/tr[1]/th[2]"))).Text;
            Assert.IsTrue(pageSource.Contains("Dial"));
            test.Log(Status.Info, "QA Call back Page found");
            driver.Close();
        }
 
        //Management > QA > QA Management
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_Management()
        {
            test = extent.CreateTest("Management > QA > QA management");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_QAMgmt();

            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ctl00_content_main_paramtab']/table/tbody/tr/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Filter Parameters"));
            test.Log(Status.Info, "QA Management Page found");
            driver.Close();
        }

        //Management > QA > QA
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void qa_qualityAssurance()
        {
            test = extent.CreateTest("Management > QA > Quality Assurance");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_QA_QA();
            //Assert
            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='aspnetForm']/table/tbody/tr[1]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Interviewer"));
            test.Log(Status.Info, "QA Page found");
            driver.Close();

        }

        //Management > Search Internet Surveys
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void search_isurvey()
        {
            test = extent.CreateTest("Management > Search Internet Surveys");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_search_isurvey();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='criteria']"))).SendKeys("118230827");

            action.SendKeys(Keys.Enter).Perform();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/p/span"))).Text;
            Assert.IsTrue(pageSource.Contains("Internet Survey Search"), pageSource + " Was found");
            test.Log(Status.Info, "Internet survey Search found");

            driver.Close();
        }

        //Management > Search Surveys new
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void search_survey_new()
        {
            test = extent.CreateTest("Management > Search Survey New");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_search_surveys();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//form[@id='indexForm']/div/div[1]/p"))).Text;
            Assert.IsTrue(pageSource.Contains("Sign in to your account"), pageSource + " Was found");
            test.Log(Status.Info, "icati Phone login found");

            driver.Close();
        }

        //Management > Vendor > Users
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void vendor_users()
        {
            test = extent.CreateTest("Vendor Users");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_Vendor();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Users"))).Click();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/table/tbody/tr[1]/td/form/table/tbody/tr[1]/td[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Users Located at DSS Research"), pageSource + " Was found");
            test.Log(Status.Info, "Vendor Users page found");

            driver.Close();
        }

        //Management > Vendor > Assign study/groups
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void vendor_assign_study ()
        {
            test = extent.CreateTest("Vendor > Assign Study/Groups");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_Vendor();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Assign Study/Groups"))).Click();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form/table/tbody/tr/td[3]/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Studies/Groups"), pageSource + " Was found");
            test.Log(Status.Info, "Vendor Assign Study/Groups page found");

            driver.Close();
        }

        //Management > Monitor > Single call Monitor extent
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Monitor_single()
        {
            test = extent.CreateTest("Management > Monitor > Single");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_Monitor_single();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form[1]/table/tbody/tr[1]/th"))).Text;
            Assert.IsTrue(pageSource.Contains("Call Monitor extenting"), pageSource + " Was found");
            test.Log(Status.Info, "Single Call Monitor extenting page found");

            driver.Close();
        }

        //Management > Monitor > Bach call Monitor extents
        [Test]
        [Category("StageIcatiSmokeTest")]
        public void Monitor_Batch()
        {
            test = extent.CreateTest("Management > Monitor > Batch");
            iCatiActions.iCati_stg_Login();
            icatiDo.Nav_Monitor_batch();

            var pageSource = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/menu/li[1]"))).Text;
            Assert.IsTrue(pageSource.Contains("Select the Interviewers you wish to print Call Monitor extents for."), pageSource + " Was found");
            test.Log(Status.Info, "Batch Call Monitor extenting page found");

            driver.Close();
        }

        [TearDown]
        public void endTest()
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

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(@"C:\Automation\Screenshots\" + "Fail" + DateTime.Now.ToString("YYYYddMMHHMMSS"), ScreenshotImageFormat.Png);
            }

            test.Log(Status, "Test ended with " + Status + stacktrace);

            extent.Flush();
            driver.Quit();
        }
    }
}
