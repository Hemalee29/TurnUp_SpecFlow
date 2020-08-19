using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace TurnUp_Nunit.Helper
{
    class WaitHelper
    {
        public static object SeleniumExtras { get; private set; }

        //generic function to wait for an element to be clickable

        [Obsolete]
        public static void WaitClickable(string v, IWebDriver driver, string attribute, string value)
        {
            try
            {
                if (attribute == "id")
                {

                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 4));
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("value")));

                   //ait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElemenetToBeClickable(By.Id("value")));

                }
                if (attribute == "Xpath")
                {

                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 4));
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("value")));

                }

                if (attribute == "CSSSelector")
                {

                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 4));
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("value")));

                }
            }
            catch(Exception ex)
            {
                Assert.Fail("Unable to click Web Element", ex.Message);
            }
           


        }

        //internal static void WaitClickable(IWebDriver driver, string v1, string v2, int v3)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
