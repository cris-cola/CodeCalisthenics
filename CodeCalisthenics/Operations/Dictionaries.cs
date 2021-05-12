using System;
using System.Collections.Generic;
using static System.Int32;

namespace CodeCalisthenics.Operations
{
    public class Dictionaries
    {
        public void Execute()
        {
            int entriesCount = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> phoneBookEntries = new Dictionary<string, int>();
            
            for (int i = 0; i < entriesCount; i++)
            {
                var entry = Console.ReadLine()?.Split(' ');
                phoneBookEntries.Add(entry[0], Parse(entry[1]));
            }
            string queriedName;
            while ((queriedName = Console.ReadLine()) != null)
                WriteEntries(phoneBookEntries, queriedName);
        }

        private static void WriteEntries(Dictionary<string, int> phoneBookEntries, string queriedName)
        {
            if (phoneBookEntries.ContainsKey(queriedName))
                Console.WriteLine($"{queriedName}={phoneBookEntries[queriedName]}");
            else
                Console.WriteLine("Not found");
        }
    }
}
