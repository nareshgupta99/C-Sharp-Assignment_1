using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class StudentGrade
    {

        public StudentGrade() { }

        public int SecondLargest(int[] arr)
        {
            Array.Sort(arr);
            return arr.Length-2;
        }
    }
}
