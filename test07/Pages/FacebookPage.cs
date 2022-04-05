using OpenQA.Selenium;
using test07;

namespace TestCases.Pages
{
    public class FacebookPage : BasePage
    {
        public FacebookPage(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement facebookPage => driver.FindElement(By.Id("facebook"));
        
    }
}
