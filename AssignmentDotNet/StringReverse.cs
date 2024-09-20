using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AssignmentDotNet
{
    class StringReverse
    {
        static void Main()
        {
            string s = "CODEMIND TECHNOLOGY";
            int i = s.Length - 1;
            string sr = string.Empty;
            while (i >= 0)
            {
                sr = sr + s[i];
                i--;
            }
            Console.WriteLine("Reverse String Is:" +sr);

            //Even odd Number

            int[]num = {1,2,3,4,5,6,7,8,9,10};
            int j = 0;
            Console.WriteLine("Even No:");
            while (j < num.Length)
            {
                if (num[j] % 2 == 0)
                {
                    Console.WriteLine(num[j]);
                    
                }
                j++;
            }


            j = 0;
            Console.WriteLine("Odd No:");
            while (j < num.Length)
            {
                if(num[j] % 2 != 0)
                {
                    Console.WriteLine(num[j]);
                    
                }
                j++;
            }
        }



    }
}
