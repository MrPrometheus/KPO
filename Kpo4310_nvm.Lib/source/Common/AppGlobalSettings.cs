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
        private static IFootballPlayerFactory _detailsFactory;

        public static string LogPath { get { return _logPath; } }
        public static string DataFileName { get { return _dataFileName; } }
        public static string DataFileNameSave { get => _dataFileNameSave; }
        public static IFootballPlayerFactory DetailsFactory { get => _detailsFactory; }
        public static void Initialize()
        {
            _logPath = AppConfigUtility.AppSettings("logPath");
            _dataFileName = AppConfigUtility.AppSettings("dataFileName");
            _dataFileNameSave = AppConfigUtility.AppSettings("dataFileNameSave");
            if(AppConfigUtility.AppSettings("detailsFactory") == "SplitFile")
            {
                _detailsFactory = new FootballPlayerFactory();
            } else
            {
                _detailsFactory = new FootballPlayerFactoryTest();
            }
        }
    }
}
