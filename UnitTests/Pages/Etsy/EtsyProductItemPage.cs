using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace UnitTests.Pages.Etsy
{
    public class EtsyProductItemPage : EtsyBasePage
    {
        public EtsyProductItemPage(IWebDriver driver) : base(driver) { }

        public string Price => driver.FindElement(By.CssSelector("#listing-page-cart [data-buy-box-region='price']  [class*='wt-flex-wrap'] p")).Text.Split().Last();

        public SelectElement SizeDropdown => new SelectElement(driver.FindElement(By.XPath("//label[contains(text(), 'Size')]/..//select")));
        public SelectElement PrimaryColorDropdown => new SelectElement(driver.FindElement(By.XPath("//label[contains(text(), 'Primary color')]/..//select")));
        public IWebElement AddToCartButton => driver.FindElement(By.CssSelector("[data-add-to-cart-button] button"));
        public IWebElement ViewCartAndCheckoutButton => driver.FindElement(By.CssSelector(".wt-pb-xs-2  [href*='https://www.etsy.com/cart']"));
        public IWebElement VisibleSpinner => driver.FindElement(By.CssSelector(".wt-spinner.wt-display-block"));
        public IWebElement SpinnerElement => driver.FindElement(By.CssSelector("#listing-page-cart [data-buy-box-region='price']  [class*='wt-flex-wrap'] div"));
    }
}
