using NUnit.Framework;
using FluentAssertions;
using System;

namespace Exercises.Tests
{
    public class Exercise004Tests
    {
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Only_Date_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 7, 19));
            DateTime expectedResult = new(2053, 3, 27, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 3, 4, 23, 22, 0, 0));
            DateTime expectedResult = new(2052, 11, 11, 1, 8, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Day_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 24, 23, 59, 59, 0));
            DateTime expectedResult = new(2052, 10, 3, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        /* Add more tests - not sure if complete */
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Month_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 12, 1, 23, 59, 59, 0));
            DateTime expectedResult = new(2053, 08, 10, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Milliseconds()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 5, 3, 59, 59, 99));
            DateTime expectedResult = new(2052, 09, 13, 05, 46, 39, 99);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Throw_Exception_When_DateTime_Has_Incorrect_Range_Of_Value()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(2021, 1, 23, 24, 59, 59, 0)));
            Assert.That(ex.Message, Is.EqualTo("Hour, Minute, and Second parameters describe an un-representable DateTime."));

            ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(2021, 1, 23, 23, 60, 59, 0)));
            Assert.That(ex.Message, Is.EqualTo("Hour, Minute, and Second parameters describe an un-representable DateTime."));

            ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(2021, 1, 23, 23, 59, 60, 0)));
            Assert.That(ex.Message, Is.EqualTo("Hour, Minute, and Second parameters describe an un-representable DateTime."));

            ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(10000, 1, 23, 23, 59, 59, 0)));
            Assert.That(ex.Message, Is.EqualTo("Year, Month, and Day parameters describe an un-representable DateTime."));

            ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(2021, 13, 23, 23, 59, 59, 0)));
            Assert.That(ex.Message, Is.EqualTo("Year, Month, and Day parameters describe an un-representable DateTime."));

            ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(2021, 1, 32, 23, 59, 59, 0)));
            Assert.That(ex.Message, Is.EqualTo("Year, Month, and Day parameters describe an un-representable DateTime."));
        }
    }
}
