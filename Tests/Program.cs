using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.ComponentModel;
using System.Threading;
using TurnUp_Nunit.Helper;
using TurnUp_POM.Pages;


namespace TurnUp_POM
{
    [TestFixture]
    [Parallelizable]

    class Program : CommonDriver
    {

        [Test, Order(1), NUnit.Framework.Description("Check if user is able to Login with valid credentials")]
        public void CreateTM_Test()
        {
            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            //TM page object init and defination
            TMPage tmobj = new TMPage();
            tmobj.CreateTM(driver);
        }

        [Test, Order(2), NUnit.Framework.Description("cheak if the user is able to Edit TM with valid data ")]
        public void EditTM_Test()
        {
            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            //Edit existing TM test
            TMPage tmobj = new TMPage();
            tmobj.EditTM(driver);
        }

        [Test, Order(3), NUnit.Framework.Description("cheak if the user is able to Delete TM ")]
        public void DeleteTM_Test()
        {

            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToEmployee(driver);

            //Delete exsiting TM test
            TMPage tmobj = new TMPage();
            tmobj.DeleteTM(driver);
            
        }

        



        }
    }

