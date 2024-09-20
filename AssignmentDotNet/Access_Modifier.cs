using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    class Person1
    {
        protected int Emp_Id=10;
        protected string Emp_Name = "Datta";
        protected string Emp_Address = "Pune";

    }
    class Employee : Person1
    {
        public void Access_Member()
        {
            Console.WriteLine("Employee Details are");
            Console.WriteLine($"Employee ID: {Emp_Id}");
            Console.WriteLine($"Employee Name: {Emp_Name}");
            Console.WriteLine($"Employee Address: {Emp_Address}");
        }


    }

    class Access_Modifier
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Access_Member();

        }
    }
}
