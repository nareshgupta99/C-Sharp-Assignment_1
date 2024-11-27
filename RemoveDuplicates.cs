using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class RemoveDuplicates
    {
        public int[] CleanDuplicates(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }
            int[] ans = new int[set.Count];
            set.CopyTo(ans);
            return ans;
        }

    }
}
