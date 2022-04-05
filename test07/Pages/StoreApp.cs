using OpenQA.Selenium;
using test07.Pages;

namespace TestCases.Pages
{
    public class StoreApp
    {
        public static LoginPage LoginPage;
        public static MainPage MainPage;
        public static CurrencyValidationPage CurrencyValidationPage;
        public static SortPage SortPage;

        public static void Init(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://automationteststore.com/index.php");
            MainPage = new MainPage(driver);
            LoginPage = new LoginPage(driver);
            CurrencyValidationPage = new CurrencyValidationPage(driver);
            SortPage = new SortPage(driver);
        }

    }
}
