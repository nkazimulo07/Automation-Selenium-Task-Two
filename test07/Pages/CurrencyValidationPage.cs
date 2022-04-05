using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using test07;

namespace TestCases.Pages
{
    public class CurrencyValidationPage : BasePage
    {
        public CurrencyValidationPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement itemPrice => driver.FindElement(By.ClassName("oneprice"));
        bool isSorted;
        List<decimal> list = new List<decimal>();
        public IWebElement euroCurrency => driver.FindElement(By.CssSelector(".currency > li:nth-child(1) > a"));
        public IWebElement poundCurrency => driver.FindElement(By.CssSelector(".currency > li:nth-child(2) > a"));
        public IWebElement dollarCurrency => driver.FindElement(By.CssSelector(".currency > li:nth-child(3) > a"));

    }
}
