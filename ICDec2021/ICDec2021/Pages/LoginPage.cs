using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICDec2021.Pages
{
    internal class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {
            //Open Chrome Browser
            

            //Launch TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            //Identify username textbox and enter valid username
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
            userNameTextBox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Click on the log in button
            IWebElement logInButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            logInButton.Click();
        }
    }
}
