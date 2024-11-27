using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Inventory
    {
        public Inventory() { }

        public int findLargestPriceItems(int[] arr)
        {
            int max = int.MinValue;
            for(int i = 0; i < arr.Length; i++)
            {
                max = (max < arr[i] ? arr[i]:max);
            }

            return max;
        }
    }
}
