using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCalisthenics.SalesByMatch
{
    public static class SalesByMatch
    {

        /*
         * Complete the 'SockMerchant' function below.
         *
         * The function is expected to return an INTEGER representing the number of matching pairs in the input list
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY ar
         */

        public static void Execute()
        {
            var pairsCount =
                SockMerchant(new[] { 4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5 });

            Console.WriteLine("Pairs count: " + pairsCount);
        }

        public static int SockMerchant(int[] ar)
        {
            var totalPairsCount = 0;

            var sockList = ar.ToList();
            for (int sockIndex = 0; sockIndex < sockList.Count; sockIndex++)
            {
                var currentPairs = sockList.FindAll(x => x.Equals(sockList[sockIndex]));
                if (currentPairs.Count > 1)
                {
                    CountPairs(ref totalPairsCount, currentPairs, sockList);
                    SyncForLoop(ref sockIndex);
                }
            }

            return totalPairsCount;
        }
        
        private static void CountPairs(ref int pairsCount, List<int> pairs, List<int> sockList)
        {
            pairsCount += pairs.Count / 2;
            var reminder = pairs.Count % 2;
            for (var index = 0; index < pairs.Count - reminder; index++)
                sockList.Remove(pairs[index]);
        }

        private static void SyncForLoop(ref int sock)
        {
            if (sock > 0)
                sock -= 1;
        }
    }
}
