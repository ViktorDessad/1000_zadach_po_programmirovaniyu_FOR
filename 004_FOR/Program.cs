using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter candies price");
            double candiesPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter candies weight in kg");
            uint weight = Convert.ToUInt32(Console.ReadLine());

            for (int i = 0; i < weight; i++)
            {
                Console.WriteLine($"Candies weight = {i} = price - {i * candiesPrice}$");
            }
        }
    }
}
