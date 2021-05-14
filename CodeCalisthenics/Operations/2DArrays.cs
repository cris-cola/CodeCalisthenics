using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCalisthenics.Operations
{
    public class _2DArrays
    {
        public void Execute()
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                var res = Console.ReadLine().TrimEnd()
                    .Split(' ').ToList()
                    .Select(arrTemp => Convert.ToInt32(arrTemp));
                
                List<int> _2DArrays = res.ToList();
                arr.Add(_2DArrays);
            }
        }

        public int CalculateMaxHg(List<List<int>> input)
        {
            var sums = new List<int>();
            for (var index = 1; index < input.Count-1; index++)
            {
                var row = input[index];
                for (int cols = 1; cols < row.Count-1; cols++)
                {
                    int a = input[index-1][cols-1];
                    int b = input[index-1][cols];
                    int c = input[index-1][cols+1];

                    var hgCore = row[cols];

                    int e = input[index+1][cols-1];
                    int f = input[index+1][cols];
                    int g = input[index+1][cols+1];
                    sums.Add(a + b + c + hgCore + e + f + g);
                }
            }

            return sums.Max();
        }
    }
}
