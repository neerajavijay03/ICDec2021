using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICDec2021.Pages
{
    internal class HomePage
    {
        public void GotoTMPage(IWebDriver driver)
        {
            //Identify the administration and click the dropdown
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            //Identify TM option from the dropdown and click
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
