using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            double sum = 1;


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum = sum + Math.Pow(i,2);
                
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
