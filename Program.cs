using System;

namespace CrossPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it in Turkey?");

            // Get time in local time zone 
            Console.WriteLine("Getting LOCAL time");
            DateTime thisTime = DateTime.Now;
            Console.WriteLine("Time in {0} zone: {1}", TimeZoneInfo.Local.IsDaylightSavingTime(thisTime) ?
                              TimeZoneInfo.Local.DaylightName : TimeZoneInfo.Local.StandardName, thisTime);
            Console.WriteLine("   UTC Time: {0}", TimeZoneInfo.ConvertTimeToUtc(thisTime, TimeZoneInfo.Local));

            // Get Turkey Standard Time zone

            Console.WriteLine("Getting Turkey Standard Time");
            TimeZoneInfo ttst = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
            DateTime ttstTime = TimeZoneInfo.ConvertTime(thisTime, TimeZoneInfo.Local, ttst);
            Console.WriteLine("Time in {0} zone: {1}", ttst.IsDaylightSavingTime(ttstTime) ?
                              ttst.DaylightName : ttst.StandardName, ttstTime);
            Console.WriteLine("   UTC Time: {0}", TimeZoneInfo.ConvertTimeToUtc(ttstTime, ttst));
        }

    }
}
