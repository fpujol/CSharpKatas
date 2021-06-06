using BimApp;
using System;
using Xunit;

namespace UnitTest
{
    public class BimTest
    {
        [Theory]
        [InlineData(72, 1.72, "Normal")]
        [InlineData(50, 1.72, "Underweight")]
        [InlineData(80, 1.72, "Overweight")]
        [InlineData(100, 1.72, "Obese")]
        public void Should_calculate_right_bmi(double weight, double height, string expected)
        {
            Kata sut = new Kata();
            var result = sut.Bmi(weight, height);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(72, 1.72, "Normal")]
        [InlineData(50, 1.72, "Underweight")]
        [InlineData(80, 1.72, "Overweight")]
        [InlineData(100, 1.72, "Obese")]
        public void Should_calculate_right_bmiV2(double weight, double height, string expected)
        {
            Kata sut = new Kata();
            var result = sut.BmiV2(weight, height);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(72, 1.72, "Normal")]
        [InlineData(50, 1.72, "Underweight")]
        [InlineData(80, 1.72, "Overweight")]
        [InlineData(100, 1.72, "Obese")]
        public void Should_calculate_right_bmiV3(double weight, double height, string expected)
        {
            Kata sut = new Kata();
            var result = sut.BmiV3(weight, height);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(72, 1.72, "Normal")]
        [InlineData(50, 1.72, "Underweight")]
        [InlineData(80, 1.72, "Overweight")]
        [InlineData(100, 1.72, "Obese")]
        public void Should_calculate_right_bmiV4(double weight, double height, string expected)
        {
            Kata sut = new Kata();
            var result = sut.BmiV4(weight, height);
            Assert.Equal(expected, result);
        }
    }
}
