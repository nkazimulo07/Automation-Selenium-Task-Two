using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class BaseTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            StoreApp.Init(driver);

            StoreApp.MainPage.loginLink.Click();

            StoreApp.LoginPage.loginNameTextbox.SendKeys("nkaZee");
            StoreApp.LoginPage.passwordTextbox.SendKeys("Nk@Z33");
            StoreApp.LoginPage.loginButton.Click();

        }


        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
