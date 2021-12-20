// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using System.Threading;



//Open Chrome Browser
IWebDriver driver = new ChromeDriver();

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

//Check if the user is logged in
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Loggedin succesfully, Test Passed!");
}

else
{
    Console.WriteLine("Test Failed");
}
// Create TM record

//Identify the administration and click the dropdown
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

//Identify TM option from the dropdown and click
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

//Identify create new button and click
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
codeTextbox.SendKeys("ICiiDec2021");

//Identify description textbox and enter the valid description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("ICDec2021");

//Identify Priceperunit textbox and enter the valid price
IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceTag.Click();

IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
priceperunitTextbox.SendKeys("100");

//Identify the save button and click
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);

//Identify the lastpage button and click
IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
lastpageButton.Click();
Thread.Sleep(2000);

//Identify the entered record and check if it has expected value
IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (actualCode.Text == "ICiiDec2021")
{
    Console.WriteLine("Material record succesfully created.Test Passed!");
}

else
{
    Console.WriteLine("Test Failed!");
}

