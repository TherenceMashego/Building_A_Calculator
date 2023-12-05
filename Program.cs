using System;

namespace Building_A_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: converting a string to an integer
            int num = Convert.ToInt32("45");
            Console.WriteLine("Result: " + (num + 6));

            // Taking user input for two integers
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Taking user input for two doubles
            Console.WriteLine("Enter the first double:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second double:");
            double num4 = Convert.ToDouble(Console.ReadLine());

            // Displaying the sum of two doubles
            Console.WriteLine("Sum of the doubles: " + (num3 + num4));

            Console.Read();
        }
    }
}
