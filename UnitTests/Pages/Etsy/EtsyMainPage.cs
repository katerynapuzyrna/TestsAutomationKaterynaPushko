using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Pages.Etsy
{
    public class EtsyMainPage : EtsyBasePage
    {
        public EtsyMainPage(IWebDriver driver) : base(driver) { }

        #region WebElements

        public IWebElement ClothingAndShoesMenuItem => driver.FindElement(By.Id("catnav-primary-link-10923"));
        public IWebElement MensSubMenuItem => driver.FindElement(By.Id("side-nav-category-link-10936"));
        public IWebElement MensBootsSubMenuItem => driver.FindElement(By.Id("catnav-l4-11109"));

        #endregion
    }
}
