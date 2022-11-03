using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_N
{
    public class Program
    {
        static void Main(string[] args)
        {
            double sum=0;
            Console.Write("Enter number of terms : ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Harmonic series is    ");
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"1/{i} = ");
                sum +=1 / (float)i;
                Console.WriteLine($"{sum}");
                Console.WriteLine();
            }
            Console.WriteLine($"\n\nsum of harmonic series upto {num} terms:{sum}");
            Console.ReadLine();

        }   
    }
}
