using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCalisthenics.Operations
{
    
    public class Recursion
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Factorial(n);
            
            Console.WriteLine(result);
        }

        /*
        * Complete the 'factorial' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts INTEGER n as parameter.
        */
        public int Factorial(int n)
        {
            return n <= 1 ? 1 
                : n * Factorial(n - 1);
        }
    }
}
