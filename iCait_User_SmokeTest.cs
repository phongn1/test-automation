using System.Threading;
using NUnit.Framework;
using DssSmokeTest.Parallel;
using AutomationFramework.PageMethods;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;

namespace DssSmokeTest.iCati_Tests
{

    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class iCait_User_SmokeTest : BaseFixture
    {

        [Test]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethod2()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethod3()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethod4()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethod5()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethod6()
        {
            Assert.IsTrue(true);
        }

    }
}
