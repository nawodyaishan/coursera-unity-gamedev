using System;

namespace Exercise6
{
    /// <summary>
    /// Exercise 6 Solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Calculates cosine and sine of an angle
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // prompt for and get angle
            Console.Write("Enter angle in degrees: ");
            float angle = float.Parse(Console.ReadLine());

            // calculate and print cosine and sine
            // the line of code below is shorthand for
            // angle = angle * Math.PI / 180;
            angle *= (float)Math.PI / 180;
            Console.WriteLine("Cosine: " + Math.Cos(angle));
            Console.WriteLine("Sine:   " + Math.Sin(angle));
        }
    }
}
