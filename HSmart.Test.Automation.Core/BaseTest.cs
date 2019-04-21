using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HSmart.Test.Automation.Core
{
    public abstract class BaseTest
    {
        [AssemblyInitialize]
        public abstract void FixtureSetup();

        [AssemblyCleanup]
        public abstract void FixtureTeardown();
    }
}
