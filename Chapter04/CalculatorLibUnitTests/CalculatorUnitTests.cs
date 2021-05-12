using System;
using Xunit;
using Packt;

namespace CalculatorLibUnitTests
{
    /// <summary>
    /// A well-written unit test will have three parts:
    /// Arrange:
    /// Act:
    /// Assert:
    /// </summary>
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2and2()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void TestAdding3And0()
        {
            // arrange
            double a = 3;
            double b = 0;
            double expected = 3;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
