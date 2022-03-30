using System;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gets user menu choice and prints message
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // print menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 – New Game");
            Console.WriteLine("2 – Load Game");
            Console.WriteLine("3 – Options");
            Console.WriteLine("4 – Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            // prompt for and get choice
            Console.Write("Enter your choice (1, 2, 3 or 4): ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // print message using if statement
            if (choice == 1)
            {
                Console.WriteLine("Creating new game ...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Loading game ...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Setting options ...");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Quitting ...");
            }
            else
            {
                Console.WriteLine("That's not a valid menu choice!");
            }

            // print message using switch statement
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Creating new game ...");
                    break;
                case 2:
                    Console.WriteLine("Loading game ...");
                    break;
                case 3:
                    Console.WriteLine("Setting options ...");
                    break;
                case 4:
                    Console.WriteLine("Quitting ...");
                    break;
                default:
                    Console.WriteLine("That's not a valid menu choice!");
                    break;
            }

            Console.WriteLine();
        }
    }
}
