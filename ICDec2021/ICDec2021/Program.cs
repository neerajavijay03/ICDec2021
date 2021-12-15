// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



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

    Console.WriteLine("Loggedin succesfully, Test Passed!");

else

    Console.WriteLine("Test Failed");


