using ICDec2021.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICDec2021.Pages
{
    internal class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewButton.Click();

            //Identify typecode dropdown and click
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            Thread.Sleep(2000);

            //Identify Material from the typecodeDropdown and click
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();


            //Identify code input textbox and enter the valid code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("1");

            //Identify description textbox and enter the valid description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("1");

            //Identify Priceperunit textbox and enter the valid price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
            priceperunitTextbox.SendKeys("1");

            //Identify the save button and click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(10000);
            //wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 15);

            //Identify the lastpage button and click
            IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
            //wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);
            Thread.Sleep(15000);

            //Identify the entered record and check if it has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if (actualCode.Text == "1")
            {
                Console.WriteLine("Material record succesfully created.Test Passed!");
            }

            else
            {
                Console.WriteLine("Test Failed!");
            }

        }
        public void EditTM(IWebDriver driver)
        {
            //Identify edit button and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //Identify typecode dropdown and click
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            Thread.Sleep(2000);

            //Identify time from the typecodeDropdown and click
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();

            //Identify code textbox and enter the valid code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("2");

            //Identify description textbox and enter the valid description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("2");

            //Identify price textbox and enter the valid price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

            IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
            priceTag.Click();
            priceperunitTextbox.Clear();
            priceTag.Click();
            priceperunitTextbox.SendKeys("2");
            Thread.Sleep(4000);

            //Identify the save button and click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(10000);

            //Identify the lastpage button and click
            IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpageButton.Click();
            Thread.Sleep(10000);

            //Identify the edited record and check if it has expected value
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (editCode.Text == "2")
            {
                Console.WriteLine("Material record succesfully edited.Test Passed!");
            }

            else
            {
                Console.WriteLine("Test edit Failed!");
            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            /* //Identify the delete button
             IWebElement deleteButton
                 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
             Thread.Sleep(2000);

             if (deleteRecord.Text) == "2")
             {
                 IWebElement deleteMyRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                 deleteMyRecord.Click();
                 Thread.Sleep(1000);
             }

             IAlert alert = driver.SwitchTo().Alert();
             alert.Accept();
             Console.WriteLine("Record Deleted Successfully, Test passed");
            */
        }
    }
}
