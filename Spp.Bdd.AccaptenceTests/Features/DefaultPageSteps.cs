using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SpecResults;
using SpecResults.Json;
using SpecResults.WebApp;
using Spp.Bdd.AccaptenceTests.Common;
using Spp.Bdd.AccaptenceTests.PageModels;
using TechTalk.SpecFlow;

namespace Spp.Bdd.AccaptenceTests.Features
{
    [Binding]
    public class DefaultPageSteps
    {
        private readonly DefaultPage _defaultPage;

        
        public DefaultPageSteps()
        {
            //Code here will run before first test step
            _defaultPage = new DefaultPage(WebDriver.Instance);
        }

        [Given]
        public void Given_I_want_to_go_to_the_website()
        {
            //This step doesn't do anything, since the page url is already set
            //in the page model for Default page
        }
        
        [When]
        public void When_I_enter_the_url_of_the_website()
        {
            WebDriver.Instance.Navigate().GoToUrl(_defaultPage.Url);
        }
        
        [Then]
        public void Then_the_startpage_should_be_presented_with_the_header_HEADER(string header)
        {
            Assert.AreEqual(_defaultPage.Header, header);
        }
    }
}
