using AssignmentDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    class Person
    {
        private string first_name="";
        private string last_name="";

        public void Display_Fullname(string fname, string lname)
        {
            first_name = fname;
            last_name = lname;
            Console.WriteLine("Full Name is:" + first_name + last_name);

        }
    }
    class Access
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Display_Fullname("Datta","Sonalkar");

        }
    }
} 
