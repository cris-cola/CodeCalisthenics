using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeCalisthenics.Operations
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here

        public Difference(int[] aElements)
        {
            elements = aElements;
        }

        public void computeDifference()
        {
            maximumDifference = elements.Max() - elements.Min();
        }

        public int computeMaximumDifference()
        {
            return elements.Max() - elements.Min();
        }

        public void Execute()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ')
                .Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }

    } // End of Difference Class
}
