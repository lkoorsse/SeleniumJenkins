using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumJenkins.PageObjects;

namespace SeleniumJenkins
{
   // [TestClass]
    public class TestAcademyBasicUnit
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //   driver.Manage().Window.Maximize();
        }


        [Test]
        public void TestAcademyBasic()
        {

            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
          //  ResultPage result = about.search("selenium c#");
            //  result.clickOnFirstArticle();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
