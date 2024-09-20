using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    internal class Array_Operations
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Array Length");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array= new int[size];

            int count = 0;
            Console.WriteLine("Enter elements");
            for (int i = 0; i < size; i++)
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());
                count++;

                
            }

            int small=array[0];
            int big=array[0];
            Console.WriteLine("Alternate Elements in Array");
            for(int i = 0;i < size; i+=2)
            {
                Console.WriteLine(array[i]);
                if (array[i]< small)
                {
                    small = array[i];
                }

                if (array[i]>big)
                {
                    big= array[i];
                }
            }
            Console.WriteLine($"No Of Elements In Array is:{count}");
            Console.WriteLine($"Small Element is:{small}");
            Console.WriteLine($"Big Element is:{big}");
            Console.Read();
        }
    }
}
