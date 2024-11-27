using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class System
    {

        public System() { }

        public List<Int32> RemoveDuplicate(int[] arr)
        {
            List<Int32> list = new List<Int32>();
            HashSet<Int32> set = new HashSet<Int32>();
            foreach (Int32 i in arr)
            {
                set.Add(i);
            }
            
            foreach (Int32 i in set)
            {
                list.Add(i);
            }

            return list;
           
        }
    }
}
