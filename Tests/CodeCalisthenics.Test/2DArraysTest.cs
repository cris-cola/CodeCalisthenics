using System.Collections.Generic;
using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class _2DArraysTest
    {
        public _2DArrays Sut;
        
        [Fact]
        public void ShouldCalculateHourGlass()
        {
            List<List<int>> _2dArray = new List<List<int>>();
            _2dArray.Add(new List<int>{1,1,1,0,0,0});
            _2dArray.Add(new List<int>{0,1,0,0,0,0});
            _2dArray.Add(new List<int>{1,1,1,0,0,0});
            _2dArray.Add(new List<int>{0,0,2,4,4,0});
            _2dArray.Add(new List<int>{0,0,0,2,0,0});
            _2dArray.Add(new List<int>{0,0,1,2,4,0});

            Sut = new _2DArrays();

            var actualResult = Sut.CalculateMaxHg(_2dArray);

            Assert.Equal(19, actualResult);
        }
    }
}
