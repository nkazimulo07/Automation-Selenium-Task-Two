using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace test07
{
    public class BasePage
    {
        public IWebDriver driver;
        protected IWebElement PageRoot => driver.FindElement(By.TagName("body"));
        public WebDriverWait Wait;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

    }
}