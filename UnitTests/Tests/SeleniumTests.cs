using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTests.Tests.Tests
{
    class SeleniumTests
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeEveryTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }

        [Test]
        public void UITest1()
        {
            driver.Url = "https://www.globalsqa.com/demo-site/select-dropdown-menu/";
            int expectedCountryCount = 249;

            var countryList = driver.FindElements(By.XPath("//select/child::option"));

            Assert.That(countryList.Count(), Is.EqualTo(expectedCountryCount), $"Count of countries in the dropdowns is {countryList.Count()} that is not equal to {expectedCountryCount}");
        }

        [Test]
        public void UITest2()
        {
            driver.Url = "https://www.google.com";

            driver.FindElement(By.XPath("//form//input[@name='q']")).SendKeys("Selenium");
            driver.FindElement(By.XPath("//form//input[@name='q']")).SendKeys(Keys.Enter);
            //driver.FindElement(By.CssSelector("form > div:nth-child(1) > div > div > center > input[role='button']")).Click();
            driver.FindElement(By.CssSelector("a[href = 'https://www.selenium.dev/']")).Click();

            Assert.That(driver.Url, Is.EqualTo("https://www.selenium.dev/"), $"Url is expected to be https://www.selenium.dev/ but is {driver.Url}");
        }

        [Test]
        public void UITest3()
        {
            driver.Url = "https://www.gmail.com";
            string email = "kateryna.pushko@gmail.com";
            string password = "Q123456!";

            driver.FindElement(By.CssSelector("#identifierId")).SendKeys(email);
            driver.FindElement(By.CssSelector("#identifierNext > div > button > span")).Click();
            driver.FindElement(By.CssSelector("#password input")).SendKeys(password);
            driver.FindElement(By.CssSelector("#passwordNext > div > button > span")).Click();

            Assert.IsNotNull(driver.FindElements(By.XPath("//a[contains(@href, 'SignOutOptions')]")), "Button Exit should be found but is not");
        }

    }
}
