using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Calculator
    {
        
        public Calculator() { 
        }
        public long TotalTransection(int[] transections)
        {
            long sum = 0;
            for(int i = 0; i < transections.Length; i++)
            {
                sum=sum+transections[i];
            }
            return sum;

        }
    }
}
