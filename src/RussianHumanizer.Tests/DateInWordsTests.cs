using System;
using Xunit;

namespace RussianHumanizer.Tests
{
    public class DateInWordsTests
    {
        [Fact]
        public void GetNumberAsString()
        {
            var date = new DateTime(2011, 1, 1);

            Assert.Equal("первое января две тысячи одиннадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString2()
        {
            var date = new DateTime(2011, 1, 2);

            Assert.Equal("второе января две тысячи одиннадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString3()
        {
            var date = new DateTime(2011, 1, 3);
            Assert.Equal("третье января две тысячи одиннадцатого года", date.ToString());
        }

        [Fact]
        public void FactMethodName()
        {
            Console.WriteLine(DateTime.Now.ToString(@"dd MMMM HH:mm"));
        }

        [Fact]
        public void GetNumberAsString4()
        {
            var date = new DateTime(2011, 1, 4);

            Assert.Equal("четвертое января две тысячи одиннадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20120104()
        {
            var date = new DateTime(2012, 1, 4);

            Assert.Equal("четвертое января две тысячи двенадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20210104()
        {
            var date = new DateTime(2021, 1, 4);

            Assert.Equal("четвертое января две тысячи двадцать первого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20230313()
        {
            var date = new DateTime(2023, 3, 13);

            Assert.Equal("тринадцатое марта две тысячи двадцать третьего года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20030313()
        {
            var date = new DateTime(2003, 3, 13);

            Assert.Equal("тринадцатое марта две тысячи третьего года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20130313()
        {
            var date = new DateTime(2013, 3, 13);

            Assert.Equal("тринадцатое марта две тысячи тринадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20130331()
        {
            var date = new DateTime(2013, 3, 31);

            Assert.Equal("тридцать первое марта две тысячи тринадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20590228()
        {
            var date = new DateTime(2059, 2, 28);

            Assert.Equal("двадцать восьмое февраля две тысячи пятьдесят девятого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20200520()
        {
            var date = new DateTime(2020, 5, 20);

            Assert.Equal("двадцатое мая две тысячи двадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20110623()
        {
            var date = new DateTime(2011, 6, 23);

            Assert.Equal("двадцать третье июня две тысячи одиннадцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20300520()
        {
            var date = new DateTime(2030, 5, 20);

            Assert.Equal("двадцатое мая две тысячи тридцатого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20400520()
        {
            var date = new DateTime(2040, 5, 20);

            Assert.Equal("двадцатое мая две тысячи сорокового года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20500520()
        {
            var date = new DateTime(2050, 5, 20);

            Assert.Equal("двадцатое мая две тысячи пятидесятого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20600520()
        {
            var date = new DateTime(2060, 5, 20);

            Assert.Equal("двадцатое мая две тысячи шестидесятого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20700520()
        {
            var date = new DateTime(2070, 5, 20);

            Assert.Equal("двадцатое мая две тысячи семидесятого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20800520()
        {
            var date = new DateTime(2080, 5, 20);

            Assert.Equal("двадцатое мая две тысячи восьмидесятого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20900520()
        {
            var date = new DateTime(2090, 5, 20);

            Assert.Equal("двадцатое мая две тысячи девяностого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20910520()
        {
            var date = new DateTime(2091, 5, 20);

            Assert.Equal("двадцатое мая две тысячи девяносто первого года", new DateInWords(date).ToString());
        }

        [Fact]
        public void GetNumberAsString20010911()
        {
            var date = new DateTime(2001, 9, 11);

            Assert.Equal("одиннадцатое сентября две тысячи первого года", new DateInWords(date).ToString());
        }
    }
}
