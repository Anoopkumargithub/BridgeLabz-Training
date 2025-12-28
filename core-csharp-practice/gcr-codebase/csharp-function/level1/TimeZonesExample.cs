using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharpbuiltinfunction
{
    internal class TimeZonesExample
    {
        static void ShowTime(string zoneId, string zoneName)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            DateTimeOffset zoneTime = TimeZoneInfo.ConvertTime(utcNow, timeZone);

            Console.WriteLine($"{zoneName}: {zoneTime}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Current Time in Different Time Zones:\n");

            ShowTime("GMT Standard Time", "GMT");
            ShowTime("India Standard Time", "IST");
            ShowTime("Pacific Standard Time", "PST");
        }
    }
}
