using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.Utilities
{
    public static class Logger
    {
        public static void Log(String message)
        {
            DateTime now = DateTime.Now;
            string timeString = now.ToLongTimeString();
            string dateString = now.ToLongDateString();

            System.IO.File.AppendAllText("C:\\Users\\mnateghian\\Documents\\Personal\\Projects\\GamingEngine\\Logs\\logs.txt",
                String.Format("{0}\t{1}\t{2}", dateString, timeString, message)
                );
        }
    }
}
