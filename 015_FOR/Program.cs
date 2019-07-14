using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N");
            double N = Convert.ToDouble(Console.ReadLine());
            int num = 2;
            double res = 1;
            for (int i = 1; i <= N; ++i)
            {
                res = res * num;
                Console.WriteLine(res);
            }
            
        }
    }
}
