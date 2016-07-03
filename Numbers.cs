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
            }
        
    }
}
