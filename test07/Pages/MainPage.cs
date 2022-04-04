using OpenQA.Selenium;

namespace test07.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement loginLink => driver.FindElement(By.XPath("//*[@id='customer_menu_top']/li/a"));
        public IWebElement clothesDropdown => driver.FindElement(By.XPath("//*[@id='categorymenu']/nav/ul/li[2]/a"));
        public IWebElement shoesLink => driver.FindElement(By.XPath("//*[@id='maincontainer']/div/div/div/div/ul/li[1]/div/a"));
        public IWebElement currencyDropdown => driver.FindElement(By.CssSelector("a.dropdown-toggle"));
        public IWebElement logoutLink => driver.FindElement(By.XPath("//*[@id='customer_menu_top']/li/a/div"));
        public IWebElement logoutLabel => driver.FindElement(By.XPath("//*[@id='customer_menu_top']/li/ul/li[10]"));
        
    }
}
