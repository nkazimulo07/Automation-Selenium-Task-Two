using NUnit.Framework;
using TestCases.Pages;

namespace TestCases.Tests
{
    public class FacebookTest : BaseTest
    {
        [Test]
        public void GivenFacebookIcon_WhenClickingTheIcon_FacebookPageReturned()
        {
            StoreApp.MainPage.facebookIcon.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Assert.IsTrue(StoreApp.FacebookPage.facebookPage.Displayed);

            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            //var resultsUrl = driver.Url;
            //var facebookUrl = "https://www.facebook.com/";
            //Assert.AreEqual(facebookUrl, resultsUrl);

        }
    }
}
