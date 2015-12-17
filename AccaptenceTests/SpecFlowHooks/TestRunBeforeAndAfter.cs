using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using SpecResults;
using SpecResults.Json;
using SpecResults.WebApp;
using Spp.Bdd.AccaptenceTests.Common;
using TechTalk.SpecFlow;
using Spp.Bdd.AccaptenceTests.Extensions;

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

            SetupWebAppReporter();
        }

        [AfterTestRun]
        public static void After()
        {
            //Stop WebDriver
            WebDriver.Instance.Close();
            WebDriver.Instance.Dispose();
        }

        private static void SetupWebAppReporter()
        {
            var webApp = new WebAppReporter();
            webApp.Settings.Title = "WebAppReporter Showcase";
            webApp.Settings.StepDetailsTemplateFile = GetAbsolutePath(@"SpecResult\templates\step-details.tpl.html");
            webApp.Settings.CssFile = GetAbsolutePath(@"SpecResult\templates\styles.css");
            webApp.Settings.DashboardTextFile = GetAbsolutePath(@"SpecResult\templates\dashboard-text.md");

            Reporters.Add(webApp);

            var screenshotFolder = GetAbsolutePath("screenshots");
            var appFolder = GetAbsolutePath("SpecResultReport");

            if (Directory.Exists(screenshotFolder))
            {
                Directory.Delete(screenshotFolder, true);
            }

            Reporters.FinishedStep += (sender, args) =>
            {
                var path = Path.Combine("screenshots", Guid.NewGuid().ToString() + ".png");
                WebDriver.Instance.TakeScreenshot(path);
                args.Step.UserData = new
                {
                    Screenshot = path
                };
            };

            Reporters.FinishedReport += (sender, args) =>
            {
                var reporter = args.Reporter as WebAppReporter;
                if (reporter != null)
                {
                    reporter.WriteToFolder(appFolder, true);

                    Directory.Move(screenshotFolder, Path.Combine(appFolder, "screenshots"));
                }
            };
        }

        private static string GetAbsolutePath(string path)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        }
    }
}
