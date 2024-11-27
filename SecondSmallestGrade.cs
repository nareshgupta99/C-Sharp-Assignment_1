using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SecondSmallestGrade
    {
        public int SecondSmallest(int[] arr)
        {
            if(arr.Length == 0) return 0;
            if(arr.Length == 1) return arr[0];

            int Min = Int32.MaxValue,SecondMin=Int32.MaxValue;

            for (int i=0; i < arr.Length; i++){
                if (arr[i] < Min)
                {
                    SecondMin = Min;
                    Min = arr[i];
                }
                else if (arr[i] > Min && arr[i] < SecondMin)
                {
                    SecondMin = arr[i];
                }
            }
            return SecondMin;
        }
    }
}
