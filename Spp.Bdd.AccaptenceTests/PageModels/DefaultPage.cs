using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace Spp.Bdd.AccaptenceTests.PageModels
{
    internal class DefaultPage
    {
        private readonly RemoteWebDriver _webDriver;

        public DefaultPage(RemoteWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string Url
        {
            get
            {
                return "http://localhost:54236/";
            }
        }

        public string Header
        {
            get
            {
                return _webDriver.FindElementByCssSelector(".jumbotron>h1").Text;
            }
        }
    }
}
