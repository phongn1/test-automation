using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.PageObjects
{
    class iCatiProgrammingObjects
    {
        IWebDriver driver;
    

        public iCatiProgrammingObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Programming Menu
        [FindsBy(How = How.LinkText, Using = "Programming")]
        [CacheLookup]
        public IWebElement Menu_Programming { get; set; }

        //Programming > Find
        [FindsBy(How = How.LinkText, Using = "Find")]
        [CacheLookup]
        public IWebElement Menu_Programming_Find { get; set; }

        //Tools Button
        [FindsBy(How = How.XPath, Using = "/html/body/section[2]/div/div[1]/div/div/div/div/div/div/button")]
        [CacheLookup]
        public IWebElement Btn_Tools { get; set; }

        //*NEW* FInd Program ProgramID box
        [FindsBy(How = How.XPath, Using = "//*[@id='gridPrograms']/div[1]/div/table/thead/tr[2]/th[1]/span/span/span/span/input[1]")]
        [CacheLookup]
        public IWebElement programID_box { get; set; }

        //*NEW* FInd Program Program name box
        [FindsBy(How = How.XPath, Using = " //*[@id='gridPrograms']/div[1]/div/table/thead/tr[2]/th[2]/span/span/span/input")]
        [CacheLookup]
        public IWebElement programName_box { get; set; }

        // Associate studies
        [FindsBy(How = How.LinkText, Using = "Associate Studies")]
        [CacheLookup]
        public IWebElement tools_asssociatestudies { get; set; }

        // Tools > Pages 
        [FindsBy(How = How.LinkText, Using = "Pages")]
        [CacheLookup]
        public IWebElement tools_pages { get; set; }

        // Tools > Pages 
        [FindsBy(How = How.LinkText, Using = "Questions")]
        [CacheLookup]
        public IWebElement tools_questions { get; set; }

        // Tools > Options
        [FindsBy(How = How.LinkText, Using = "Options")]
        [CacheLookup]
        public IWebElement tools_options { get; set; }

        // Tools > Random Page Blocks
        [FindsBy(How = How.LinkText, Using = "Random Page Blocks")]
        [CacheLookup]
        public IWebElement tools_pageBlocks { get; set; }
    }


}
