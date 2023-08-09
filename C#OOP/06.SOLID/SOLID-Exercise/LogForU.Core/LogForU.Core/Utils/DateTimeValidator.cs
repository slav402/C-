using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Utils
{
    public static class DateTimeValidator   // клас статиц означава че от този клас не могат да се създават инстанции а класа се ползва директно
    {
        private static readonly ISet<string> formats = new HashSet<string> { "M/dd/yyyy h:mm:ss tt" };

        public static void AddFormat(string format)
        {
            formats.Add(format);
        }

        internal static bool ValidateDateTime(string dateString)
        {
            foreach (var format in formats)
            {
                if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                {
                    return true;
                }

            }



            return false;
        }
    }
}
