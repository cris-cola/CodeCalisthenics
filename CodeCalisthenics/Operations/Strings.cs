using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCalisthenics.Operations
{
    public class Strings
    {
        public void Execute()
        {
            var N = Convert.ToInt32(Console.ReadLine());

            var words = new string[N];
            for (int i = 1; i < N; i++)
                words[i] = Console.ReadLine();

            OddEvenStringGenerator(words);
        }

        public void ExecuteInConsole()
        {
            var N = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < N; j++)
            {
                var word = Console.ReadLine();
                var chars = word.ToCharArray();
                for (var i = 0; i < word.Length; i++)
                {
                    if (IsEven(i))
                        Console.Write(word.ElementAt(i));
                }
                Console.Write(" ");
                for (var i = 0; i < word.Length; i++)
                {
                    if (!IsEven(i))
                        Console.Write(chars[i]);
                }
                Console.WriteLine();
            }
        }
        
        public string OddEvenStringGenerator(params string[] words)
        {
            StringBuilder evenOddChars = new StringBuilder();
            evenOddChars.Append(GetOddAndEvenLettersFromWord(words[0]));
            for (var index = 1; index < words.Length; index++)
                evenOddChars.Append("\n"+GetOddAndEvenLettersFromWord(words[index]));

            var result = evenOddChars.ToString();
            Console.WriteLine(result);

            return result;
        }

        public string GetOddAndEvenLettersFromWord(string word)
        {
            return GetEvenAndOddLetters(word).Item1 + " " + GetEvenAndOddLetters(word).Item2;
        }

        public (string, string) GetEvenAndOddLetters(string word)
        {
            var evenLetters = new List<char>();
            var oddLetters = new List<char>();

            var chars = word.ToCharArray();
            for (var i = 0; i < word.Length; i++)
            {
                if (IsEven(i))
                    evenLetters.Add(chars[i]);
                else
                    oddLetters.Add(chars[i]);
            }
            
            return (new string(evenLetters.ToArray()), new string(oddLetters.ToArray()));
        }
        
        private bool IsEven(int n )
        {
            return n % 2 == 0;
        }
    }
}
