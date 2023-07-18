using CodeCalisthenics.Operations;
using FluentAssertions;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class ContactsSearchTest
    {
        public static ContactsSearch Sut { get; set; }

        public ContactsSearchTest()
        {
            Sut = new ContactsSearch();
        }

        [Theory]
        [InlineData(new[] { "pim", "pom" }, new[] { "999999999", "777888999" }, "88999", "pom")]
        [InlineData(new[] { "sander", "amy", "ann", "michael" }, new[] { "123456789", "234567890", "789123456", "123123123" }, "1", "ann")]
        [InlineData(new[] { "adam", "eva", "leo" }, new[] { "121212121", "111111111", "444555666" }, "112", "NO CONTACT")]
        [InlineData(new[] { "zoe", "amy", "bob", "alice" }, new[] { "111111111", "111111111", "111111111", "111111111" }, "111", "alice")]
        [InlineData(new[] { "john" }, new[] { "987654321" }, "987", "john")]
        [InlineData(new[] { "john" }, new[] { "987654321" }, "123", "NO CONTACT")]
        [InlineData(new[] { "alice", "bob" }, new[] { "123456789", "987654321" }, "789", "alice")]
        [InlineData(new string[] { }, new string[] { }, "123", "NO CONTACT")]
        public void SolutionTest(string[] names, string[] phoneNumbers, string searchNumber, string expected)
        {
            //Act
            var result = Sut.Solution(names, phoneNumbers, searchNumber);

            //Assert
            result.Should().NotBeNull();
            Assert.Equal(expected, result);
        }
    }
}
