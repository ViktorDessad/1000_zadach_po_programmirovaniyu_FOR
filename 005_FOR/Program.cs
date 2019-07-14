using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter candies price");
            double candiesPrice = Convert.ToDouble(Console.ReadLine());

            for (double i = 0.1; i <= 1.0; i += 0.1)
            {
                Console.WriteLine($"Candies weight = {i} = price - {i * candiesPrice}$");
            }
            
        }
    }
}
