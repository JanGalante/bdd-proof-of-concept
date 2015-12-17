using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using Spp.Bdd.AccaptenceTests.Common;
using TechTalk.SpecFlow;

namespace Spp.Bdd.AccaptenceTests.SpecFlowHooks
{
    [Binding]
    internal class TestRunBeforeAndAfter
    {
        //[BeforeTestRun("web")] possible to only run hook on specific SpecFlow  tags
        [BeforeTestRun]
        public static void Before()
        {
            //initialize the webdriver instance
            //not really necessary since its a singelton
            var webDriver = WebDriver.Instance;

            //Create report
            ////Reporters.Add(new JsonReporter());
            ////Reporters.Add(new XmlReporter());
            ////Reporters.Add(new PlainTextReporter());
            //Reporters.Add(new WebAppReporter());

            //Reporters.FinishedReport += (sender, args) =>
            //{
            //    Console.WriteLine(args.Reporter.WriteToString());
        }

        [AfterTestRun]
        public static void After()
        {
            //Stop WebDriver
            WebDriver.Instance.Close();
            WebDriver.Instance.Dispose();
        }
    }
}
