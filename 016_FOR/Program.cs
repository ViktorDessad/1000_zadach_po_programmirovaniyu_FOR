using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of loops: ");
            int length = Convert.ToInt32(Console.ReadLine());
            double result = 1;

            for (int i = 0; i < length; i++)
            {
                result = result * number;
                Console.WriteLine(result);
            }
        }
    }
}
