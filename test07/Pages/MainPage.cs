using OpenQA.Selenium;

namespace test07.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement loginLink => driver.FindElement(By.XPath("//*[@id='customer_menu_top']//a[contains(.,'Login')]"));
        public IWebElement clothesDropdown => driver.FindElement(By.XPath("//section[@id='categorymenu']//a[contains(.,'Apparel')]"));
        public IWebElement shoesLink => driver.FindElement(By.XPath("//div[@id='maincontainer']//a[contains(.,'Shoes')]"));
        public IWebElement currencyDropdown => driver.FindElement(By.CssSelector("a.dropdown-toggle"));
        public IWebElement logoutLink => driver.FindElement(By.XPath("//ul[@id='customer_menu_top']//li[contains(.,'Welcome')]"));
        public IWebElement logoutLabel => driver.FindElement(By.XPath("//ul[@id='customer_menu_top']//li[contains(.,'Logoff')]"));
        public IWebElement facebookIcon => driver.FindElement(By.CssSelector("a.facebook"));

    }
}