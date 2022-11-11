using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.Etsy;
using UnitTests.Pages.GlobalSqa;

namespace UnitTests.Tests
{
    public class EtsyTests
    {
        public IWebDriver driver;
        public WebDriverWait webDriverWait;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void AddItemToCartAndCheckPrice()
        {
            // Arrange
            driver.Url = "https://www.etsy.com/";

            // Act
            var etsyMainPage = new EtsyMainPage(driver);
            Actions actions = new Actions(driver);
            actions.MoveToElement(etsyMainPage.ClothingAndShoesMenuItem).Perform();

            //.Pause(TimeSpan.FromSeconds(2))

            bool IsMensSubMenuItemAvailable(IWebDriver driver)
            {
                try
                {
                    etsyMainPage.MensSubMenuItem.Click();
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            webDriverWait.Until(IsMensSubMenuItemAvailable);

            // Thread.Sleep(3000);

            actions.MoveToElement(etsyMainPage.MensSubMenuItem)
                .Click(etsyMainPage.MensBootsSubMenuItem)
                .Perform();

            var etsyMensBootsPage = new EtsyMensBootsPage(driver);
            var startHandle = driver.CurrentWindowHandle;
            etsyMensBootsPage.BootsInSearch.First().Click();
            var handles = driver.WindowHandles;

            foreach (var handle in handles)
            {
                if (handle != startHandle)
                {
                    driver.SwitchTo().Window(handle);
                }
            }

            var etsyProductItemPage = new EtsyProductItemPage(driver);
            var productItemPagePrice = etsyProductItemPage.Price;
           
            //etsyProductItemPage.PrimaryColorDropdown.SelectByIndex(1);

            //Thread.Sleep(3000);

            etsyProductItemPage.SizeDropdown.SelectByIndex(1);

            //Thread.Sleep(3000);

            bool IsAddToCartButtonAvailable(IWebDriver driver)
            {
                try
                {
                    etsyProductItemPage.AddToCartButton.Click();
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            webDriverWait.Until(IsAddToCartButtonAvailable);

            etsyProductItemPage.AddToCartButton.Click();
            etsyProductItemPage.ViewCartAndCheckoutButton.Click();
            var etsyCartPage = new EtsyCartPage(driver);
            var cartPagePrice = etsyCartPage.ItemsTotalPrice;

             // Assert
             Assert.True(productItemPagePrice == cartPagePrice,
                $"Price '{productItemPagePrice}' on the Product item page is not equal " +
                $"price {cartPagePrice} on the Cart page.");
        }
    }
}