using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using test07;

namespace TestCases.Pages
{
    public class SortPage : BasePage
    {
        public SortPage(IWebDriver driver) : base(driver)
        {

        }

        public List<decimal> list = new List<decimal>();
        private IWebElement priceList => driver.FindElement(By.Id("sort"));
        public SelectElement priceDropdownList => new SelectElement(priceList);
        public List<IWebElement> itemPricesList => new List<IWebElement>(driver.FindElements(By.ClassName("price")));
        public bool isSorted;
    }
}
