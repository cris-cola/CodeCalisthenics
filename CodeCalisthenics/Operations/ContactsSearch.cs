using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeCalisthenics.Operations
{
    public class ContactsSearch
    {
        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can write to stdout for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");
        public string Solution(string[] names, string[] phoneNumbers, string numberToSearch)
        {
            var matchingIndexes = new List<int>();

            for (var i = 0; i < phoneNumbers.Length; i++)
            {
                if (Regex.Matches(phoneNumbers[i], numberToSearch).Count > 0) // phoneNumbers[i].Contains(numberToSearch))
                    matchingIndexes.Add(i);
            }

            switch (matchingIndexes.Count)
            {
                case 1:
                    return names[matchingIndexes[0]];
                case > 1:
                {
                    var matchingNames = matchingIndexes.Select(index => names[index]).ToList();

                    var orderedNames = matchingNames.OrderBy(x => x);
                    return orderedNames.FirstOrDefault() ?? string.Empty;
                }
                default:
                    return "NO CONTACT";
            }
        }

        public void Execute()
        {
        }
    }
}
