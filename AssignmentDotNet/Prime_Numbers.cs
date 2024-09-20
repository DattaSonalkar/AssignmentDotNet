using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    internal class Prime_Numbers
    {
        static void Main(string[] args)
        {
            bool isprime=true;
            int no = 21;
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Prime Number:");
            for (int i = 0; i <=a.Length; i++)
            {
                for (int j = 2; j <= a.Length; j++)
                {
                    if (i!=j&&i%j==0)
                    {
                       isprime = false;
                        break;
                    }
                }
                if(isprime)
                {
                    Console.WriteLine(i);
                }
                isprime=true;
                
            }
            Console.Read();
        }

    }
}
