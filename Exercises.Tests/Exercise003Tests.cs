﻿using NUnit.Framework;
using FluentAssertions;

namespace Exercises.Tests
{
    public class Exercise003Tests
    {
        private Exercise003 Exercise003;

        [SetUp]
        public void Setup()
        {
            Exercise003 = new Exercise003();
        }

        [Test]
        public void Given_An_IceCreamFlavour_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
            Exercise003.IceCreamCode("Pistachio").Should().Be(0);
            Exercise003.IceCreamCode("Vanilla").Should().Be(2);
            Exercise003.IceCreamCode("Chocolate").Should().Be(4);
        }

        [Test]
        public void IceCreamCode_Should_Handle_Unusual_Inputs()
        {
            Exercise003.IceCreamCode(null).Should().Be(-1);
            Exercise003.IceCreamCode(" ").Should().Be(-1);
            Exercise003.IceCreamCode(string.Empty).Should().Be(-1);
        }

        [Test]
        public void Given_Chocolate_Chip_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
            string iceCreamFlavour = "Mint Chocolate Chip";
            int expectedCode = 3;

            Exercise003.IceCreamCode(iceCreamFlavour).Should().Be(expectedCode);
        }

        [Test]
        public void Given_Mango_Sorbet_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
            string iceCreamFlavour = "Mango Sorbet";
            int expectedCode = 5;

            Exercise003.IceCreamCode(iceCreamFlavour).Should().Be(expectedCode);
        }

        [Test]
        public void Given_Raspberry_Ripple_GetIceCreamCode_Should_Return_Correct_Ice_Cream_Code()
        {
            string iceCreamFlavour = "Raspberry Ripple";
            int expectedCode = 1;

            Exercise003.IceCreamCode(iceCreamFlavour).Should().Be(expectedCode);
        }

        [Test]
        public void Ice_Cream_Flavours_Should_Return_All_Flavours()
        {
            string[] expected = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
            Exercise003.IceCreamFlavours.Should().Equal(expected);
        }
    }
}
