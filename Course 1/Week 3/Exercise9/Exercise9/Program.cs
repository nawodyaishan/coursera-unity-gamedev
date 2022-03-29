using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            
            Deck deck = new Deck();
            deck.Print();
            
            Console.WriteLine("\n\n");

            // tell the deck to shuffle and print itself
            
            deck.Shuffle();
            deck.Print();
            
            Console.WriteLine("\n\n");

            // take the top card from the deck and print the card rank and suit

            Card card0 = deck.TakeTopCard();

            // take the top card from the deck and print the card rank and suit
            
            Console.WriteLine(card0.Rank +" "+ card0.Suit);
        }
    }
}
