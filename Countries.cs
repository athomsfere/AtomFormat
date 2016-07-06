using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomFormat
{
    public enum Countries
    {
        AUSTRALIA,
        BRITAIN,
        CANADA,
        CHINA,
        FRANCE,
        FRENCH_CANADIAN,
        
        JAPAN,
        RUSSIA,
        SINGAPORE,
        SINGAPORE_SIMPLIFIED,
        USA,

    }
    public static class Mapping
    {
        internal static Dictionary<Countries, string> currencyMap = new Dictionary<Countries, string>()
        {
            {Countries.AUSTRALIA, "de-AT"},
            {Countries.BRITAIN, "br, EN"},
            {Countries.CANADA, "en-CA"},
            {Countries.CHINA, "zh-CN"},
            
            {Countries.FRANCE, "fr-FR"},
            {Countries.FRENCH_CANADIAN, "fr-CA"},
            {Countries.RUSSIA, "ru-RU"},

            {Countries.SINGAPORE, "en-SG"},
            {Countries.SINGAPORE_SIMPLIFIED, "zh-SG"},

            {Countries.JAPAN, "ja-JP"},
            {Countries.USA, "us-US"}
        };
    }
}
