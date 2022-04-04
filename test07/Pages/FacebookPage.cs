using OpenQA.Selenium;
using test07;

namespace TestCases.Pages
{
    public class FacebookPage : BasePage
    {
        public FacebookPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement facebookLabel => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/div/img"));

    }
}
