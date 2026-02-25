using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("give int number:");
            string str = Console.ReadLine();
            sbyte n = Convert.ToSByte(str);
            Console.WriteLine($"{--n}\n{++n}");

        }
    }
}
