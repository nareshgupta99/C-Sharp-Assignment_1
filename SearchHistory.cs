using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SearchHistory
    {

        public SearchHistory() { }

        public int[] Reverse(int[] arr)
        {
            int i = 0,j=arr.Length-1;
            while(i <= j)
            {
                int a = arr[i];
                 arr[i] = arr[j];
                arr[j] = a;
                i++;
                j--;

            }
            return arr;
        }


    }
}
