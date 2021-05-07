using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class WeirdNotWeirdTest
    {
        public WeirdNotWeird Sut;

        public WeirdNotWeirdTest()
        {
            Sut = new WeirdNotWeird();
        }

        [Theory]
        [InlineData(3, "Weird")]
        [InlineData(5, "Weird")]

        [InlineData(2, "Not Weird")]
        [InlineData(4, "Not Weird")]
        
        [InlineData(6, "Weird")]
        [InlineData(8, "Weird")]
        [InlineData(10, "Weird")]
        [InlineData(12, "Weird")]
        [InlineData(14, "Weird")]
        [InlineData(16, "Weird")]
        [InlineData(18, "Weird")]
        [InlineData(20, "Weird")]
        
        [InlineData(22, "Not Weird")]
        [InlineData(24, "Not Weird")]
        [InlineData(26, "Not Weird")]
        [InlineData(28, "Not Weird")]
        [InlineData(30, "Not Weird")]
        [InlineData(32, "Not Weird")]
        [InlineData(34, "Not Weird")]
        public void ShouldPrintWeirdNotWeird(int n, string expectedMessage)
        {
            var actualMessage = Sut.CheckWeirdNotWeird(n);

            Assert.Equal(actualMessage, expectedMessage);
        }
    }
}
