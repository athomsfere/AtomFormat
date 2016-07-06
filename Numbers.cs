using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomFormat
{
    namespace Numbers
    {        
            public static class Format
            {
                /// <summary>
                /// Easily convert int to its binary string representation
                /// </summary>
                /// <param name="StandardFormatInt"></param>
                /// <returns></returns>
                public static string ToBinary(this int StandardFormatInt)
                {
                    return Convert.ToString(StandardFormatInt, 2);
                }

                #region ToPercentage
                public static decimal ToPercentageDecimal<T>(this T Value) where T : new()
                {
                    decimal percentage = Convert.ToDecimal(Value);
                    percentage = (percentage / 100);
                    return percentage;
                }

                public static string ToPercentageDecimal(this string Value)
                {
                    decimal percentage = Convert.ToDecimal(Value);
                    return percentage.ToPercentageDecimal().ToString();
                }

                public static string ToPercentageDecimalString<T>(this T Value) where T : new()
                {                    
                    var percentage = Value.ToPercentageDecimal();

                    return percentage.ToString();
                }

                public static string ToPercentageDecimalString(this string Value)
                {
                    decimal percentage = decimal.Parse(Value);
                    percentage.ToPercentageDecimal();

                    return percentage.ToString();
                }
                #endregion

                #region PercentageString
                public static string ToPercentageString<T>(this T DecimalPercentage) where T: new()
                {
                    var percentNumber = Convert.ToDecimal(DecimalPercentage);
                    return percentNumber.ToPercentageDecimal() + "%";
                }

                public static string ToPercentageString<T>(this T DecimalPercentage, int DecimalPlaceAccuracy) where T : new()
                {
                    var percentNumber = Convert.ToDecimal(DecimalPercentage);
                    percentNumber = percentNumber.ToPercentageDecimal() / 1.000000000000000000000000000000000m;
                    string percentString = percentNumber.ToString();

                    if (!percentString.Contains(".") & DecimalPlaceAccuracy > 0)
                    {
                        percentString += ".";
                    }

                    if (DecimalPlaceAccuracy <= 0)
                    {
                        return percentString;
                    }

                    int zeroesToAdd = percentString.Split('.')[1].Length;

                    for (int i = DecimalPlaceAccuracy; i > 0; i--)
                    {
                        percentString += "0";
                    }
                    return percentString + "%";
                }

                public static decimal ToPercentageDecimal(this decimal DecimalPercentage)
                {
                    var percentageNumber = DecimalPercentage * 100;
                    return percentageNumber;
                }
                #endregion
            }
        
    }
}
