using NUnit.Framework;
using System.Collections.Generic;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class CurrencyValidationTest : BaseTest
    {
        List<string> currencies= new List<string>() { "€", "£", "$" };

        [Test]
        public void GivenYouAreLoggedIn_WhenValidatingCurrency_ProductsWithChoosenCurrencyReturned()
        {
            StoreApp.MainPage.clothesDropdown.Click();
            StoreApp.MainPage.shoesLink.Click();
            StoreApp.MainPage.currencyDropdown.Click();
            StoreApp.CurrencyValidationPage.euroCurrency.Click();
            Assert.IsTrue(StoreApp.CurrencyValidationPage.itemPrice.Text.Contains(currencies[0]));

            StoreApp.MainPage.currencyDropdown.Click();
            StoreApp.CurrencyValidationPage.poundCurrency.Click();
            Assert.IsTrue(StoreApp.CurrencyValidationPage.itemPrice.Text.Contains(currencies[1]));

            StoreApp.MainPage.currencyDropdown.Click();
            StoreApp.CurrencyValidationPage.dollarCurrency.Click();
            Assert.IsTrue(StoreApp.CurrencyValidationPage.itemPrice.Text.Contains(currencies[2]));

        }
    }
}
