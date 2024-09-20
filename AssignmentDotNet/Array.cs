using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    class Array
    {
        public static void Main()
        {
            //sum of values in the array

            int sum = 0;
            int[] array = { 23, 12, 43, 24, 15, 46, 27, 18, 59, 13 };
            for (int i = 0; i < array.Length; i++)
            {
                 sum = sum + array[i];
            }
            Console.WriteLine("Sum is:" + sum);

            //average of array items
            int avg=0;
            avg=sum/array.Length;
            Console.WriteLine("Average is:"+avg);

        }
    }
}
