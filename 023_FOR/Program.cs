using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Factorial number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            double factorial = 1;
            double result = 0;
            
            //double sum = 0;
            Console.WriteLine("value {0}", value);

            for (double i = 1; i <= value; i++)
            {
                if (i%2 == 1)
                {
                factorial *= i;
                }
                result += Math.Pow(-1,i)*Math.Pow(value, i) / (factorial);
            }
            Console.WriteLine($"The result is {value-result}");
        }
    }
}


                
