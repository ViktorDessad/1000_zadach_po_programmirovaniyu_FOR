using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A");
            int number_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int number_B = Convert.ToInt32(Console.ReadLine());

            for (int i = number_B; i >= number_A; i--)
            {
                Console.WriteLine("Number - {0}", i);
            }
            Console.WriteLine($"Number of numbers - {Math.Abs(number_B - number_A) + 1} ");

        }
    }
}
