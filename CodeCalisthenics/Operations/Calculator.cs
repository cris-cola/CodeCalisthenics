using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CodeCalisthenics.Operations
{
    class Calculator
    {
        public int power(int numberBase, int exponent)
        {
            if (numberBase < 0 || exponent < 0)
                throw new Exception("n and p should be non-negative");

            double value = Math.Pow(numberBase, exponent);
            return Convert.ToInt32(value);
        }
    }



    public class CalculatorSolution
    {
        public void Execute()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }

        }
    }
}
