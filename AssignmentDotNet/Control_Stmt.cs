using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    internal class Control_Stmt
    {
        public static void Main()
        {
            //Console.WriteLine("Enter Number From 1 to 10");
            //int num=Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("For Loop");
            for (int i = 1; i <=10; i++)
            {
                
                Console.WriteLine("Student:" + i);
            }

            int num1 = 1;
            Console.WriteLine("\nWhile Loop\n");
            while (num1<=10)
            {
               
                Console.WriteLine("Student:" + num1);
                num1++;
            }

            int num2 = 1;
            Console.WriteLine("Do While Loop");
            do
            {
                Console.WriteLine("Student:" + num2);
                num2++;
            }   
                while (num2<=10);
        }
    }
}
