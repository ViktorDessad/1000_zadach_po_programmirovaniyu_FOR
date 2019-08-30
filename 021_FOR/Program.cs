using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Factorial number: ");
            double factorial = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            double sum = 0;
            for (double i = 1; i <= factorial; i++)
            {
                result *= i;
                result = 1 / result;
                sum += result;
            }
            Console.WriteLine($"The result is {sum + 1}");
        }
    }
}
