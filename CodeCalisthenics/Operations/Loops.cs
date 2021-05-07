using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCalisthenics.Operations
{
    public class Loops
    {
        public Loops()
        {
            
        }

        public string PrintMultiples(int number)
        {
            var output = new StringBuilder();

            for (int i = 1; i <= 10; i++)
                output.Append(number + " x " + i + " = "+ number * i+"\n");
            
            return output.ToString();
        }
    }
}
