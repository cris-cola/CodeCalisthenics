using Xunit;
using CodeCalisthenics.Inheritance2;

namespace CodeCalisthenics.Test
{
    public class PersonTest
    {
        public Person Sut;

        [Theory]
        [InlineData("Heraldo", "Memelli", 8135627, 100, 80, 90, 'O')]
        [InlineData("Heraldo", "Memelli", 8135627, 100, 70, 85, 'E')]
        [InlineData("Heraldo", "Memelli", 8135627, 100, 60, 80, 'E')]
        public void ShouldCalculateAverage(string firstName, string lastName, int idNumber, int score1, int score2, int expectedAverage, char expectedGrade)
        {
            var person = new Student(firstName, lastName, idNumber, new []{ score1, score2 });

            var average = person.CalculateAverage();
            var grade = person.Calculate();

            Assert.Equal(average, expectedAverage);
            Assert.Equal(grade, expectedGrade);
        }
    }
}
