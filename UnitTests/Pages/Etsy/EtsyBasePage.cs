using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.Etsy
{
    public class EtsyBasePage
    {
        protected IWebDriver driver;

        public EtsyBasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
