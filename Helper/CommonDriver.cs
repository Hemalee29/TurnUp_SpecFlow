using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TurnUp_POM.Pages;

namespace TurnUp_Nunit.Helper
{
   public class CommonDriver
    {
        //init driver
        public IWebDriver driver;


        [OneTimeSetUp]
        public void LoginActions()
        {

            //Define Webdriver
            driver = new ChromeDriver();
            //driver = new ChromeDriver("C:\\chrome_driver\\chromedriver.exe");

            //Login page object init and defination
            LoginPage loginObj = new LoginPage(driver);
            loginObj.LoginSteps();
        }

        public void ClosingSteps()
        {

            //Closing all the opened browser instances
            driver.Quit();
        }
    }
}
