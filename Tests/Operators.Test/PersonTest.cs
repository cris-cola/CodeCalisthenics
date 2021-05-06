using CodeCalisthenics.Inheritance;
using Xunit;

namespace Operators.Test
{
    public class PersonTest
    {
        public Person Sut;
        
        [Theory]
        [InlineData(-1, "You are young.")]
        [InlineData(10, "You are young.")] 
        [InlineData(16, "You are a teenager.")] 
        [InlineData(18, "You are old.")] 
        [InlineData(21, "You are old.")] 
        public void ShouldPrintWeirdNotWeird(int n, string expectedMessage)
        {
            var person = new Person(n);
            
            var actualMessage = person.GetStatusMessage();
            
            Assert.Equal(actualMessage, expectedMessage);
        }
    }
     
}
