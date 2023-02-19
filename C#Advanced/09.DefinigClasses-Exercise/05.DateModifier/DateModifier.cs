using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static int GetDifBtwDatesInDays (string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            TimeSpan difference = dateTwo - dateOne;

            return Math.Abs(difference.Days);
        }
    }
}
