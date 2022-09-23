using System;

namespace CodeCalisthenics.Operations
{
    public class WeirdNotWeird
    {
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
