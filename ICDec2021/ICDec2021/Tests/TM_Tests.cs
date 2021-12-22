// See https://aka.ms/new-console-template for more information
using ICDec2021.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


IWebDriver driver = new ChromeDriver();

//LoginPage object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.loginSteps(driver);

//HomePage object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GotoTMPage(driver);

//TMPage object initialization and definition
TMpage tmPageObj = new TMpage();
tmPageObj.CreateTM(driver);

//Edit TM
tmPageObj.EditTM(driver);

//Delete TM
tmPageObj.DeleteTM(driver);
