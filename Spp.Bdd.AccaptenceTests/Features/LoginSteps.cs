using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using SpecResults;
using TechTalk.SpecFlow;

namespace Spp.Bdd.AccaptenceTests.Features
{
    [Binding]
    public class LoginSteps : ReportingStepDefinitions
    {
        private string _websiteUrl;
        private readonly RemoteWebDriver _webDriver;

        public LoginSteps()
        {
            _webDriver = new FirefoxDriver();
        }

        [Given(@"I have a username and password for my company")]
        public void GivenIHaveAUsernameAndPasswordForMyCompany()
        {
            //ScenarioContext.Current.Pending();
            _websiteUrl = "http://localhost:54236/";
        }
        
        [When(@"I go to the company login page")]
        public void WhenIGoToTheCompanyLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"ender my credentials")]
        public void WhenEnderMyCredentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my name should be presented")]
        public void ThenMyNameShouldBePresented()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
