using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public static class Log
    {
        public static void WriteLog(string logString, decimal oldBalance, decimal balance)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "Log.txt";
            string fullPath = Path.Combine(directory, "..\\..\\..\\..\\etc", filename);

            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                //Get datetime EST
                var timeUtc = DateTime.UtcNow;
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);

                string output = easternTime.ToString().PadRight(23) + logString.PadRight(23) + oldBalance.ToString("C2").PadRight(10) + balance.ToString("C2");
                
                sw.WriteLine(output);
            }

        }

        public static void WriteSalesReport(Dictionary<string, int> report, decimal total)
        {
            string directory = Environment.CurrentDirectory;
            string dateTime = GetDateTimeForFile();
            string filename = dateTime + "_Sales_Report.txt";

            string fullPath = Path.Combine(directory, "..\\..\\..\\..\\etc", filename);

            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                foreach(KeyValuePair<string, int> kvp in report)
                {
                    string line = kvp.Key + "|" + kvp.Value.ToString();
                    sw.WriteLine(line);
                }
                sw.WriteLine();
                sw.WriteLine("**Total Sales** " + total.ToString("C2"));
            }
        }
        public static string GetDateTimeForFile()
        {
            var timeUtc = DateTime.UtcNow;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);
            return easternTime.ToString("MM.dd.yyyy-HH.mm.ss");
        }
    }
}
