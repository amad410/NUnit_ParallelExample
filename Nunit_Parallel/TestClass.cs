// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Nunit_Parallel
{
    [TestFixture]
    public class TestClass
    {
        public IWebDriver _driver;

        [Test]
        [Parallelizable]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("http://www.espn.com");
           
        }

        [Test]
        [Parallelizable]
        public void TestMethod2()
        {
            _driver.Navigate().GoToUrl("http://www.google.com");
        }

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Teardown()
        {
            //Also try to replace driver.close() with driver.quit();
            _driver.Quit();
        }

    }
}
