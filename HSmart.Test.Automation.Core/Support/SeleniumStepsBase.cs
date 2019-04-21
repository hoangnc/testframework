using System;
using System.Collections.Generic;
using System.Text;

namespace HSmart.Test.Automation.Core.Support
{
    public abstract class SeleniumStepsBase
    {
        protected BasePage Page
        {
            get
            {
                return Selenium.Page;
            }
        }

        protected BaseSeleniumTest Selenium
        {
            get
            {
                return BaseSeleniumTest.Instance;
            }
        }
    }
}
