
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace AutomationFramework
{
    public class iCatiPageObjects
    {
        IWebDriver driver;

        //New Username
        [FindsBy(How = How.Id, Using = "UserName")]
        [CacheLookup]
        public IWebElement NewUserName { get; set; }

        //New Password
        [FindsBy(How = How.Id, Using = "Password")]
        [CacheLookup]
        public IWebElement NewPassword { get; set; }

        //Login
        [FindsBy(How = How.Id, Using = "ctl00_content_main_frm_login_submit")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        //New Login button
        [FindsBy(How = How.Id, Using = "btnSignIn")]
        [CacheLookup]
        public IWebElement NewSubmit { get; set; }

        //Project ID Text box
        [FindsBy(How = How.XPath, Using = "//*[@id='StudiesGrid']/table/thead/tr[2]/th[1]/span/span/span/span/input[1]")]
        [CacheLookup]
        public IWebElement ProjectIdBox { get; set; }
  
        //Study Name Text box
        [FindsBy(How = How.XPath, Using = "//*[@id='StudiesGrid']/table/thead/tr[3]/th[3]/span/span/span/input")]
        [CacheLookup]
        public IWebElement StudyNamebox { get; set; }

        //Study ID Text box
        [FindsBy(How = How.XPath, Using = "html/body/section[2]/div[1]/form/div/div/table/thead/tr[3]/th[2]/span/span/span/span/input[1]")]
        [CacheLookup]
        public IWebElement StudyIDBox { get; set; }

        //NewStudy -Study Name Box
        [FindsBy(How = How.XPath, Using = "html/body/section[2]/div[1]/form/div[1]/div[2]/div[2]/div[1]/div/div[1]/div/input[1]")]
        [CacheLookup]
        public  IWebElement NewStudyNameBox { get; set; }

        //NewStudy - Select Quota Project
        [FindsBy(How = How.Id, Using = "Study_quota_type")]
        [CacheLookup]
        public  IWebElement selectProject { get; set; }

        //Shift Type
        [FindsBy(How = How.Id, Using = "Study_shift_type")]
        [CacheLookup]
        public  IWebElement shiftType { get; set; }

        //Data Layout Selection
        [FindsBy(How = How.Id, Using = "Study_id_dmap")]
        [CacheLookup]
        public  IWebElement dataMap { get; set; }

        //Web Data Layout
        [FindsBy(How = How.Id, Using = "Study_id_dmap_www")]
        [CacheLookup]
        public  IWebElement dataMap_www { get; set; }

        // OLD - Study link
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/table/tbody/tr[2]/td/div/ul/li[2]/a")]
        [CacheLookup]
        public  IWebElement old_StudyLink { get; set; }

        //Study drop down Menu
        [FindsBy(How = How.XPath, Using = "//*[@id='primary_nav_wrap']/ul/li[2]/a")]
        [CacheLookup]
        public IWebElement study_dropdown { get; set; }

        // New Group - Call group
        [FindsBy(How = How.Id, Using = ("btnAdd"))]
        [CacheLookup]
        public  IWebElement CallGroup_NewGroupBtn {get;set;}

        //Mangement Menu
        [FindsBy(How = How.XPath, Using = ("//*[@id='primary_nav_wrap']/ul/li[1]/a"))]
        [CacheLookup]
        public IWebElement Menu_Management { get; set; }

        //New Mangement Menu
        [FindsBy(How = How.XPath, Using = ("/html/body/header/div/div[3]/ul/li[1]/a"))]
        [CacheLookup]
        public IWebElement New_Menu_Management { get; set; }

        //Management > User Activity(Old)
        [FindsBy(How = How.LinkText, Using =("User Activity (old)"))]
        [CacheLookup]
        public IWebElement Menu_UserActivity_Old { get; set; }

        //Management > User Activity New
        [FindsBy(How = How.LinkText, Using = ("User Activity (new)"))]
        [CacheLookup]
        public IWebElement Menu_UserActivity_New { get; set; }

        //Management > Job Activity
        [FindsBy(How = How.LinkText, Using =("Job Activity"))]
        [CacheLookup]
        public IWebElement Menu_JobActivity { get; set; }

        //Management > Interview times
        [FindsBy(How = How.LinkText, Using = ("Interview Times"))]
        [CacheLookup]
        public IWebElement Menu_InterviewTimes { get; set; }

        //Management > Overnight Call Backs Audit Tool
        [FindsBy(How = How.LinkText, Using = ("Overnight Call Backs Audit Tool"))]
        [CacheLookup]
        public IWebElement Menu_CallBackTool { get; set; }

        //Management > Overnight Call Backs Audit Tool
        [FindsBy(How = How.XPath, Using = ("/html/body/header/div/div[3]/ul/li[1]/ul/li[4]/a"))]
        [CacheLookup]
        public IWebElement New_Menu_CallBackTool { get; set; }

        //Management > Open Sample Records
        [FindsBy(How = How.XPath, Using = ("//div[@id='primary_nav_wrap']/ul/li[1]/ul/li[7]/a"))]
        [CacheLookup]
        public IWebElement Menu_Open_Sample_Records { get; set; }

        //Management > Open Sample Records > Live
        [FindsBy(How = How.LinkText, Using = ("Live"))]
        [CacheLookup]
        public IWebElement Menu_Open_Sample_Records_Live { get; set; }

        //Management > Open Sample Records > Practice
        [FindsBy(How = How.LinkText, Using = ("Practice"))]
        [CacheLookup]
        public IWebElement Menu_Open_Sample_Records_Pracice { get; set; }

        //Management > Search Recordings
        [FindsBy(How = How.LinkText, Using = ("Search Recordings"))]
        [CacheLookup]
        public IWebElement Menu_Search_Recordings { get; set; }

        //Management > Examine System Errors
        [FindsBy(How = How.LinkText, Using = ("Examine System Errors"))]
        [CacheLookup]
        public IWebElement Menu_ExamineSysErrors { get; set; }

        //Management > Review 'Remove From List' Dispositions
        [FindsBy(How = How.LinkText, Using = ("Review 'Remove From List' Dispositions"))]
        [CacheLookup]
        public IWebElement Menu_Review_Disp { get; set; }

        //Management > QA
        [FindsBy(How = How.XPath, Using = ("//div[@id='primary_nav_wrap']/ul/li[1]/ul/li[11]/a"))] 
        [CacheLookup]
        public IWebElement Menu_QA { get; set; }

        //Managemetn > QA > QA Callback
        [FindsBy(How = How.LinkText, Using = ("QA Call Back"))]
        [CacheLookup]
        public IWebElement Menu_QAcallback { get; set; }

        //Management > QA > QA Management
        [FindsBy(How = How.LinkText, Using =("QA Management"))] 
        [CacheLookup]
        public IWebElement Menu_QAmanagement { get; set; }

        //Management > QA > QA
        [FindsBy(How = How.LinkText, Using = ("Quality Assurance"))]
        [CacheLookup]
        public IWebElement Menu_QA_QA { get; set; }

        //Management > QA > Reports
        [FindsBy(How = How.XPath, Using =("//ul[@class='dropdown-menu']/li[4]"))]
        [CacheLookup]
        public IWebElement Menu_QA_Reports { get; set; }

        //Management > QA >Reports > Project
        [FindsBy(How = How.LinkText, Using =("Project"))]
        [CacheLookup]
        public IWebElement Menu_Reports_Project { get; set; }

        //Manangement > QA > Reports > Interviewer
        [FindsBy(How = How.LinkText, Using = ("Interviewer"))]
        [CacheLookup]
        public IWebElement Menu_Reports_Interviewer { get; set; }

        //Manangement > QA > Reports > Reviews
        [FindsBy(How = How.LinkText, Using = ("Reviews"))]
        [CacheLookup]
        public IWebElement Menu_Reports_Reviews { get; set; }

        //Manangement > QA > Reports > Vendor
        [FindsBy(How = How.LinkText, Using = ("Vendor"))]
        [CacheLookup]
        public IWebElement Menu_Reports_Vendor { get; set; }

        //Management > Events 
        [FindsBy(How = How.XPath, Using =("//div[@id='primary_nav_wrap']/ul/li[1]/ul/li[12]/a"))]
        [CacheLookup]
        public IWebElement Menu_Events { get; set; }

        //Management > Events > Create
        [FindsBy(How = How.LinkText, Using =("Create"))]
        [CacheLookup]
        public IWebElement Menu_Events_Create { get; set; }

        //Management > Events > Find
        [FindsBy(How = How.LinkText, Using = ("Find"))]
        [CacheLookup]
        public IWebElement Menu_Events_Find { get; set; }

        //Management > Search Internet Surveys
        [FindsBy(How = How.LinkText, Using = ("Search Internet Surveys"))]
        [CacheLookup]
        public IWebElement Menu_isurvey_search { get; set; }

        //Internet Survey Search box
        [FindsBy(How = How.XPath, Using = ("//*[@id='criteria']"))]
        [CacheLookup]
        public IWebElement isurvey_box { get; set; }

        //Internet Survey Search button
        [FindsBy(How = How.LinkText, Using = ("Search Surveys (new)"))]
        [CacheLookup]
        public IWebElement Menu_search_surveys { get; set; }

        //Vendor Users
        [FindsBy(How = How.LinkText, Using = ("Users"))]
        [CacheLookup]
        public IWebElement Menu_Vendor_Users { get; set; }

        //Management > Monitor
        [FindsBy(How = How.LinkText, Using = ("Monitor"))]
        [CacheLookup]
        public IWebElement Menu_Monitor { get; set; }

        //Management > Single Call Monitor Report
        [FindsBy(How = How.LinkText, Using = ("Single Call Monitor Report"))]
        [CacheLookup]
        public IWebElement Menu_Monitor_singlecall { get; set; }

        //Mangement > Batch Call Monitor Reports
        [FindsBy(How = How.LinkText, Using = ("Batch Call Monitor Reports"))]
        [CacheLookup]
        public IWebElement Menu_Monitor_BatchCall { get; set; }

        //Study > Find Study
        [FindsBy(How = How.LinkText, Using = ("Find Study"))]
        [CacheLookup]
        public IWebElement study_findstudy { get; set; }

        //New Study Properties - Study Name
        [FindsBy(How = How.Id, Using = ("Study_studyname"))]
        [CacheLookup]
        public IWebElement new_study_name { get; set; }

        //New Study Properties - Study Quota
        [FindsBy(How = How.Id, Using = ("Study_quota_type"))]
        [CacheLookup]
        public IWebElement new_study_qouta { get; set; }

        //New Study Properties - Shift type
        [FindsBy(How = How.Id, Using = ("Study_shift_type"))]
        [CacheLookup]
        public IWebElement new_study_shifttype { get; set; }

        //New Study Properties - Data Layout
        [FindsBy(How = How.Id, Using = ("Study_id_dmap"))]
        [CacheLookup]
        public IWebElement new_study_dataLayout { get; set; }

        //Study > New Study Menu
        [FindsBy(How = How.LinkText, Using = ("New Study"))]
        [CacheLookup]
        public IWebElement study_new_study { get; set; }

        //Study > Project/Study Groups menu
        [FindsBy(How = How.XPath, Using = ("//*[@id='primary_nav_wrap']/ul/li[2]/ul/li[3]/a"))]
        [CacheLookup]
        public IWebElement project_study_group { get; set; }

        //Study > call groups - Group Name  text box
        [FindsBy(How = How.Id, Using = ("CallGroupEntity_g_name"))]
        [CacheLookup]
        public IWebElement call_group_name { get; set; }

        //Study > Call Groups
        [FindsBy(How = How.LinkText, Using = ("Call Groups"))]
        [CacheLookup]
        public IWebElement call_group { get; set; }

        //Call Group Mode Practice 
        [FindsBy(How = How.CssSelector, Using = ("CallGroupEntity_CallGroupMode[value='Practice']"))]
        [CacheLookup]
        public IWebElement call_group_mode_practice { get; set; }

        //Call group Drop down list
        [FindsBy(How = How.Id, Using = ("EventArgument"))]
        [CacheLookup]
        public IWebElement call_group_dropdown { get; set; }

        //Call group study checkbox
        [FindsBy(How = How.XPath, Using = ("//*[@id='StudiesGrid']/table/tbody/tr/td[1]/label"))]
        [CacheLookup]
        public IWebElement call_group_study_checkbox { get; set; }

        //Study > Bulk Editor
        [FindsBy(How = How.LinkText, Using = ("Bulk Editor"))]
        [CacheLookup]
        public IWebElement study_Bulk_Editor { get; set; }

        public iCatiPageObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

    }



}
