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
using OpenQA.Selenium.Remote;

namespace DssSmokeTest.iCati_Tests
{
    class iCatiTimeClock
    {
        IWebDriver headlessDriver;

        [SetUp]
        public void Inititialize()
        {
            headlessDriver = new RemoteWebDriver(DesiredCapabilities.HtmlUnit());
        }
    }
}
