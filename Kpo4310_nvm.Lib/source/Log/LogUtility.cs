using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class LogUtility
    {
        public static void ErrorLog(string message)
        {
            File.AppendAllText("error.log", DateTime.Now.ToString("F") + " // " + message + "\n");
        }

        public static void ErrorLog(Exception ex)
        {
            File.AppendAllText("error.log", DateTime.Now.ToString("F") + " // " + ex.Message + "\n");
        }
    }
}
