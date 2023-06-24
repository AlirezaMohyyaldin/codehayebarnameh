using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projehaybarname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double midterm = Convert.ToDouble(Console.ReadLine()); 
            double final = Convert.ToDouble(Console.ReadLine());
            double show = calc(midterm, final);
            Console.WriteLine(show);
        }
       public static double calc(double x,double y)
        {
            double resault = 0.35 * x + 0.65 * y;
            return resault;
        }
    }
}
