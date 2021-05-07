using Xunit;

namespace CodeCalisthenics.Test
{
    public class LoopsTest
    {
        public Operations.Loops sut;

        public LoopsTest()
        {
            sut = new Operations.Loops();
        }

        [Theory]
        [InlineData(5, "5 x 1 = 5\n5 x 2 = 10\n5 x 3 = 15\n5 x 4 = 20\n5 x 5 = 25\n5 x 6 = 30\n5 x 7 = 35\n5 x 8 = 40\n5 x 9 = 45\n5 x 10 = 50\n")]
        public void TestPrices(int mealCost, string expected)
        {
            string actualResult = sut.PrintMultiples(mealCost);

            Assert.Equal(expected, actualResult);
        }
    }
}
