using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class DifferenceBetweenTwoSetOfCards
    {
        public static int Solution(int[] a, int[] b, int x)
        {
            if(a.Length == 1 && b.Length == 1)
            {
                int res = a[0] - b[0];
                if (res < 0) res = res * -1;
                if (res <= x)
                    return 1;
            }

            int diff = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    int res = a[i] - b[j];
                    if (res < 0) res = res * -1;
                    if(res <= x) diff++;
                }
            }

            return diff;
        }
    }
}
