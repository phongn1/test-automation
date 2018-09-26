
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using AutomationFramework;
using System.Configuration;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.PageMethods
{
 public class Omni2Actions
    {
        private IWebDriver driver;
        OmniPageObjects page;
        WebDriverWait wait;

        public Omni2Actions(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            page = new OmniPageObjects(driver);
            wait = new WebDriverWait(driver, new TimeSpan(100000000));
        }
        //Navigate to Main Menu

        public void Nav_MainMenu()
        {
            //Action to Hover to Main Menu 
            Actions action = new Actions(driver);
            var page = new OmniPageObjects(driver);
            action.MoveToElement(page.Main_menu).Perform();
        }

        public void loginOmni()
        {       
            driver.Url = ConfigurationManager.AppSettings["OmniProd"];
            driver.Manage().Window.Maximize();         
            page.UserName.SendKeys("pnguyen");
            page.Password.SendKeys("Sunday123!");
            page.Submit.Click();
        }

        public void loginOmniStg()
        {
            driver.Url = ConfigurationManager.AppSettings["OmniStg"];
            driver.Manage().Window.Maximize();

            if (driver.PageSource.Contains("This site is not secure"))
            {
                driver.FindElement(By.Id("infoBlockIDImage")).Click();
                driver.FindElement(By.Id("overridelink")).Click();
            }

            page.UserName.SendKeys("pnguyen");
            page.Password.SendKeys("Sunday123!");
            page.Submit.Click();

        }

        public void Nav_DataBlender()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_data_process).Perform();
            move.MoveToElement(page.Menu_data_blender).Perform();
        }

        public void Nav_DataLoader()
        {
            //Navigate to Main Menu > Data Processing > DataLoader
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_data_process).Perform();
            move.MoveToElement(page.Menu_data_blender).Perform();
            move.MoveToElement(page.Menu_data_loader).Perform();
        }

        public void Nav_DataTemplate()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_data_process).Perform();
            move.MoveToElement(page.Menu_data_blender).Perform();
            move.MoveToElement(page.Menu_data_template).Perform();
        }

        public void Nav_SurveyMgmtSys()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_SurveyMgmtSys).Perform();

        }

        //Click Main Menu > SMS > Search Projects
        public void Nav_sms_searchProjects()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_SurveyMgmtSys).Perform();
            move.MoveToElement(page.Menu_SurveyMgmtSearchProjects).Click().Perform();
        }

        //Mouse move and click to main menu > Survey Mgmt Sys > Create New Project
        public void Nav_CreateNewProject()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_SurveyMgmtSys).Perform();
            move.MoveToElement(page.Menu_SurveyMgmtSearchProjects).Perform();
            move.MoveToElement(page.Menu_SurveyMgmtNewProject).Click().Perform();        
        }

        //Mouse move and click to main menu > Survey Mgmt Sys > WIP
        public void Nav_smsWIP()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_SurveyMgmtSys).Perform();
            move.MoveToElement(page.Menu_SurveyMgmtSearchProjects).Perform();
            move.MoveToElement(page.Menu_sms_wip).Click().Perform();
        }

        //Mouse move and click to main menu > Survey Mgmt Sys > Search Documents
        public void Nav_sms_searchDocs()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_SurveyMgmtSys).Perform();
            move.MoveToElement(page.Menu_SurveyMgmtSearchProjects).Perform();
            move.MoveToElement(page.Menu_sms_searchDocs).Click().Perform();
        }

        //Mouse move and click to main menu > Survey Mgmt Sys > More...
        public void Nav_sms_More()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_SurveyMgmtSys).Perform();
            move.MoveToElement(page.Menu_SurveyMgmtSearchProjects).Perform();
            move.MoveToElement(page.Menu_SurveyMgmt_More).Click().Perform();
        }     

        //Mouse move and click Main Menu > HR Calendar
        public void Nav_HR_Calendar()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_HR).Perform();
            move.MoveToElement(page.Menu_HR_Calendar).Click().Perform();
        }

        // Mouse Move and click HR > More...
        public void Nav_HR_More()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_HR).Perform();
            move.MoveToElement(page.Menu_HR_More).Click().Perform();
        }

        //Material Production > Search Materials
        public void Nav_Search_Material_Prod()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Material_Production).Perform();
            move.MoveToElement(page.Menu_Search_Materials).Click().Perform();
        }

        //Material Production > New Materials
        public void Nav_New_Material()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Material_Production).Perform();
            move.MoveToElement(page.Menu_New_Materials).Click().Perform();
        }

        //Material Production > Order Materials
        public void Nav_Order_Materials()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Material_Production).Perform();
            move.MoveToElement(page.Menu_New_Materials).Perform();
            move.MoveToElement(page.Menu_Order_Materials).Click().Perform();
        }

        //Material Production > Production Schedule
        public void Nav_Production_Schedule ()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Material_Production).Perform();
            move.MoveToElement(page.Menu_New_Materials).Perform();
            move.MoveToElement(page.Menu_Production_Schedule).Click().Perform();
        }

        //Mouse move and click to main menu > Purchasing > Search PO's
        public void Nav_purchasing_search()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Purchasing).Perform();
            move.MoveToElement(page.Menu_Purchasing_SearchPO).Click().Perform();
        }

        //Main Menu > Purchasing > New PO
        public void Nav_purchasing_NewPO()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Purchasing).Perform();
            move.MoveToElement(page.Menu_Purchasing_NewPO).Click().Perform();
        }

        //Main Menu > Purchasing > Close/Cancel
        public void Nav_purchasing_Cancel ()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Purchasing).Perform();
            move.MoveToElement(page.Menu_Purchasing_NewPO).Perform();
            move.MoveToElement(page.Menu_Purchasing_Cancel).Click().Perform();
        }

        //Main menu >Purchasing > Vendor
        public void Nav_purchasing_Vendor()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Purchasing).Perform();
            move.MoveToElement(page.Menu_Purchasing_NewPO).Perform();
            move.MoveToElement(page.Menu_Purchasing_Vendor).Click().Perform();
        }

        //Main menu > Purchasing >Submitted PO's
        public void Nav_purchasing_SubmittedPO()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Purchasing).Perform();
            move.MoveToElement(page.Menu_Purchasing_NewPO).Perform();
            move.MoveToElement(page.Menu_Purchasing_SubmittedPO).Click().Perform();
        }

        //Main Menu > Reporting > Reports
        public void Nav_Reports()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Reporting).Perform();
            move.MoveToElement(page.Menu_Reporting_Report).Click().Perform();
        }

        //Main Menu > Reporting > Stored Queries
        public void Nav_Stored_Queries()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Reporting).Perform();
            move.MoveToElement(page.Menu_Reporting_Report).Perform();
            move.MoveToElement(page.Menu_Reporting_StoredQueries).Click().Perform();
        }

        //Main Menu > Reporting > Report Manager
        public void Nav_ReportMgr()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_Reporting).Perform();
            move.MoveToElement(page.Menu_Reporting_Report).Perform();
            //move.MoveToElement(page.Menu_Reporting_ReportManager).Perform();
        }

        //Main Menu > User Administration > Users
        public void Nav_UserAdmin_Users ()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_User_Admin).Perform();
            move.MoveToElement(page.Menu_User_Admin_Users).Click().Perform();
        }

        //Main Menu > User Administration > Users
        public void Nav_UserAdmin_Groups()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_User_Admin).Perform();
            move.MoveToElement(page.Menu_User_Admin_Users).Perform();
            move.MoveToElement(page.Menu_User_Admin_Groups).Click().Perform();
        }

        //Main Menu > Policies and Procedures
        public void Nav_Policies_Procedures()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_PolicyProcedures).Click().Perform();
        }

        //Main Menu > Mail Room
        public void Nav_MailRoom()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_MailRoom).Click().Perform();
        }

        //Main Menu > Time Clock
        public void Nav_TImeClock()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_TimeClock).Click().Perform();
            
        }

        //Main Menu > Help Desk - Request New User Account(s)
        public void Nav_Request_New_User ()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_RequestNewUser).Click().Perform();
        }

        //Main Menu > Help Desk - Request New User Account(s)
        public void Nav_iCati_link()
        {
            Actions move = new Actions(driver);
            var page = new OmniPageObjects(driver);
            Nav_MainMenu();
            move.MoveToElement(page.Menu_iCatiLink).Click().Perform();
        }

    }
}
