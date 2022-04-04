using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test07;

namespace TestCases.Pages
{
    public class CurrencyValidationPage : BasePage
    {
        public CurrencyValidationPage(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement itemPrice => driver.FindElement(By.ClassName("oneprice"));

        private List<IWebElement> priceList1 => new List<IWebElement>(driver.FindElements(By.ClassName("price")));
        private IWebElement priceList => driver.FindElement(By.Id("sort"));
        private SelectElement priceDropdownList => new SelectElement(priceList);
        bool isSorted;
        List<decimal> list = new List<decimal>();
        public IWebElement euroCurrency => driver.FindElement(By.CssSelector(".currency > li:nth-child(1) > a"));
        public IWebElement poundCurrency => driver.FindElement(By.CssSelector(".currency > li:nth-child(2) > a"));
        public IWebElement dollarCurrency => driver.FindElement(By.CssSelector(".currency > li:nth-child(3) > a"));

    }
}
