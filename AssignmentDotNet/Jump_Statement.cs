using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    class Jump_Statement
    {
        static void Main()
        {
           //use of foreach loop
            string[] students = { "Ram", "Shyam", "Datta", "Vijay", "Ajay", "vinayak", "Akshay", "Anil", "Sachin" };
            foreach (string student in students)
            {
                Console.WriteLine("Students in Class:" + student);
            }


            //use of goto stmt
        repeat:
            Console.WriteLine("Enetr Your age Between 0 to 120");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 0 && age <= 120)
            {
                Console.WriteLine("Your Age Is:" + age);
                goto repeat;

            }
            else
            {
                Console.WriteLine("Enter Valid Age....");
            }



            //use of break
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter Numbers");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    break;
                }
                    sum = sum + number;

            }
                    Console.WriteLine($"Addition is: {sum}");


            //use of continue
            Console.WriteLine("\nNumber Which is Divisible by 3");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
            }

        }
    }
}
