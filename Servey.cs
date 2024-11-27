using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Servey
    {

        public Servey() { }

        public List<Int32> Report(int []arr)
        {
            List<Int32> list = new List<int>();
            int male = 0;
            int female = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] % 2 == 0) male += 1;
                else female += 1;
            }
            list.Add(male);
            list.Add(female);

            return list;
        }
    }
}
