using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N");
            double N = Convert.ToDouble(Console.ReadLine());
            double sum = 1;
            
            for (double i = 1.0; i <= N; i +=0.1 )
            {
                sum = sum * i;
                
            }
            Console.WriteLine(sum);
                
                
        }
    }
}
