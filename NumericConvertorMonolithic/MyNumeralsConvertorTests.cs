using System;
using NUnit.Framework;

namespace NumericConvertorMonolithic
{
    [TestFixture]
    public class MyNumeralsConvertorTests
    {

        [Test]
        public void RomanToInt_One()
        {
            var obj = (Roman: "I", Arabic: 1);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            var actual = convertor.RomanToInt(obj.Roman);

            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }

        [Test]
        public void RomanToInt_Two()
        {
            var obj = (Roman: "II", Arabic: 2);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            var actual = convertor.RomanToInt(obj.Roman);

            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }

        [Test]
        public void RomanToInt_Three()
        {
            var obj = (Roman: "III", Arabic: 3);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            var actual = convertor.RomanToInt(obj.Roman);

            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }

        [Test]
        public void RomanToInt_Four()
        {
            var obj = (Roman: "IV", Arabic: 4);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();
            var actual = convertor.RomanToInt(obj.Roman);
            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }

        [Test]
        public void RomanToInt_Valid_Subtract()
        {
            var obj = (Roman: "XLIX", Arabic: 49);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();
            var actual = convertor.RomanToInt(obj.Roman);
            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }

        [Test]
        public void RomanToInt_InValid_Subtract_With_Five_Symbols()
        {
            var obj = (Roman: "VLVX", Arabic: 49);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();
            Assert.Throws<ArgumentException>(() => convertor.RomanToInt(obj.Roman));
        }

        [Test]
        public void RomanToInt_InValid_Subtract_Two_Times()
        {
            var obj = (Roman: "XXC", Arabic: 49);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();
            Assert.Throws<ArgumentException>(() => convertor.RomanToInt(obj.Roman));
        }

        [Test]
        public void RomanToInt_300()
        {
            var obj = (Roman: "CCC", Arabic: 300);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            var actual = convertor.RomanToInt(obj.Roman);

            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }

        [Test]
        public void RomanToInt_Repeat_More_Than_Three_Times()
        {
            var obj = (Roman: "MMMM", Arabic: 300);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            Assert.Throws<ArgumentException>(() => convertor.RomanToInt(obj.Roman));
        }

        [Test]
        public void RomanToInt_Repeat_Invalid_Letters_More_Than_Three_Times()
        {
            var obj = (Roman: "VV", Arabic: 300);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            Assert.Throws<ArgumentException>(() => convertor.RomanToInt(obj.Roman));
        }

        [Test]
        public void RomanToInt_M_In_Wrong_Place()
        {
            var obj = (Roman: "XXM", Arabic: 300);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();

            Assert.Throws<ArgumentException>(() => convertor.RomanToInt(obj.Roman));
        }

        [Test]
        public void RomanToInt_99()
        {
            var obj = (Roman: "XCIX", Arabic: 99);
            MyNumeralsConvertor convertor = new MyNumeralsConvertor();
            var actual = convertor.RomanToInt(obj.Roman);
            Assert.That(actual == obj.Arabic, $"Actual : {actual}, expected : {obj.Arabic}");
        }
    }
}