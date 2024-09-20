using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    class Person3
    {
        private string name = "";
        private string lName = "";

        internal void Display2(string n,string s)
        {
            name = n;
            lName = s;
            Console.WriteLine($"Full Name is:{name},{lName}");
        }
    }

    internal class Private_Data
    {
        static void Main(string[] args)
        {
            Person3 person = new Person3();
            person.Display2("Datta","Sonalkar");
            Console.Read();
        }

    }
}
