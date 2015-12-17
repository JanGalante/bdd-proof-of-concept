using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Spp.Bdd.AccaptenceTests.Common
{
    public sealed class WebDriver
    {
        private static readonly FirefoxDriver instance = new FirefoxDriver();

        private WebDriver() { }

        public static FirefoxDriver Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
