using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class FacebookTest : BaseTest
    {
        //IWebDriver driver;

        [Test]
        public void GivenFacebookIcon_WhenClickingTheIcon_FacebookPageReturned()
        {
            StoreApp.MainPage.facebookIcon.Click();
            var facebookUrl = "https://www.facebook.com/";
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            var resultsUrl = driver.Url;
            driver.Close();

            Assert.AreEqual(facebookUrl, resultsUrl);

        }
    }
}
