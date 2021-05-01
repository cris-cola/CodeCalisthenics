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
    }

    public class FizzBuzz
    {
        private int Number { get; set; }

        private bool IsFizz { get; set; }
        private bool IsBuzz { get; set; }
        private bool IsFizzBuzz => IsFizz && IsBuzz;

        private static readonly string FizzMessage = "Fizz";
        private static readonly string BuzzMessage = "Buzz";
        private static readonly string FizzBuzzMessage = FizzMessage + BuzzMessage;

        public FizzBuzz(int number)
        {
            Number = number;
            IsFizz = number % 3 == 0;
            IsBuzz = number % 5 == 0;
        }

        public void Print()
        {
            Console.WriteLine(GetFizzBuzz());
        }

        private string GetFizzBuzz()
        {
            return IsFizzBuzz 
                ? FizzBuzzMessage 
                : IsFizz ? FizzMessage : (IsBuzz ? BuzzMessage : Number.ToString());
        }
    }
}