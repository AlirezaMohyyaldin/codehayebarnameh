using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x  = Convert.ToDouble(Console.ReadLine());
            calc(x);
            
            
        }
        private static void calc(double x)
        {
            double resault = Math.Pow(x, 2) + (x * 2) - 4;
            Console.WriteLine(resault);
        }
    }
}
