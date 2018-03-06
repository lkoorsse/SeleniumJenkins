using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;



namespace SeleniumJenkins.PageObjects
{
    public class AboutPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        //[FindsBy(How = How.CssSelector, Using = ".fusion-custom-menu-item")]
        //private IWebElement searchIcon;

        //[FindsBy(How = How.CssSelector, Using = ".s")]
        //private IWebElement searchText;

        //[FindsBy(How = How.CssSelector, Using = ".searchsubmit")]
        //private IWebElement searchSelect;



        public ResultPage search(string text)
        {

          //  searchIcon.Click();
            //   wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".fusion-custom-menu-item")))searchIcon.Click();

           // searchText.SendKeys(text);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".searchsubmit"))).Click();
            return new ResultPage(driver);
        }
    }
}
