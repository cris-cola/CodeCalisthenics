    using System;
using System.Collections.Generic;

namespace CodeCalisthenics.Operations
{
    class Palindromes
    {
        LinkedList<char> Stack{ get; set; }
        LinkedList<char> Queue{ get; set; }

        public Palindromes()
        {
            Stack = new LinkedList<char>();
            Queue  = new LinkedList<char>();
        }

        public void pushCharacter(char c)
        {
            Stack.AddFirst(c);
        }

        public void enqueueCharacter(char c)
        {
            Queue.AddFirst(c);
        }

        public char popCharacter()
        {
            var res = Stack.First.Value;
            Stack.RemoveFirst();
            return res;
        }

        public char dequeueCharacter()
        {
            var res = Queue.Last.Value;
            Queue.RemoveLast();
            return res;
        }
    }

    public class PalindromeSolution
    {
        public void Execute()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Palindromes obj = new Palindromes();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
