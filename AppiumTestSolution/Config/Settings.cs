using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiumTestSolution.Base;

namespace AppiumTestSolution.Config
{
    internal class Settings
    {
        public static string Name { get; set; }
        public static string AUTPath { get; set; }
        public static string ChromeDriverPath { get; set; }
        public static string PlatformName { get; set; }
        public static string DeviceName { get; set; }
        public static MobileType MobileType { get; set; }
    }
}
