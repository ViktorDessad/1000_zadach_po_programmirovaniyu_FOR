using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N");
            double N = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= N; ++i)
            {
                sum += Math.Abs((2 * i - 1));
                Console.WriteLine($"{i} - {sum}");
                
            }
            
        }
    }
}
