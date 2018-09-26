using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Configuration;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    public class OmniPageObjects
    {
        IWebDriver driver;

        public OmniPageObjects(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        // Omni UserName
        [FindsBy(How = How.Id, Using = "userNameInput")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        // Omni Password
        [FindsBy(How = How.Id, Using = "passwordInput")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        // Omni login button
        [FindsBy(How = How.XPath, Using = "//*[@id='submitButton']")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        // Omni 2 username
        [FindsBy(How = How.Id, Using = "userNameInput")]
        [CacheLookup]
        public IWebElement Omni2UserName { get; set; }

        // Omni 2 username
        [FindsBy(How = How.Id, Using = "passwordInput")]
        [CacheLookup]
        public IWebElement Omni2Password { get; set; }

        // Omni 2 username
        [FindsBy(How = How.Id, Using = "submitButton")]
        [CacheLookup]
        public IWebElement Omni2SignOn { get; set; }

        // Data processing
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[4]/a")]
        [CacheLookup]
        public IWebElement Menu_data_process { get; set; }

        // Menu Data Loader
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[4]/ul/li[2]/a")]
        [CacheLookup]
        public IWebElement Menu_data_loader { get; set; }

        //Menu Data Blender
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[4]/ul/li[1]/a")]
        [CacheLookup]
        public IWebElement Menu_data_blender { get; set; }

        //Menu Data Template
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[4]/ul/li[3]/a")]
        [CacheLookup]
        public IWebElement Menu_data_template { get; set; }

        //Menu Survey Management System
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[9]/a")]
        [CacheLookup]
        public IWebElement Menu_SurveyMgmtSys { get; set; }

        //Menu Survey Management System Search Projects
        [FindsBy(How = How.LinkText, Using = "Search Projects")]
        [CacheLookup]
        public IWebElement Menu_SurveyMgmtSearchProjects { get; set; }

        //Menu Survey Management System New Project
        [FindsBy(How = How.LinkText, Using = "Create New Project")]
        [CacheLookup]
        public IWebElement Menu_SurveyMgmtNewProject { get; set; }

        //Main Menu
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/a")]
        [CacheLookup]
        public IWebElement Main_menu { get; set; }

        //Survey Mgmt Sys > More...
        [FindsBy(How = How.LinkText, Using = "More...")]
        [CacheLookup]
        public IWebElement Menu_SurveyMgmt_More { get; set; }

        //Survey Mgmt System > WIP
        [FindsBy(How = How.LinkText, Using = "WIP")]
        [CacheLookup]
        public IWebElement Menu_sms_wip { get; set; }

        //Survey Mgmt System > Search Docs
        [FindsBy(How = How.LinkText, Using = "Search Docs")]
        [CacheLookup]
        public IWebElement Menu_sms_searchDocs { get; set; }

        //Main Menu > HR
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[5]/a")]
        [CacheLookup]
        public IWebElement Menu_HR { get; set; }

        //HR Calender
        [FindsBy(How = How.LinkText, Using = "Calendar")]
        [CacheLookup]
        public IWebElement Menu_HR_Calendar { get; set; }

        //HR More Link
        [FindsBy(How = How.LinkText, Using = "More...")]
        [CacheLookup]
        public IWebElement Menu_HR_More { get; set; }

        //***Material Production*** 
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[8]/a")]
        [CacheLookup]
        public IWebElement Menu_Material_Production { get; set; }

        //Material Production > Search Materials 
        [FindsBy(How = How.LinkText, Using = "Search Materials")]
        [CacheLookup]
        public IWebElement Menu_Search_Materials { get; set; }

        //Material Production > New Materials 
        [FindsBy(How = How.LinkText, Using = "New Material")]
        [CacheLookup]
        public IWebElement Menu_New_Materials { get; set; }

        //Material Production > Order Materials 
        [FindsBy(How = How.LinkText, Using = "Order Materials")]
        [CacheLookup]
        public IWebElement Menu_Order_Materials { get; set; }

        //Material Production > Production Schedule
        [FindsBy(How = How.LinkText, Using = "Production Schedule")]
        [CacheLookup]
        public IWebElement Menu_Production_Schedule { get; set; }

        //Main Menu > Reporting
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[12]/a")]
        [CacheLookup]
        public IWebElement Menu_Reporting { get; set; }

        //Main Menu > Reporting > Report
        [FindsBy(How = How.LinkText, Using = "Reports")]
        [CacheLookup]
        public IWebElement Menu_Reporting_Report { get; set; }

        //Main Menu > Reporting > Report
        [FindsBy(How = How.LinkText, Using = "Stored Queries")]
        [CacheLookup]
        public IWebElement Menu_Reporting_StoredQueries { get; set; }

        //Main Menu > Reporting > Report
        [FindsBy(How = How.LinkText, Using = "Report Manager (SSRS)")]
        [CacheLookup]
        public IWebElement Menu_Reporting_ReportManager { get; set; }

        //Main menu > Purchasing
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[11]/a")]
        [CacheLookup]
        public IWebElement Menu_Purchasing { get; set; }

        //Purchasing > Search PO's
        [FindsBy(How = How.LinkText, Using = "Search PO's")]
        [CacheLookup]
        public IWebElement Menu_Purchasing_SearchPO { get; set; }

        //Purchasing > New PO
        [FindsBy(How = How.LinkText, Using = "New PO")]
        [CacheLookup]
        public IWebElement Menu_Purchasing_NewPO { get; set; }

        //Purchasing > Close/Cancel
        [FindsBy(How = How.LinkText, Using = "Close/Cancel")]
        [CacheLookup]
        public IWebElement Menu_Purchasing_Cancel { get; set; }

        //Purchasing > Vendor
        [FindsBy(How = How.LinkText, Using = "Vendors")]
        [CacheLookup]
        public IWebElement Menu_Purchasing_Vendor { get; set; }

        //Purchasing > Submitted PO's
        [FindsBy(How = How.LinkText, Using = "Submitted PO's Report")]
        [CacheLookup]
        public IWebElement Menu_Purchasing_SubmittedPO { get; set; }

        //Main Menu > User Administration
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[15]/a")]
        [CacheLookup]
        public IWebElement Menu_User_Admin { get; set; }

        //Main Menu > User Administration > Users
        [FindsBy(How = How.LinkText, Using = "Users")]
        [CacheLookup]
        public IWebElement Menu_User_Admin_Users { get; set; }

        //Main Menu > User Administration > Groups
        [FindsBy(How = How.LinkText, Using = "Groups")]
        [CacheLookup]
        public IWebElement Menu_User_Admin_Groups { get; set; }

        //Main Menu > Policy and Procedure
        [FindsBy(How = How.LinkText, Using = "Policies & Procedures")]
        [CacheLookup]
        public IWebElement Menu_PolicyProcedures {get;set;}

        //Main Menu > Mail Room
        [FindsBy(How = How.LinkText, Using = "Mail Room")]
        [CacheLookup]
        public IWebElement Menu_MailRoom { get; set; }

        //Main Menu > Time Clock
        [FindsBy(How = How.LinkText, Using = "Time Clock")]
        [CacheLookup]
        public IWebElement Menu_TimeClock { get; set; }

        //Main Menu > Help Desk - Request New User Account(s)
        [FindsBy(How = How.LinkText, Using = "Help Desk - Request New User Account(s)")]
        [CacheLookup]
        public IWebElement Menu_RequestNewUser { get; set; }

        //Main Menu > Help Desk - Icati
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[1]/ul/li[18]/a")]
        [CacheLookup]
        public IWebElement Menu_iCatiLink { get; set; }

        //SMS Job Number textbox
        [FindsBy(How = How.Id, Using = "id_project")]
        [CacheLookup]
        public IWebElement sms_job_number { get; set; }

        //SMS Find Project button
        [FindsBy(How = How.Id, Using = "btnGo")]
        [CacheLookup]
        public IWebElement sms_findProject_btn { get; set; }



    }
}

