using System;
using System.Collections.Generic;
using System.Text;

namespace HSmart.Test.Automation.Core
{
    public class BaseSeleniumTest : BaseTest
    {

        public static BaseSeleniumTest _instance;

        public BasePage Page { get; private set; }
        public static BaseSeleniumTest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BaseSeleniumTest();
                return _instance;
            }
        }

        public override void FixtureSetup()
        {
            throw new NotImplementedException();
        }

        public override void FixtureTeardown()
        {
            throw new NotImplementedException();
        }
    }
}
