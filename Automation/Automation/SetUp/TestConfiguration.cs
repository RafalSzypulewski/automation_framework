using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Automation.SetUp
{
    public class TestConfiguration
    {
        public static string ApplicationUrl { get; set; }
        public static string Browser { get; set; }

        static TestConfiguration()
        {
            ApplicationUrl = ConfigurationManager.AppSettings["ApplicationUrl"];
            Browser = ConfigurationManager.AppSettings["Browser"];
        }
    }
}
