using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace AutomationFramework.PageObjects
{
    public class ICatiUserObjects
    {
        IWebDriver driver;

        public ICatiUserObjects(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        // iCati User Menu
        [FindsBy(How = How.LinkText, Using = "User")]
        [CacheLookup]
        public IWebElement Menu_User { get; set; }

        // iCati Find User Menu
        [FindsBy(How = How.LinkText, Using = "Find User")]
        [CacheLookup]
        public IWebElement Menu_FindUser { get; set; }

        // User Name box
        [FindsBy(How = How.XPath, Using = "//*[@id='UserSearchGrid']/table/thead/tr[2]/th[1]/span/span/span/input")]
        [CacheLookup]
        public IWebElement UserName_Box { get; set; }

        // iCati New User Menu
        [FindsBy(How = How.LinkText, Using = "New User")]
        [CacheLookup]
        public IWebElement Menu_NewUser { get; set; }

        // iCati New User Menu
        [FindsBy(How = How.LinkText, Using = "Assign Studies/Group")]
        [CacheLookup]
        public IWebElement Menu_User_AssignStudies { get; set; }
    }
}
