using System;

namespace RussianHumanizer
{
    public static class DateTimeExtensions
    {
        public static string ToWords(this DateTime dateTime)
        {
            return new DateInWords(dateTime).ToString();
        }
    }
}
