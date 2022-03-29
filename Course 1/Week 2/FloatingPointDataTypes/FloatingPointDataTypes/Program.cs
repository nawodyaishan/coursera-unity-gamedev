using System;

namespace FloatingPointDataTypes
{
    class Program
    {
        /// <summary>
        /// Demonstarting Floating Point Data Types
        /// </summary>
        /// <param name="args">command-line arg</param>
        static void Main(string[] args)
        {

            int score = 100;
            int totalSecondsPlayed = 1000;

            float pointsPerSecond = (float) score / (float) totalSecondsPlayed;
            Console.WriteLine("Points per second: {0}", pointsPerSecond);

            double firstNumber = 34.567839023;
            double secondNumber = 8923.1234857;
            double thirdNumber = 3456.09182371;
            double fourthNumber = 3456.09182371;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
        }
    }
}
