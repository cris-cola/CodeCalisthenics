using System;

namespace CodeCalisthenics
{
    internal class FizzBuzz
    {
        /*
         * Complete the 'Execute' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void Execute(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                WriteFizzBuzz(i);
            }
        }

        private static void WriteFizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("Execute");
                return;
            }
            if (n % 3 == 0 && n % 5 != 0)
            {
                Console.WriteLine("Fizz");
                return;
            }
            if (n % 3 != 0 && n % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return;
            }
            Console.WriteLine(n);
        }
    }
}