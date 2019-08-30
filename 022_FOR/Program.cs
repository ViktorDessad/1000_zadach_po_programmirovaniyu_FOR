using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Factorial number: ");
            double value = Convert.ToInt32(Console.ReadLine());
            double factorial = 1;
            double sum = 0;
            double result = 0;
            Console.WriteLine("value {0}", value);

            for (double i = 1; i <= value; i++)
            {
                factorial*= i;
                sum += Math.Pow(i,i);
                result += sum / factorial;
                Console.WriteLine("factorial = {0}\tsum = {1}\tresult = {2}",factorial, sum, result);
                
            }
            Console.WriteLine($"The result is {result + 1}");
        }
    }
}
