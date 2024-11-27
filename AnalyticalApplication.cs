using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class AnalyticalApplication
    {

        public AnalyticalApplication() { }


        public List<Int32> CommonElements(Int32[] arr1, Int32[] arr2)
        {
            List<Int32> list = new List<Int32>();
            Dictionary<Int32, Int32> dic = new Dictionary<Int32, Int32>();

            foreach (Int32 i in arr1)
            {
                if (dic.ContainsKey(i))
                {
                    
                }
            }

            return list;
        }
    }
}
