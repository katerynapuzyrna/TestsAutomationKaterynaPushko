using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTests.Pages.GlobalSqa
{
    public class GlobalSqaDatePickerPage : GlobalSqaBasePage
    {
        public GlobalSqaDatePickerPage(IWebDriver driver) : base(driver) { }
        public IWebElement DatePickerIframe => driver.FindElement(By.CssSelector("iframe.demo-frame.lazyloaded"));
        public IWebElement DatePickerInputField => driver.FindElement(By.CssSelector("input.hasDatepicker"));
        public int CurrentDateDay => Convert.ToInt32(driver.FindElement(By.CssSelector("a.ui-state-default.ui-state-highlight")).Text);
        public int CurrentDateMonth => Convert.ToInt32(driver.FindElement(By.CssSelector("td.ui-datepicker-days-cell-over.ui-datepicker-today")).GetAttribute("data-month")) + 1;
        public int CurrentDateYear => Convert.ToInt32(driver.FindElement(By.CssSelector("td.ui-datepicker-days-cell-over.ui-datepicker-today")).GetAttribute("data-year"));
        public IWebElement RightArrowInDatePicker => driver.FindElement(By.CssSelector("a.ui-datepicker-next.ui-corner-all"));
        public List<IWebElement> AllDaysNumbers => driver.FindElements(By.CssSelector("a.ui-state-default")).ToList();
    }
}
