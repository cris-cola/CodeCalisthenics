using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCalisthenics.Operations
{
    public class BinaryNumbers
    {
        public void Execute()
        {
            int base10Integer = Convert.ToInt32(Console.ReadLine().Trim());

            string base2Number = ConvertToBinary(base10Integer);
            Console.WriteLine(CountConsecutiveDigitsWithLoop(base2Number));
            
            var count = 0;
            var totalCount = new List<int>();
            var max = CountConsecutiveDigitsRecursively(base2Number, totalCount, count);
            Console.WriteLine(CountConsecutiveDigitsWithLoop(base2Number));
        }

        public int CountConsecutiveDigitsRecursively(string base2Number, List<int> totalCount, int count)
        {
            if (base2Number.Length > 0 && base2Number[0] == '1')
            {
                count += 1;
                return CountConsecutiveDigitsRecursively(base2Number.Substring(1), totalCount, count);
            }
            
            if (base2Number.Length > 0 && base2Number[0] == '0')
            {
                if (count == 0)
                    return CountConsecutiveDigitsRecursively(base2Number.Substring(1), totalCount, count);
                
                totalCount.Add(count);
                count = 0;

                return CountConsecutiveDigitsRecursively(base2Number.Substring(1), totalCount, count);
            }

            if (count != 0) { }
                totalCount.Add(count);

            return totalCount.Max();
        }
        
        public int CountConsecutiveDigitsWithLoop(string binary)
        {
            var binaryDigits = binary.ToCharArray();

            var overall = new List<int>();
            var countOnes = 0;
            foreach (var digit in binaryDigits)
            {
                if (digit == '1')
                    countOnes += 1;
                else 
                {
                    overall.Add(countOnes);
                    countOnes = 0;
                }
            }

            if (countOnes != 0)
                overall.Add(countOnes);
            
            return overall.Max();
        }
        
        public string ConvertToBinary(int base10Integer)
        {
            return Convert.ToString(base10Integer, 2);
        }
    }
}
