using Xunit;
using UnitTestSample;

namespace UnitTestSample.Test
{
    public class EvenOrOddNumberTests
    {
        [Theory]
        [InlineData(8, "Even Number")]
        [InlineData(3, "Odd Number")]
        [InlineData(0, "Even Number")]
        [InlineData(-4, "Even Number")]
        [InlineData(-3, "Odd Number")]
        public void ReturnsEvenOrOddNumber_ReturnsExpected(int input, string expected)
        {
            // Arrange
            var sut = new EvenOrOddNumber();

            // Act
            string result = sut.ReturnsEvenOrOddNumber(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}