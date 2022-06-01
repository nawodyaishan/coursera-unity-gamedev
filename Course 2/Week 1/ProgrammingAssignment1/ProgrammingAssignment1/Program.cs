﻿using System;

namespace ProgrammingAssignment1
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        // number to classify
        static int number;

        /// <summary>
        /// Programming Assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract number from string
                GetInputValueFromString(input);

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed


                
                if (number % 2 == 0)
                {
                    Console.Write("e");
                    Console.Write(" ");
                
                    if (number > 0)
                    {
                        Console.Write("1");
                    }
                    else if (number < 0)
                    {
                        Console.Write("-1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    Console.Write("\n");

                }
                else if (number % 2 == 1)
                {
                    Console.Write("o");
                    Console.Write(" ");
                
                    if (number > 0)
                    {
                        Console.Write("1");
                    }
                    else if (number < 0)
                    {
                        Console.Write("-1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    Console.Write("\n");
                }
                else if (number == -1)
                {
                    Console.Write("o");
                    Console.Write(" ");
                    Console.Write("-1");
                    Console.Write("\n");
                }



                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
        
        /// <summary>
        /// Extracts the number from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValueFromString(string input)
        {
            number = int.Parse(input);
        }
    }
}
