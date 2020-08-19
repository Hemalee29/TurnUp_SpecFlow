using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TurnUp_Nunit.Helper;
using TurnUp_Nunit.Pages;
using TurnUp_POM.Pages;

namespace TurnUp_Nunit.Tests
{
    [TestFixture]
    [Parallelizable]
    class EmployeeTests : CommonDriver
    {
        
        
        [Test, Description("cheak if the user is able to create employee with valid data ")]
        public void CreateEmployee_Test()
        {
            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToEmployee(driver);

            //TM page object init and defination
            EmplyeesPage employeeobj = new EmplyeesPage();
            employeeobj.CreateEmployee(driver);
        }

        [Test, Description("cheak if the user is able to Edit employee with valid data ")]
        public void EditEmployee_Test()
        {
            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToEmployee(driver);

            //Edit existing TM test
            EmplyeesPage employeeobj = new EmplyeesPage();
            employeeobj.EditEmployee(driver);
        }

        [Test, Description("cheak if the user is able to Delete employee ")]
        public void DeleteEmployee_Test()
        {
            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToEmployee(driver);

            //Delete exsiting TM test
            EmplyeesPage employeeobj = new EmplyeesPage();
            employeeobj.DeleteEmployee(driver);
        }

        

    }
}
