using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            string tempNum = Console.ReadLine();
            Console.Write("Unit(C/F): ");
            string tempUnit = Console.ReadLine();
            float temp = Convert.ToSingle(tempNum);

            switch (tempUnit)
            {
                case "C":
                Console.WriteLine($"{temp:f2} C = {temp*1.8+32:f2} F");
                Console.WriteLine($"Absolute value: {Math.Abs(temp*1.8+32):f2}");
                break;

                case "F":
                Console.WriteLine($"{temp:f2} F = {(temp-32)/1.8:f2} C");
                Console.WriteLine($"Absolute value: {Math.Abs((temp-32)/1.8):f2}");
                break;

                default:
                Console.WriteLine("Invalid unit.");
                break;

            }

        }
    }
}
