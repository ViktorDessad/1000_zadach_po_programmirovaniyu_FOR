using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter candies price");
            double candiesPrice = Convert.ToDouble(Console.ReadLine());

            for (double i = 1.0; i <= 2.0; i += 0.2)
            {
                Console.WriteLine($"Candies weight = {i} = price - {i * candiesPrice}$");
            }
        }
    }
}
