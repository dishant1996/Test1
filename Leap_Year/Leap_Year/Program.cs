using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Year");
            int yr = Convert.ToInt32(Console.ReadLine());
            if (yr % 400 == 0 || yr % 4 == 0 && yr % 100 != 0)
            {
                Console.WriteLine("Year is LeapYear");
            }
            else
            {
                Console.WriteLine("Year is Not LeapYear");
            }
            Console.ReadLine();
        }
    }
}
