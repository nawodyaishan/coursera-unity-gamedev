using System;

namespace Exercise4
{
    /// <summary>
    /// Exercise 4 Solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Calculates altitude change between two locations
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // get locations
            Console.Write("Enter altitude at first location:  ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter altitude at second location: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            // calculate and print altitude change
            int altitudeChange = secondAltitude - firstAltitude;
            Console.WriteLine();
            Console.WriteLine("Altitude change: " + altitudeChange);
        }
    }
}
