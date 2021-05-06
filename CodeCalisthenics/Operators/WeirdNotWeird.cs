using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCalisthenics.Operators
{
    public class WeirdNotWeird
    {
        public void Execute(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            var weirdNotWeird = CheckWeirdNotWeird(n);

            Console.Write(weirdNotWeird);
        }

        public string CheckWeirdNotWeird(int n)
        {
            if (IsEven(n) && IsInCustomRange(n))
                return "Weird";
            
            return IsEven(n) ? "Not Weird" : "Weird";
        }

        private bool IsInCustomRange(int n)
        {
            return n >= 6 && n <= 20;
        }

        private bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
