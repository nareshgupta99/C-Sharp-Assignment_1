using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class AnalyticalTool
    {
        public AnalyticalTool() { }

        public float FindAvg(float[] arr)
        {

            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum/arr.Length;

        }
        
    }
}
