using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AtomFormat;

namespace AtomFormat
{

    
    namespace Time
    {
        public static class TimeMaps
        {

        }
        public static class Time
        {
            internal static Dictionary<TimeOfDay, string> timeMap = new Dictionary<TimeOfDay, string>()
            {
                {TimeOfDay.BeginningOf12Day, "yyyy/MM/dd 12:00:00 tt"},
                {TimeOfDay.Noon, "yyyy/MM/dd 12:00:00 PM"},
                {TimeOfDay.EndOf12Day, "yyyy/MM/dd 11:59:59 tt"},
                {TimeOfDay.EndOf24Day, "yyyy/MM/dd 23:59:59"}
            };

                public enum TimeOfDay
                {
                    BeginningOf12Day,
                    BeginningOf24Day,
                    EndOf12Day,
                    EndOf24Day,
                    Noon
                }

                public static string TimeFormat(this DateTime timeOfDay, TimeOfDay Format)
                {
                    timeOfDay.TimeManipulation(Format);
                    return timeOfDay.ToString(timeMap[Format].ToString());
                }

                private static void TimeManipulation(this DateTime TimeToCheck, TimeOfDay timeOfDay)
                {
                    switch (timeOfDay)
                    {
                        case TimeOfDay.BeginningOf12Day:
                        case TimeOfDay.BeginningOf24Day:
                            TimeToCheck.TimeOfDay.Subtract(TimeSinceMidnight(TimeToCheck));
                            break;

                    };
                }

                private static TimeSpan TimeSinceMidnight(DateTime CurrentTime)
                {
                    TimeSpan HowLongAgo = CurrentTime - CurrentTime.Subtract(CurrentTime.TimeOfDay);
                    return HowLongAgo + TimeSpan.FromMinutes(1);
                }
        }
    }    
    namespace Currency
    {
        
        public static class Formatting
        {
            

            public static string ToCurrencyOf<T>(this T CurrencyAmount, Countries Country) where T : new()
            {
                decimal currency = new decimal();
                System.Globalization.CultureInfo newCulture = new System.Globalization.CultureInfo(Mapping.currencyMap[Country]);

                var currencyString = String.Format(newCulture, "{0:C}", CurrencyAmount);
                return currencyString;         
            }
        }
    }
}
