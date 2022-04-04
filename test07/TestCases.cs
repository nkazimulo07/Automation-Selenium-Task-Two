//using Amazon.DynamoDBv2;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Reflection;

//namespace test07
//{
//    public class TestCases
//    {
//        private IWebDriver driver;
//        private WebDriverWait Wait;
//        private const string Url = "https://automationteststore.com/index.php";


//        private IWebElement clothesDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[2]/a"));
//        private IWebElement shoesLink => driver.FindElement(By.LinkText("Shoes"));
//        private IWebElement currencyDropdown => driver.FindElement(By.CssSelector("a.dropdown-toggle"));
//        private IWebElement euros => driver.FindElement(By.CssSelector(".currency > li:nth-child(1) > a"));
//        private IWebElement loginLink => driver.FindElement(By.XPath("//*[@id='customer_menu_top']/li/a"));
//        private IWebElement loginNameTextbox => driver.FindElement(By.CssSelector("#loginFrm_loginname"));
//        private IWebElement passwordTextbox => driver.FindElement(By.CssSelector("#loginFrm_password"));
//        private IWebElement loginButton => driver.FindElement(By.CssSelector("#loginFrm > fieldset > button"));
//        private IWebElement itemPrice => driver.FindElement(By.ClassName("oneprice"));

//        private List<IWebElement> priceList1 => new List<IWebElement>(driver.FindElements(By.ClassName("price")));
//        private IWebElement priceList => driver.FindElement(By.Id("sort"));
//        private SelectElement priceDropdownList => new SelectElement(priceList);
//        bool isSorted;
//        List<decimal> list = new List<decimal>();

//        [SetUp]
//        public void SetUp()
//        {
//            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
//            driver.Manage().Window.Maximize();
//            driver.Navigate().GoToUrl(Url);
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

//            loginLink.Click();
//            loginNameTextbox.SendKeys("nkaZee");
//            passwordTextbox.SendKeys("Nk@Z33");
//            loginButton.Click();

//        }

//        [Test]
//        public void GivenRequiredData_WhenSendingEmailViaContactUsPage_EmailSentSuccessfulMessageReturned()
//        {
//            clothesDropdown.Click();
//            shoesLink.Click();
//            currencyDropdown.Click();
//            driver.FindElement(By.CssSelector(".currency > li:nth-child(1) > a")).Click();
//            Assert.IsTrue(itemPrice.Text.Contains("€"));

//            currencyDropdown.Click();
//            driver.FindElement(By.CssSelector(".currency > li:nth-child(2) > a")).Click();
//            Assert.IsTrue(itemPrice.Text.Contains("£"));

//            currencyDropdown.Click();
//            driver.FindElement(By.CssSelector(".currency > li:nth-child(3) > a")).Click();
//            Assert.IsTrue(itemPrice.Text.Contains("$"));

//        }

//        [Test]
//        public void GivenRequiredData_WhenSendingEmailViaContactUsPage_EmailSentSuccessfulMessageReturned1()
//        {
//            clothesDropdown.Click();
//            shoesLink.Click();
//            priceDropdownList.SelectByText("Price Low > High");
//            isSorted = true;
//            list.Clear();

//            foreach (var item in priceList1)
//            {
//                if (item.Text != "")
//                {
//                    list.Add(Convert.ToDecimal(item.Text.ToString().Replace("$", "")));
//                }
//            }

//            var previousPrice = list[0];

//            for (int priceIndex = 1; priceIndex < list.Count; priceIndex++)
//            {
//                if (previousPrice > list[priceIndex])
//                {
//                    isSorted = false;
//                    break;
//                }
//                previousPrice = list[priceIndex];
//            }

//            Assert.IsTrue(isSorted);

//        }

//        [Test]
//        public void GivenRequiredData_WhenSendingEmailViaContactUsPage_EmailSentSuccessfulMessageReturned2()
//        {
//            clothesDropdown.Click();
//            shoesLink.Click();
//            priceDropdownList.SelectByText("Price High > Low");
//            isSorted = true;
//            list.Clear();

//            foreach (var item in priceList1)
//            {
//                if (item.Text != "")
//                {
//                    list.Add(Convert.ToDecimal(item.Text.ToString().Replace("$", "")));
//                }
//            }

//            var previousPrice = list[0];

//            for (int priceIndex = 1; priceIndex < list.Count; priceIndex++)
//            {
//                if (previousPrice < list[priceIndex])
//                {
//                    isSorted = false;
//                    break;
//                }
//                previousPrice = list[priceIndex];
//            }

//            Assert.IsTrue(isSorted);

//        }

//        [Test]
//        public void GivenRequiredData_WhenSendingEmailViaContactUsPage_EmailSentSuccessfulMessageReturned20()
//        {
//            driver.FindElement(By.LinkText("Facebook")).Click();
//            var facebookUrl = "https://www.facebook.com/";
//            var resultsUrl = driver.Url;
//            driver.SwitchTo(WindowHandles);
//            Assert.AreEqual(facebookUrl, resultsUrl);
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            driver.Dispose();
//        }
//    }
//}


//foreach (var price in priceList)
//{
//    var test = price.Text;

//    if (test != "")
//    {
//        Assert.IsTrue(test.Contains("€"));
//    }
//}