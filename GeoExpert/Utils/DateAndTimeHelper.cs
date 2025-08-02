using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.Utils
{
    static class DateAndTimeHelper
    {
        public static string TimeSpanToString(TimeSpan time)
        { // hh:mm:ss to hh hours, mm minutes and ss seconds

            int minutes = time.Minutes;
            int seconds = time.Seconds;

            // Proper singular/plural handling
            string minText = (minutes == 1) ? "minute" : "minutes";
            string secText = (seconds == 1) ? "second" : "seconds";

            return $"{minutes} {minText} and {seconds} {secText}";
        }
    }
}
