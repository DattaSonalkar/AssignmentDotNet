using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    internal class Loops
    {
        static void Main()
        {
            Console.WriteLine("Enter any Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is Negetive");
            }
            else
            {
                Console.WriteLine("Number is Positive");
            }


            Console.WriteLine("Enter Numric Grade from 0 to 100");

            int Ivalue = Convert.ToInt32(Console.ReadLine());

            if (Ivalue >= 94 && Ivalue <= 100)
            {
                Console.WriteLine("Your Grade is A+");
            }
            else if (Ivalue >= 90 && Ivalue <= 93)
            {
                Console.WriteLine("Your Grade is A-");
            }
            else if (Ivalue >= 87 && Ivalue <= 89)
            {
                Console.WriteLine("Your Grade is B+");
            }
            else if (Ivalue >= 83 && Ivalue <= 86)
            {
                Console.WriteLine("Your Grade is B");

            }
            else if (Ivalue >= 80 && Ivalue <= 82)
            {
                Console.WriteLine("Your Grade is B-");
            }
            else if (Ivalue >= 77 && Ivalue <= 79)
            {
                Console.WriteLine("Your Grade is C+");
            }
            else if (Ivalue >= 73 && Ivalue <= 76)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (Ivalue >= 70 && Ivalue <= 72)
            {
                Console.WriteLine("Your Grade is C-");
            }
            else if (Ivalue >= 67 && Ivalue <= 69)
            {
                Console.WriteLine("Your Grade is D+");
            }
            else if (Ivalue >= 63 && Ivalue <= 66)
            {
                Console.WriteLine("Your Grade is D");
            }
            else if (Ivalue >= 60 && Ivalue <= 62)
            {
                Console.WriteLine("Your Grade is D-");
            }
            else if (Ivalue >= 51 && Ivalue <= 59)
            {
                Console.WriteLine("Your Grade is F");
            }
            else
            {
                Console.WriteLine("You need to Improve");
            }

            //Console.WriteLine("Convert From Int To Char");
            //Console.WriteLine("Integer Vale: " + Ivalue);
            //Console.WriteLine("Character Vale: " + Cvalue);


        }
    }
}

