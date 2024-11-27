using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SimulationTool
    {
        public SimulationTool() { }

        public int[] CalculateMeasurement(int[]arr,int factor)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i]*factor;
            }

            return arr;
        }
    }
}
