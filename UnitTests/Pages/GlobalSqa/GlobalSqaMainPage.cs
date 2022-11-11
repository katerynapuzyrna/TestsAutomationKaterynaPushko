using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.GlobalSqa
{
    public class GlobalSqaMainPage : GlobalSqaBasePage
    {
        public GlobalSqaMainPage(IWebDriver driver) : base(driver) { }

        public IWebElement TestersHubMenuItem => driver.FindElement(By.Id("menu-item-2822"));
        public IWebElement DemoTestingSiteSubMenuItem => driver.FindElement(By.Id("menu-item-2823"));
        public IWebElement DatePickerSubMenuItem => driver.FindElement(By.Id("menu-item-2827"));
        public IWebElement ProgressBarSubMenuItem => driver.FindElement(By.Id("menu-item-2832"));
    }
}
