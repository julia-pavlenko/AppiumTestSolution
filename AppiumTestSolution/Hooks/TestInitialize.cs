using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiumTestSolution.Utilities;
using NUnit.Framework;

namespace AppiumTestSolution.Hooks
{
    [TestFixture]
    public class TestInitialize : Base 
    {
        [SetUp]
        public void Initialize()
        {
            AndroidContext = StartAppiumServerForHybrid();
        }

        [TearDown]
        public void Cleanup()
        {
            AppiumUtilities.CloseAppiumServer();
        }

    }
}
