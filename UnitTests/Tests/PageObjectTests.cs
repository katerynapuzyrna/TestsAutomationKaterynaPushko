using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Pages.GlobalSqa;

namespace UnitTests.Tests.Tests
{
    public class PageObjectTests
    {
        public IWebDriver driver;
        public WebDriverWait? webDriverWait;
        public Actions actions;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            actions = new Actions(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.globalsqa.com/";

            var globalSqaMainPage = new GlobalSqaMainPage(driver);

            actions
                .MoveToElement(globalSqaMainPage.TestersHubMenuItem)
                .MoveToElement(globalSqaMainPage.DemoTestingSiteSubMenuItem)
                .Click(globalSqaMainPage.DatePickerSubMenuItem)
                .Perform();

            var globalSqaDatePickerPage = new GlobalSqaDatePickerPage(driver);
            driver.SwitchTo().Frame(globalSqaDatePickerPage.DatePickerIframe);

            globalSqaDatePickerPage.DatePickerInputField.Click();
            int currentDateDay = globalSqaDatePickerPage.CurrentDateDay;
            string dateInCorrectFormatExpected = $"{globalSqaDatePickerPage.CurrentDateMonth + 1}/{globalSqaDatePickerPage.CurrentDateDay}/{globalSqaDatePickerPage.CurrentDateYear}";

            globalSqaDatePickerPage.RightArrowInDatePicker.Click();
            globalSqaDatePickerPage.AllDaysNumbers[currentDateDay - 1].Click();
            string dateActual = globalSqaDatePickerPage.DatePickerInputField.GetAttribute("value");

            Assert.That(dateActual, Is.EqualTo(dateInCorrectFormatExpected), $"Date format is {dateActual}, but expected {dateInCorrectFormatExpected}");
        }

        [Test]
        public void Test2()
        {
            driver.Url = "https://www.globalsqa.com/";

            var globalSqaMainPage = new GlobalSqaMainPage(driver);

            actions
                .MoveToElement(globalSqaMainPage.TestersHubMenuItem)
                .MoveToElement(globalSqaMainPage.DemoTestingSiteSubMenuItem)
                .Click(globalSqaMainPage.ProgressBarSubMenuItem)
                .Perform();

            var globalSqaProgressBarPage = new GlobalSqaProgressBarPage(driver);
            driver.SwitchTo().Frame(globalSqaProgressBarPage.DownloadButtonIframe);
            globalSqaProgressBarPage.DownloadButton.Click();

            int secondsToWaitTheFileDownloading = 20;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secondsToWaitTheFileDownloading));

            bool IsElementHasText(IWebDriver driver)
            {
                return globalSqaProgressBarPage.ProgressLabel.Text == "Complete!";
            }
           
            try
            {
                webDriverWait.Until(IsElementHasText);
            }
            catch (WebDriverTimeoutException)
            {
                 Assert.Fail($"Timeout exception occured: couldn't load the file for {secondsToWaitTheFileDownloading} seconds");
            }
            catch (Exception)
            {
                 Assert.Fail("Unexpected error occured");
            }
        }
    }
}