using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Papercut.Core.Network;
using TechTalk.SpecFlow;

namespace AccaptenceTests.Stubs
{
    [Binding]
    public class SmtpStub
    {
        public static int EmailCount { get; private set; }

        public static dynamic LastOrderRequest { get; private set; }

        private Server _server;
    }
}