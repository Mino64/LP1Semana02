using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("give a non negative int number");
            string str = Console.ReadLine();
            byte n = Convert.ToByte(str);

            Console.WriteLine($"{n / 2}");
            Console.WriteLine($"{n<<3}");
            Console.WriteLine($"{n^6}");
            Console.WriteLine($"{n>10}");
        }
    }
}
