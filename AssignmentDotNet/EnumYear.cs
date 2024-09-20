using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDotNet
{
    public enum Year
    {
        January,
        February,
        March,
        April,
        May,
        Jun,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class EnumYear
    {
        public static void Main()
        { 
            
            Year month=Year.January;
            switch(month)
            {
                case Year.January:
                    Console.WriteLine("Month Is January");
                    break;
                case Year.February:
                    Console.WriteLine("Month Is February");
                    break;
                case Year.March:
                    Console.WriteLine("Month Is March");
                    break;
                case Year.April:
                    Console.WriteLine("Month Is April");
                    break;
                case Year.May:
                    Console.WriteLine("Month Is May");
                    break;
                case Year.Jun:
                    Console.WriteLine("Month Is Jun");
                    break;
                case Year.July:
                    Console.WriteLine("Month Is July");
                    break;
                case Year.August:
                    Console.WriteLine("Month Is August");
                    break;
                case Year.September:
                    Console.WriteLine("Month Is September");
                    break;
                case Year.October:
                    Console.WriteLine("Month Is October");
                    break;
                case Year.November:
                    Console.WriteLine("Month Is November");
                    break;
                case Year.December:
                    Console.WriteLine("Month Is December");
                    break;
            }

            if(month==Year.January)
            {
                Console.WriteLine("Starting Month Of year");
            }
            else if(month==Year.December)
            {
                Console.WriteLine("Ending Month Of The Year");
            }
            else
            {
                Console.WriteLine("Enter Correct Month");
            }
        }
    }
}
