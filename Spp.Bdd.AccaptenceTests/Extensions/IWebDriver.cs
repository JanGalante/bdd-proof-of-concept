using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Spp.Bdd.AccaptenceTests.Extensions
{
    public static class IWebDriverExtensions
    {
        //public static void TakeScreenshot(this IWebDriver driver, string outputFile)
        public static void TakeScreenshot(this IWebDriver driver, string outputFile)
        {
            var outputFolder = Path.GetDirectoryName(outputFile);
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            var takesScreenshot = driver as ITakesScreenshot;

            if (takesScreenshot != null)
            {
                var screenshot = takesScreenshot.GetScreenshot();

                var screenshotFilePath = Path.Combine(outputFile);

                screenshot.SaveAsFile(screenshotFilePath, ImageFormat.Png);
            }
        }
    }
}
