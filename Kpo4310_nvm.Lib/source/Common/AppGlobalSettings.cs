using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4310_nvm.Utility;

namespace Kpo4310_nvm.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath = "";
        private static string _dataFileName = "";
        private static string _dataFileNameSave = "";

        public static string LogPath { get => _logPath; }
        public static string DataFileName { get => _dataFileName; }
        public static string DataFileNameSave { get => _dataFileNameSave; }
        public static void Initialize()
        {
            _logPath = AppConfigUtility.AppSettings("logPath");
            _dataFileName = AppConfigUtility.AppSettings("dataFileName");
            _dataFileNameSave = AppConfigUtility.AppSettings("dataFileNameSave");
        }
    }
}
