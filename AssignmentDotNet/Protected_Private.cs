using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    class Person2
    {
        protected int Emp_Id;
        protected string Emp_Name="";
        protected string Emp_Address="";

    }

    class Employee1 : Person2
    {
        internal void Display(int id,string name,string address)
        {
            Emp_Id= id;
            Emp_Name= name;
            Emp_Address= address;
        }
        internal void Show()
        {
            Console.WriteLine($"Id is:{Emp_Id}");
            Console.WriteLine($"Name is:{Emp_Name}");
            Console.WriteLine($"Address is:{Emp_Address}");
        }

    }
    internal class Protected_Private
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1();
            emp.Display(1,"Datta","Pune");
            emp.Show();
            Console.Read();
        }
    }
}
