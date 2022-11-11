using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.Etsy
{
    public class EtsyCartPage : EtsyBasePage
    {
        public EtsyCartPage(IWebDriver driver) : base(driver) { }

        public string ItemsTotalPrice => driver.FindElement(By.CssSelector(".cart-payment-section .wt-text-body-01 .money *:nth-child(2)")).Text;
    }
}
