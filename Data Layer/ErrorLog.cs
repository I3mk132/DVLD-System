using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsErrorLog
    {
        public static string file { get; }

        static clsErrorLog()
        {
            file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");
            
        }

        public static void AddErrorLog(Exception ex, [CallerFilePath] string filepath = "", [CallerLineNumber] int linenumber = 0)
        {
            DateTime date = DateTime.Now;
            string FilePath = filepath;
            int LineNumber = linenumber;

            string ErrorString = $"[{date.ToString("g")}] ERROR in {filepath}:{LineNumber} - Exception: {ex.Message}\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n";

            File.AppendAllText(file, ErrorString);
        }
        
    }
}
