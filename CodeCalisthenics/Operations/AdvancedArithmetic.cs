using System;

namespace CodeCalisthenics.Operations
{
    class SumDivisorsCalculator : AdvancedArithmetic
    {
        
        public int divisorSum(int n)
        {
            int divisorsSum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    divisorsSum += i;
            }

            return divisorsSum;
        }
    }

    interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class SumDivisorsSolution
    {
        public void Execute()
        {

            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new SumDivisorsCalculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
