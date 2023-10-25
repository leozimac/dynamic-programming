using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class SmallestAmount
    {
        public static int Solution(int[] k)
        {
            if(k.Length == 0) return 0;
            if(k.Length == 1 && k[1] > k[0])
            {
                return 0;
            }
            
            int i = 1;
            int operations = 0;

            while (k[i - 1] >= k[i])
            {
                k[i] += 1;
                operations++;
                if (k[i] > k[i - 1])
                    i++;

                if (i == (k.Length))
                    break;
            }

            return operations;
        }
    }
}
