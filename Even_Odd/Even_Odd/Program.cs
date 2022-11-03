using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the Number");
            x = Convert.ToInt32(Console.ReadLine());
            if(x % 2 == 0)
            { 
                Console.WriteLine("This Is Evern Number");
            }
            else
            {
                Console.WriteLine("This Is ODD Number");
            }
            Console.ReadLine();
        }
    }
}
