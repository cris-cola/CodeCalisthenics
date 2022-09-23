using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCalisthenics.Operations
{
    class BubbleSort
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ')
                .ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Write your code here
            var totalNumber = 0;
            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        var swapped = swap(a[j], a[j + 1]);
                        a[j] = swapped.Item1;
                        a[j + 1] = swapped.Item2;
                        numberOfSwaps++;
                    }
                }

                totalNumber = totalNumber + numberOfSwaps;
                //Console.WriteLine("swaps this round: " + numberOfSwaps);
                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    Console.WriteLine("Array is sorted in {0} swaps.", totalNumber);
                    Console.WriteLine("First Element: " + a.First());
                    Console.WriteLine("Last Element: " + a.Last());
                    break;
                }
            }
        }
        
        private static (int,int) swap(int a, int b)
        {
            return (b, a);
        }
    }
}
