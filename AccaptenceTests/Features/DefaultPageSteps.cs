using Bogus;
using NUnit.Framework;
using SpecResults;
using Spp.Bdd.AccaptenceTests.Common;
using Spp.Bdd.AccaptenceTests.PageModels;
using TechTalk.SpecFlow;

namespace AccaptenceTests.Features
{
    [Binding]
    public class DefaultPageSteps : ReportingStepDefinitions
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

            //Using Bogus to create realistic fake data
            //https://github.com/bchavez/Bogus
            var fakeUser = new Faker<TestUser>("sv")
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Company, f => f.Company.CompanyName());

            var user = fakeUser.Generate();

            var lorem = new Bogus.DataSets.Lorem(locale: "sv");
            var sentences = lorem.Sentences(5);
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

    public class TestUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
    }
}
