using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TurnUp_Nunit_Specflow_.Pages;

namespace TurnUp_POM.Pages
{
    public class LoginPage : BasePage
    {
   

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        //Steps to login to Turnup portal
        public void LoginSteps()
        {
            
            Thread.Sleep(1000);
            //open the turn up portal 
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);

            //maximize the browser
            driver.Manage().Window.Maximize();

            //find the username textbox and enter username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            //find password textbox and enter password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //find the logi  button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginbutton.Click();

            //IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            //option1 --Validate if the text on the hyperlink is Hello hari!
      

            if (hellohari.Text == "Hello hari!")
            {
                Assert.Pass("Logged In successfully, test passed");
            }
            else
            {
                Assert.Fail("Login failed, test failed");
            }

            //option2 --Validate if the text on the hyperlink is Hello hari!
            //Assert.That(hellohari.Text, Is.EqualTo("Hello hari!"));

        }

        
    }
}
