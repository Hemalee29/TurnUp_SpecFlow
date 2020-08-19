using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TurnUp_Nunit.Helper;
using TurnUp_POM.Pages;

namespace TurnUp_Nunit_Specflow_.Step_Definations
{
    [Binding]
    public sealed class TurnUpStepDefinition : CommonDriver
    {
        //object
        private LoginPage _loginPage;

        //Construtor
        public TurnUpStepDefinition(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        

        [Given(@"I login into the Turnup portal")]
        public void GivenILoginIntoTheTurnupPortal()
        {
            _loginPage.LoginSteps();
        }
        [When(@"I  click the ""(.*)"" under Drop on the main page")]
        public void WhenIClickTheUnderDropOnTheMainPage(string adminOption)
        {
           
        }

        [Then(@"I verify that I am on the Employee Page")]
        public void ThenIVerifyThatIAmOnTheEmployeePage()
        {
            
        }

    }
}
