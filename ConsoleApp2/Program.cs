using System;

namespace ConsoleApp2
{
    public class Program
    {

        public static long DateTimeToUnix(DateTime MyDateTime)
        {
            TimeSpan currentOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
            TimeSpan timeSpan = MyDateTime - new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            return (long)timeSpan.TotalSeconds;
        }
        public static void LocalTime()
        {
            //TimeSpan currentOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
            long timestamp = DateTimeToUnix(DateTime.Now);
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timestamp);
           // DateTime dateTime1 = dateTime.AddHours(+currentOffset.Hours);
            Console.WriteLine(dateTime);
        }
        //public static void Main(string[] args)
        //{
        //    LocalTime();
        //    Console.WriteLine(DateTimeToUnix(DateTime.Now));
        //    Console.ReadKey();
        //}
    }
}
