using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    internal class Switch_Case
    {
        public static void Main()
        {
            Console.WriteLine("Items in the Menu\n\n1:Burger\n2:Pizza\n3:Salad\n4:Chicken 65\n5:Omlet\n6:Pasta");
            Console.WriteLine("\nEnter Your Choice Number in the Menu Items");
            int ch=Convert.ToInt32( Console.ReadLine());
            switch(ch)
            {

                case 1:
                    Console.WriteLine("You have chosen Burger...\n Price is:100 rs");
                    break;
                case 2:
                    Console.WriteLine("You have chosen Pizza...\n Price is:300 rs");
                    break;
                case 3:
                    Console.WriteLine("You have chosen Salad...\n Price is:50 rs");
                    break;
                case 4:
                    Console.WriteLine("You have chosen Chicken 65...\n Price is:80 rs");
                    break;
                case 5:
                    Console.WriteLine("You have chosen Omlet...\n Price is:40 rs");
                    break;
                case 6:
                    Console.WriteLine("You have choosen Pasta...\n Pricee is:70 rs");
                    break;
                default:
                    Console.WriteLine("See The Menu and Enter Correct Choice");
                    break;
            }
        }
    }
}