using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class FindCommonElement
    {

        public List<int> CommonElements(int[] arr1, int[] arr2)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
               set.Add(arr1[i]);
            }
            for(int i = 0;i < arr2.Length; i++)
            {
                if (set.Contains(arr2[i]))
                {
                    list.Add(i);    
                }
            }
            return list;
        }
    }
}
