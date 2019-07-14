using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N");
            double N = Convert.ToUInt32(Console.ReadLine());
            double one = 0;
            double sum = 0;
            for (double i = 1; i <= N; i++)
            {
                one = i / N;
                sum = sum + one + 1;
            }
            Console.WriteLine(sum);
                
        }
    }
}
                
                

                

            
            


