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
    public class iCatiActions
    {
        private IWebDriver driver;
        Actions action;
        iCatiPageObjects page;
        iCatiProgrammingObjects progObjects;
        WebDriverWait wait;
       
        public iCatiActions(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            action = new Actions(driver);
            page = new iCatiPageObjects(driver);
            progObjects = new iCatiProgrammingObjects(driver);
            wait = new WebDriverWait(driver, new TimeSpan(100000000));
        }

        // Method to search by Omni project ID
        public void FindByProjectID()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='StudiesGrid']/table/thead/tr[3]/th[1]/span/span/span/span/input[1]"))).SendKeys("22059");
            driver.FindElement(By.XPath("//*[@id='StudiesGrid']/table/thead/tr[3]/th[2]/span/span/span/span/input[1]")).Click();
        }

        //Method to search by studyID
        public void FindByStudyID()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='StudiesGrid']/table/thead/tr[3]/th[2]/span/span/span/span/input[1]"))).SendKeys("10007");
            driver.FindElement(By.XPath("//*[@id='StudiesGrid']/table/thead/tr[3]/th[3]/span/span/span/input")).Click();
        }

        //Method to search by Name
        public void FindByName()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='StudiesGrid']/table/thead/tr[3]/th[3]/span/span/span/input"))).SendKeys("DSS22059");
            driver.FindElement(By.XPath("//*[@id='StudiesGrid']/table/thead/tr[3]/th[1]/span/span/span/span/input[1]")).Click();
        }

        //Login icati and maximize browser
        public void iCati_Login()
        {
            driver.Url = ConfigurationManager.AppSettings["iCati2Prod"];
            driver.Manage().Window.Maximize();
            wait.Until((ExpectedConditions.ElementIsVisible(By.Id("UserName"))));
            page.NewUserName.SendKeys("phongnguyen");
            page.NewPassword.SendKeys("Monday123");
            page.NewSubmit.Click();
        }

        //Login icati and maximize browser
        public void iCati_stg_Login()
        {
            driver.Url = ConfigurationManager.AppSettings["iCati2Stg"];
            driver.Manage().Window.Maximize();
            wait.Until((ExpectedConditions.ElementIsVisible(By.Id("UserName"))));
            page.NewUserName.SendKeys("phongnguyen");
            page.NewPassword.SendKeys("Monday123");
            page.NewSubmit.Click();
        }

        //Navigate to Management > User Activity Old 
        public void Nav_UserActivity_Old()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_UserActivity_Old).Click().Perform();
        }

        //Navigate to Management > User Activity New
        public void Nav_UserActivity_New()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_UserActivity_New).Click().Perform();
        }

        //Navigate to Management > Job Activty 
        public void Nav_JobActivity()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_JobActivity).Click().Perform();
        }

        //Navigate to Management > Job Activty 
        public void Nav_InterviewTimes()
        {
            page.New_Menu_Management.Click();
            page.Menu_InterviewTimes.Click();
        }

        //Navigate to Management > Overnight Call Backs Audit Tool
        public void Nav_CallbackTool()
        {
            action.MoveToElement(page.New_Menu_Management).Click().Perform();    
            page.Menu_CallBackTool.Click();
        }

        //New Icati Navigate to Management > Overnight Call Backs Audit Tool
        public void New_Nav_CallbackTool()
        {
            action.MoveToElement(page.New_Menu_Management).Click().Perform();
            action.MoveToElement(page.Menu_CallBackTool).Click().Perform();
        }

        //Navigate Management > Open Sample Record > Live
        public void Nav_OpenSampleLive()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_Open_Sample_Records).Perform();
            action.MoveToElement(page.Menu_Open_Sample_Records_Live).Click().Perform();
        }

        //Navigate Management > Open Sample Record > Practice
        public void Nav_OpenSamplePractice()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_Open_Sample_Records).Perform();
            action.MoveToElement(page.Menu_Open_Sample_Records_Pracice).Click().Perform();
        }

        //Navigate Management > Search Recordings
        public void Nav_SearchRecordings()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_Search_Recordings).Click().Perform();
        }

        //Navigate Management > Examine System Errors
        public void Nav_ExamineSysErrors()
        {
            //action.MoveToElement(page.New_Menu_Management).Click().Perform();
            page.New_Menu_Management.Click();
            page.Menu_ExamineSysErrors.Click();
        }
          
        //Navigate Management > Examine System Errors
        public void New_Nav_ExamineSysErrors()
        {
            action.MoveToElement(page.New_Menu_Management).Click().Perform();
            driver.FindElement(By.XPath("/html/body/header/div/div[3]/ul/li[1]/ul/li[7]/a")).Click();
        }

        //Navigate > Review 'Remove From List' Dispositions
        public void Nav_Review_Dispositions()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_Review_Disp).Click().Perform();
        }

        //Navigate Management > QA> QA callback
        public void Nav_QAcallback()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAcallback).Click().Perform();
        }

        //Navigate Management > QA > QA Management
        public void Nav_QAMgmt()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAmanagement).Click().Perform();
        }

        //Navigate Management > QA > QA
        public void Nav_QA_QA()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAmanagement).Perform();
            action.MoveToElement(page.Menu_QA_QA).Click().Perform();
        }

        //Navigate Management > Reports > Project
        public void Nav_qa_reports()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAcallback).Perform();
            action.MoveToElement(page.Menu_QA_Reports).Perform();
            action.MoveToElement(page.Menu_Reports_Project).Click().Perform();
        }

        //Navigate Management > Reports > Reviews
        public void Nav_qa_reports_Interviewer ()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAcallback).Perform();
            action.MoveToElement(page.Menu_QA_Reports).Perform();
            action.MoveToElement(page.Menu_Reports_Interviewer).Click().Perform();
        }

        //Navigate Management > Reports > Reviews
        public void Nav_qa_reports_Reviews()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAcallback).Perform();
            action.MoveToElement(page.Menu_QA_Reports).Perform();
            action.MoveToElement(page.Menu_Reports_Interviewer).Perform();
            action.MoveToElement(page.Menu_Reports_Reviews).Click().Perform();
        }

        //Navigate Management > Reports > Vendor
        public void Nav_qa_reports_vendor ()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_QA).Perform();
            action.MoveToElement(page.Menu_QAcallback).Perform();
            action.MoveToElement(page.Menu_QA_Reports).Perform();
            action.MoveToElement(page.Menu_Reports_Interviewer).Perform();
            action.MoveToElement(page.Menu_Reports_Vendor).Click().Perform();
        }

        //Search Internet survey
        public void Nav_search_isurvey ()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_isurvey_search).Click().Perform();
        }

        //Navigate Management > Search Surveys (new)
        public void Nav_search_surveys ()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_search_surveys).Click().Perform();          
        }

        //Navigate Management > Vendor
        public void Nav_Vendor()
        {
            action.MoveToElement(page.New_Menu_Management).Perform();
            action.MoveToElement(page.Menu_Reports_Vendor).Click().Perform();
        }

        //Navigate Management > Monitor > singcall
        public void Nav_Monitor_single ()
        {
            page.New_Menu_Management.Click();
            action.MoveToElement(page.Menu_Monitor).Perform();
            action.MoveToElement(page.Menu_Monitor_singlecall).Click().Perform();
        }

        //Navigate Management > Monitor > Batch
        public void Nav_Monitor_batch()
        {
            page.New_Menu_Management.Click();
            action.MoveToElement(page.Menu_Monitor).Perform();          
            action.MoveToElement(page.Menu_Monitor_singlecall).Perform();
            action.MoveToElement(page.Menu_Monitor_BatchCall).Click().Perform();
        }

        //Navigate study > Find study
        public void Nav_Study_FindStudy()
        {
            action.MoveToElement(page.study_dropdown).Perform();
            action.MoveToElement(page.study_findstudy).Click().Perform();
        }

        //Navigate study > New Study
        public void Nav_Study_NewStudy()
        {
            action.MoveToElement(page.study_dropdown).Perform();
            action.MoveToElement(page.study_new_study).Click().Perform();
        }

        //Navigate Study > Project/Study Groups
        public void Nav_Study_Project_Study_Group()
        {
            action.MoveToElement(page.study_dropdown).Perform();
            action.MoveToElement(page.project_study_group).Click().Perform();
        }

        //Navigate Study > Call Groups 
        public void Nav_Study_CallGroups()
        {
            action.MoveToElement(page.study_dropdown).Perform();
            action.MoveToElement(page.call_group).Click().Perform();
        }

        //Create New Call Group
        public void create_call_group()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("btnAdd"))).Click();
            driver.FindElement(By.Id("CallGroupEntity_g_name")).SendKeys("Automated_group");
            driver.FindElement(By.CssSelector("input[value='Practice']")).Click();
            driver.FindElement(By.XPath("//*[@id='frmCallGroups']/div/div[2]/div/div[4]/button[1]")).Click();
        }
       
        //Add study to call group
        public void add_study_callgroup()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("EventArgument"))).Click();
            new SelectElement(driver.FindElement(By.Id("EventArgument"))).SelectByText("Automated_group");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(.,'Add Studies')]"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@class='k-formatted-value k-input']"))).SendKeys("1000");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='k-numeric-wrap k-state-default k-expand-padding']/input[1]"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='StudiesGrid']/table/tbody/tr/td[1]/label"))).Click();
            //Click add studies
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(.,'Add Studies')]"))).Click();
        }

        //Remove study from call group
        public void remove_study_callgroup()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("EventArgument"))).Click();
            new SelectElement(driver.FindElement(By.Id("EventArgument"))).SelectByText("Automated_group");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("chkStudy-1"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@value='Remove selected studies']"))).Click();
            driver.SwitchTo().Alert().Accept();
        }

        //Delete call group
        public void delete_callGroup()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("EventArgument"))).Click();
            new SelectElement(driver.FindElement(By.Id("EventArgument"))).SelectByText("Automated_group");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(.,'Edit Group Properties')]"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(.,'Delete')]"))).Click();
            driver.SwitchTo().Alert().Accept();
        }

        //Study Bulk Editor
        public void Nav_study_bulk_editor()
        {
            action.MoveToElement(page.study_dropdown).Perform();
            action.MoveToElement(page.study_Bulk_Editor).Click().Perform();                    
        }

    }

}