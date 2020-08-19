using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TurnUp_Nunit.Helper;

namespace TurnUp_POM.Pages
{
    class HomePage
    {
        //Steps to login to Turnup portal
        public void NavigateToTM(IWebDriver driver)
        {
            //navigate time and material page

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(3000);
            // WaitHelper.WaitClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();



        }

        public void NavigateToEmployee(IWebDriver driver)
        {
            //navigate Employee page

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();



        }
    }
}
