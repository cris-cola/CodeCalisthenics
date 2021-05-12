using System.Collections.Generic;
using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class BinaryNumbersTest
    {
        public static BinaryNumbers Sut { get; set; }

        public BinaryNumbersTest()
        {
            Sut = new BinaryNumbers();
        }

        [Theory]
        [InlineData(1, "10001")]
        [InlineData(5, "1111101")]
        [InlineData(2, "11000110")]
        [InlineData(1, "101")]
        [InlineData(7, "1111011111110")]
        [InlineData(20, "11010111111111111111111110110")]
        [InlineData(3, "000110110111")]
        public void ShouldCountRecursively(int expectedCount, string binaryRepresentation)
        {
            var actualResult = Sut.CountConsecutiveDigitsRecursively(binaryRepresentation, new List<int>(), 0);

            Assert.Equal(expectedCount, actualResult);
        }

        [Theory]
        [InlineData(1, "10001")]
        [InlineData(5, "1111101")]
        [InlineData(2, "11000110")]
        [InlineData(1, "101")]
        [InlineData(7, "1111011111110")]
        [InlineData(20, "11010111111111111111111110110")]
        [InlineData(3, "000110110111")]
        public void ShouldCountConsecutiveDigits(int expectedCount, string binaryRepresentation)
        {
            var actualResult = Sut.CountConsecutiveDigitsWithLoop(binaryRepresentation);

            Assert.Equal(expectedCount, actualResult);
        }

        [Theory]
        [InlineData(5, "101")]
        [InlineData(17, "10001")]
        [InlineData(125, "1111101")]
        [InlineData(198, "11000110")]
        [InlineData(439, "110110111")]
        public void ShouldMakeRecursion(int integer, string binaryRepresentation)
        {
            var actualResult = Sut.ConvertToBinary(integer);

            Assert.Equal(binaryRepresentation, actualResult);
        }
    }
}
