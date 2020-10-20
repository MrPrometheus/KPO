using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Utility
{
    public static class AppConfigUtility
    {
        public static string AppSettings(string name)
        {
            var param = ConfigurationManager.AppSettings[name];
            return param != null ? param : ""; 
        }
    }
}
