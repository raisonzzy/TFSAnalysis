using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFSAnalysis
{
    public class ConfigurationHelper
    {
        private static IConfigurationRoot _configuration;

        public static IConfigurationRoot ApplicationConfiguration
        {
            set { _configuration = value; }
            get { return _configuration; }
        }
    }
}
