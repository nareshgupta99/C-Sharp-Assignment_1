using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class LiabraryManagent
    {

        public LiabraryManagent() { }

        public int SearchBook(int[]arr,int searchCode)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchCode) return i;
            }

            return -1;
        }
    }
}
