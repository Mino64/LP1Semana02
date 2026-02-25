using System;
using System.Diagnostics.Contracts;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("give cylinder height");
            string str = Console.ReadLine();
            double a = Convert.ToDouble(str);

            Console.WriteLine("give cylinder radius");
            string strRad = Console.ReadLine();
            double r = Convert.ToDouble(strRad);
            
            Console.WriteLine($"V= {MathF.PI*MathF.Pow((float)r,2)*a}");
            Console.WriteLine($"S= {2*MathF.PI*r*(r+a)}");
        }
    }
}
