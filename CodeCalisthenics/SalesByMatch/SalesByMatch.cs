using System.Linq;
using System.Runtime.InteropServices;

namespace CodeCalisthenics.SalesByMatch
{
    class SalesByMatch
    {
        public int n { get; set; }

        public int[] ar { get; set; }

        public SalesByMatch()
        {
            n = 9;
            ar = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        }

        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public int sockMerchant(int n, int[] ar)
        {
            var pairsCount = 0;

            var array = ar.ToList();
            var arCopy = ar.ToList();
            
            for (int sockColor = 0; sockColor < array.Count; sockColor++)
            {
                var sock = array[sockColor];

                for (int index = 1; index < arCopy.Count; index++)
                {
                    if (sock == arCopy[index])
                    {
                        pairsCount += 1;
                        array.Remove(sock);
                        array.Remove(arCopy[index]);

                        arCopy.Remove(sock);
                        arCopy.Remove(arCopy[index]);
                    }
                }
            }
        }

    }
}
