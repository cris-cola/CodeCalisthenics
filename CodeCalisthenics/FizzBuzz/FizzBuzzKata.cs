using System;
using System.Collections.Generic;

namespace CodeCalisthenics.FizzBuzz
{
    internal class FizzBuzzKata
    {
        public static void Execute(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                new FizzBuzz(i).Print();
            }
        }

        private static void WriteFizzBuzz(int n)
        {
            var result = n.ToString();
            if (n % 3 == 0 && n % 5 == 0)
            {
                result = "FizzBuzz";
                return;
            }
            if (n % 3 == 0 )
            {
                result = "Fizz";
                return;
            }
            if (n % 5 == 0)
            {
                result = "Buzz";
                return;
            }

            Console.WriteLine(result);
        }


    }
}