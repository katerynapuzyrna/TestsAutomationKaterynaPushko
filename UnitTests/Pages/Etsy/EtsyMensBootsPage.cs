using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.Etsy
{
    public class EtsyMensBootsPage : EtsyBasePage
    {
        public EtsyMensBootsPage(IWebDriver driver) : base(driver) { }

        public List<IWebElement> BootsInSearch => driver.FindElements(By.CssSelector("[data-search-results-region] ul li div[data-logger-id]:not([style]) img")).ToList();
    }
}
