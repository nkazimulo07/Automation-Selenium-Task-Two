using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Reflection;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;
        Actions action;
        public const string loginName = "nkaZee";
        public const string password = "Nk@Z33";
        

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            StoreApp.Init(driver);
            action = new Actions(driver);
            StoreApp.MainPage.loginLink.Click();

            StoreApp.LoginPage.loginNameTextbox.SendKeys(loginName);
            StoreApp.LoginPage.passwordTextbox.SendKeys(password);
            StoreApp.LoginPage.loginButton.Click();

        }

        [TearDown]
        public void TearDown()
        {
            action.MoveToElement(StoreApp.MainPage.logoutLink).Perform();
            StoreApp.MainPage.logoutLabel.Click();

            driver.Dispose();
        }
    }
}
