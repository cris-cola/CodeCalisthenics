using System;
using System.Collections.Generic;
using System.Text;
using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class RecursionTest
    {
        public static Recursion Sut { get; set; }

        public RecursionTest()
        {
            Sut = new Recursion();
        }

        [Theory]
        [InlineData(10, 3628800)]
        [InlineData(3, 6)]
        public void ShouldMakeRecursion(int n, int expectedResult)
        {
            var actualResult = Sut.Factorial(n);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
