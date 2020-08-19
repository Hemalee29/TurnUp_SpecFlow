using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurnUp_Nunit_Specflow_.Pages
{
    public abstract class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        
        {
            this.driver = driver;

        }
    }


}
