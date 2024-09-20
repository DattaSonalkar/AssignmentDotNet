using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    internal class String_StringBuilder
    {
        public static void Main()
        {
            //string s = "Datta";
            StringBuilder sb = new StringBuilder();
            sb.Append("Name:");
            sb.Append("Datta" + " ");
            sb.Append("Sonalkar");
            string result = sb.ToString();
            Console.WriteLine("Result:" + result);

            //String replace
            sb.Replace("Datta", "Anil");
            Console.WriteLine("Replaced String" + sb);

            //Remove portion
            sb.Remove(4, 5);
            Console.WriteLine("removed string" + sb);

            //Find Max Min
            int[] array = { 23, 21, 43, 65, 10 };
            int min = array.Min();
            int max = array.Max();
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Max:{max}");

            //string search from array
            Console.WriteLine("\n");
            string[] names = { "Anil", "Datta", "Alice", "Bob", "Charli", "David", "Emily" };
            foreach(string s1 in names)
            {
                Console.WriteLine(s1);
            }
            Console.WriteLine("\nEnter Name To Search");
            string name=Console.ReadLine();
            string s="";
            for(int i=0;i<array.Length;i++)
            {
                if (names[i] ==name)
                {
                    s = names[i];
                }
            }
            if(s == name)
            {
                Console.WriteLine("String is Present");
            }
            else
            {
                Console.WriteLine("String Not present");
            }

        }
    }
}
