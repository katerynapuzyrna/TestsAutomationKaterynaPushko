using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.GlobalSqa
{
    public class GlobalSqaBasePage
    {
        protected IWebDriver driver;

        public GlobalSqaBasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
