using AppiumTestSolution.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppiumTestSolution.Config
{
    internal class TestSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("autPath")]
        public string AUTPath { get; set; }

        [JsonProperty("chromeDriverPath")]
        public string ChromeDriverPath { get; set; }

        [JsonProperty("platformName")]
        public string PlatformName { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("mobileType")]
        public MobileType MobileType { get; set; }
    }
}
