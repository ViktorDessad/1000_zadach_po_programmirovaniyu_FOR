using System;

namespace _013_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N");
            double N = Convert.ToDouble(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(-1, i + 1) * (1.0 + i / 10);
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum);
        }
    }
}
