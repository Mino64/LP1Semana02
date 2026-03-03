using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            /// ask the user for temperature number
            Console.Write("Temperature: ");
            string tempNum = Console.ReadLine();

            /// ask the user for temperature unit
            Console.Write("Unit(C/F): ");
            string tempUnit = Console.ReadLine();

            /// convert temperature number into a float
            float temp = Convert.ToSingle(tempNum);

            ///if statements to check C and F cases
            switch (tempUnit)
            {
                /// if user types C, does conversion into Fahrenheit and the abs
                case "C":
                Console.WriteLine($"{temp:f2} C = {temp*1.8+32:f2} F");
                Console.WriteLine($"Absolute value: {Math.Abs(temp*1.8+32):f2}");
                break;

                /// if user types C, does conversion into Fahrenheit and the abs
                case "F":
                Console.WriteLine($"{temp:f2} F = {(temp-32)/1.8:f2} C");
                Console.WriteLine($"Absolute value: {Math.Abs((temp-32)/1.8):f2}");
                break;

                /// otherwise it will print Invalid unit
                default:
                Console.WriteLine("Invalid unit.");
                break;

            }

        }
    }
}
