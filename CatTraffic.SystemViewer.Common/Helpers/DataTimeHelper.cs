using System;

namespace CatTraffic.SystemViewer.Common.Helpers
{
    public class DataTimeHelper
    {
        public static DateTime CreateDateTimeFromText(string date, string time)
        {
            //2013 01 07
            var year = Convert.ToInt32(date.Substring(0, 4));
            var month = Convert.ToInt32(date.Substring(4, 2));
            var day = Convert.ToInt32(date.Substring(6, 2));

            //14 00 47 0009
            var hour = Convert.ToInt32(time.Substring(0, 2));
            var minute = Convert.ToInt32(time.Substring(2, 2));
            var second = Convert.ToInt32(time.Substring(4, 2));
            var millisecond = Convert.ToInt32(time.Substring(6, 4));

            var dateTime = new DateTime(year, month, day, hour, minute, second, millisecond);
            return dateTime;
        }
    }
}