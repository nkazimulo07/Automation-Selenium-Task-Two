using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class SortTests : BaseTest
    {
        [Test]
        public void GivenYoureLoggedIn_WhenSortingTheProductFromTheMostExpensive_ProductSortedToPriceAscending()
        {
            StoreApp.MainPage.clothesDropdown.Click();
            StoreApp.MainPage.shoesLink.Click();
            StoreApp.SortPage.priceDropdownList.SelectByText("Price Low > High");

            StoreApp.SortPage.isSorted = true;
            StoreApp.SortPage.list.Clear();

            foreach (var item in StoreApp.SortPage.priceList1)
            {
                if (item.Text != "")
                {
                    StoreApp.SortPage.list.Add(Convert.ToDecimal(item.Text.ToString().Replace("$", "")));
                }
            }

            var previousPrice = StoreApp.SortPage.list[0];

            for (int priceIndex = 1; priceIndex < StoreApp.SortPage.list.Count; priceIndex++)
            {
                if (previousPrice > StoreApp.SortPage.list[priceIndex])
                {
                    StoreApp.SortPage.isSorted = false;
                    break;
                }
                previousPrice = StoreApp.SortPage.list[priceIndex];
            }

            Assert.IsTrue(StoreApp.SortPage.isSorted);

        }

        [Test]
        public void GivenYoureLoggedIn_WhenSortingTheProductFromTheMostExpensive_ProductSortedToPriceDescending()
        {
            StoreApp.MainPage.clothesDropdown.Click();
            StoreApp.MainPage.shoesLink.Click();
            StoreApp.SortPage.priceDropdownList.SelectByText("Price High > Low");

            StoreApp.SortPage.isSorted = true;
            StoreApp.SortPage.list.Clear();

            foreach (var item in StoreApp.SortPage.priceList1)
            {
                if (item.Text != "")
                {
                    StoreApp.SortPage.list.Add(Convert.ToDecimal(item.Text.ToString().Replace("$", "")));
                }
            }

            var previousPrice = StoreApp.SortPage.list[0];

            for (int priceIndex = 1; priceIndex < StoreApp.SortPage.list.Count; priceIndex++)
            {
                if (previousPrice < StoreApp.SortPage.list[priceIndex])
                {
                    StoreApp.SortPage.isSorted = false;
                    break;
                }
                previousPrice = StoreApp.SortPage.list[priceIndex];
            }

            Assert.IsTrue(StoreApp.SortPage.isSorted);

        }
    }
}
