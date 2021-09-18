using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class DifferenceTest
    {
        public Difference sut;
        
        [Theory]
        [InlineData(new int[3]{ 3, 1, 2 }, 2)]
        [InlineData(new int[3]{ 0, -1, 5 }, 6)]
        [InlineData(new int[3]{ 1, 10, 0 }, 10)]
        [InlineData(new int[4]{ 1, 5, 6, 100 }, 99)]
        [InlineData(new int[10]{ 1, 2, 33, 44, 55, 66, 77, 88, 99, 100 }, 99)]
        public void TestMaxdiff(int[] elements, int res)
        {
            var actualResult = new Difference(elements).computeMaximumDifference();

            Assert.Equal(res, actualResult);
        }
    }
}