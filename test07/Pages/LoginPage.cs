using OpenQA.Selenium;
using test07;

namespace TestCases.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement loginNameTextbox => PageRoot.FindElement(By.Id("loginFrm_loginname"));
        public IWebElement passwordTextbox => driver.FindElement(By.Id("loginFrm_password"));
        public IWebElement loginButton => driver.FindElement(By.CssSelector("#loginFrm > fieldset > button"));
    }
}
