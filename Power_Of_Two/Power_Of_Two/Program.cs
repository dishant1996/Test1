using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Of_Two
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the N:");
            int powerOfTwo = Convert.ToInt32(Console.ReadLine());

            if (powerOfTwo <= 0 || powerOfTwo < 31)
            {
                Console.WriteLine("Power of 2's: ");

                for (int i = 0; i <= powerOfTwo; i++)
                {
                    int powerOfValue = ((int)Math.Pow(2, i));      //2^i
                    Console.WriteLine($"The value of 2^{i}is: { powerOfValue}");
                }
            }
            else
                Console.WriteLine("Value overflows int value");
                Console.ReadLine();
        }
    }
}
