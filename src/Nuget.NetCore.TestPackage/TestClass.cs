using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuget.NetCore.TestPackage
{
    public class TestClass
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public TestClass()
        {
        }

        public string TestMethod1()
        {
            return "TestMethod1";
        }
    }
}
