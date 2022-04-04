using NUnit.Framework;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class CurrencyValidationTest : BaseTest
    {
        [Test]
        public void GivenYoureLoggedIn_WhenValidatingCurrency_ProductsWithChoosenCurrencyReturned()
        {
            StoreApp.MainPage.clothesDropdown.Click();
            StoreApp.MainPage.shoesLink.Click();
            StoreApp.MainPage.currencyDropdown.Click();
            StoreApp.CurrencyValidationPage.euroCurrency.Click();
            Assert.IsTrue(StoreApp.CurrencyValidationPage.itemPrice.Text.Contains("€"));

            StoreApp.MainPage.currencyDropdown.Click();
            StoreApp.CurrencyValidationPage.poundCurrency.Click();
            Assert.IsTrue(StoreApp.CurrencyValidationPage.itemPrice.Text.Contains("£"));

            StoreApp.MainPage.currencyDropdown.Click();
            StoreApp.CurrencyValidationPage.dollarCurrency.Click();
            Assert.IsTrue(StoreApp.CurrencyValidationPage.itemPrice.Text.Contains("$"));

        }
    }
}
