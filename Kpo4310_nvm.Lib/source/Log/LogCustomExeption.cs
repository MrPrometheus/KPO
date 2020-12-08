using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public static class LogCustomExeption
    {
        public static string Path { get; private set; }
        public static void ErrorLog(string message)
        {
            System.Diagnostics.Debug.Assert(!String.IsNullOrEmpty(Path), "ПУть не указан");
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now.ToString("F") + ": " + message + "\n");
                fs.Write(array, 0, array.Length);
            }
        }

        public static void ErrorLog(Exception ex)
        {
            System.Diagnostics.Debug.Assert(!String.IsNullOrEmpty(Path), "ПУть не указан");
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now.ToString("F") + ": " + ex.Message + "\n");
                fs.Write(array, 0, array.Length);
            }
        }
    }
}
