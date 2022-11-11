using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.GlobalSqa
{
    internal class GlobalSqaProgressBarPage : GlobalSqaBasePage
    {
        public GlobalSqaProgressBarPage(IWebDriver driver) : base(driver) { }
        public IWebElement DownloadButton => driver.FindElement(By.Id("downloadButton"));
        public IWebElement ProgressLabel => driver.FindElement(By.CssSelector("div.progress-label"));
        public IWebElement DownloadButtonIframe => driver.FindElement(By.CssSelector("iframe.demo-frame.lazyloaded"));
    }
}
