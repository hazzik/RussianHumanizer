using System;
using System.Collections.Generic;

namespace RussianHumanizer
{
    internal class DateInWords
    {
        private static readonly IList<string> days = new[]
        {
            "нулев",
            "перв",
            "втор",
            "треть",
            "четверт",
            "пят",
            "шест",
            "седьм",
            "восьм",
            "девят",
            "десят",
            "одиннадцат",
            "двенадцат",
            "тринадцат",
            "четырнадцат",
            "пятнадцат",
            "шестнадцат",
            "семнадцат",
            "восемнадцат",
            "девятнадцат"
        };

        private static readonly IList<string> decadeWithZero = new[]
        {
            String.Empty,
            "десят",
            "двадцат",
            "тридцат",
            "сороков",
            "пятидесят",
            "шестидесят",
            "семидесят",
            "восьмидесят",
            "девяност"
        };

        private static readonly IList<string> decades = new[]
        {
            String.Empty,
            "десять",
            "двадцать",
            "тридцать",
            "сорок",
            "пятьдесят",
            "шестьдесят",
            "семьдесят",
            "восемьдесят",
            "девяносто"
        };

        private static readonly IList<string> months = new[]
        {
            "января",
            "февраля",
            "марта",
            "апреля",
            "мая",
            "июня",
            "июля",
            "августа",
            "сентября",
            "октября",
            "ноября",
            "декабря"
        };

        private readonly DateTime date;

        public DateInWords(DateTime date)
        {
            this.date = date;
        }

        public override string ToString()
        {
            string year = GetNumberInGenitive(date.Year);

            string day = GetNumberInNominative(date.Day);

            return string.Format("{0} {1} две тысячи {2} года", day, GetMonthInGenitive(date.Month), year);
        }

        private static string GetMonthInGenitive(int month)
        {
            return months[month - 1];
        }

        private static string GetNumberInNominative(int number)
        {
            return GetNumberAsString(number) + GetNominativeEnding(number);
        }

        private static string GetNumberInGenitive(int number)
        {
            return GetNumberAsString(number) + GetGenitiveEnding(number);
        }

        private static string GetNumberAsString(int number)
        {
            int decade = (number/10)%10;
            int units = number%10;
            if (units == 0)
                return decadeWithZero[decade];

            int index = number%100;
            if (index < 20)
                return days[index];

            return decades[decade] + " " + days[units];
        }

        private static string GetNominativeEnding(int index)
        {
            return index == 13 || index%10 != 3 ? "ое" : "е";
        }

        private static int GetIndex(int number)
        {
            int index = number%100;
            if (index < 20)
                return index;
            return index%10;
        }

        private static string GetGenitiveEnding(int number)
        {
            return GetIndex(number) == 3 ? "его" : "ого";
        }

        public static implicit operator DateInWords(DateTime date)
        {
            return new DateInWords(date);
        }

        public static explicit operator DateTime(DateInWords date)
        {
            return date.date;
        }
    }
}