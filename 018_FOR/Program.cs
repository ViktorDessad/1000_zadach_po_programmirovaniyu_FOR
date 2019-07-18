using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int term = 1;
            int result = 0;
            int length = Convert.ToInt32(Console.ReadLine());
            int A = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= length; i++)
            {
                result += term;
                term*=-A;
            }
        }
    }
}
                
            

