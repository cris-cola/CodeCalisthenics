using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class CodeChallenges
{
    public class Solution {
        public void Execute() {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int intInput;
            double doubleInput;
            string stringInput;

            // Read and save an integer, double, and String to your variables.
            intInput = int.Parse(Console.ReadLine());
            doubleInput = double.Parse(Console.ReadLine());
            stringInput = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(intInput + i);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(doubleInput + d);
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + stringInput);
            // The 's' variable above should be printed first.
        }
    }
}