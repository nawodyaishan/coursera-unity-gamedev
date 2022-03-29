using System;
using ConsoleCards;

// IMPORTANT: Only add code in the section
// indicated below. The code I've provided
// makes your solution work with the 
// automated grader on Coursera

/// <summary>
/// Programming Assignment 3
/// </summary>
class Program
{
    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    /// <param name="args">command-line args</param>
    static void Main(string[] args)
    {
        // loop while there's more input
        string input = Console.ReadLine();
        while (input[0] != 'q')
        {

            // Add your code between this comment
            // and the comment below. You can of
            // course add more space between the
            // comments as needed

            // declare a deck variables and create a deck object
            // DON'T SHUFFLE THE DECK
            Deck deck = new Deck();

            // deal 2 cards each to 4 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card player1Card1 = deck.TakeTopCard();
            Card player2Card1 = deck.TakeTopCard();
            Card player3Card1 = deck.TakeTopCard();
            Card player4Card1 = deck.TakeTopCard();
            Card player1Card2 = deck.TakeTopCard();
            Card player2Card2 = deck.TakeTopCard();
            Card player3Card2 = deck.TakeTopCard();
            Card player4Card2 = deck.TakeTopCard();

            // deal 1 more card to players 2 and 3
            Card player2Card3 = deck.TakeTopCard();
            Card player3Card3 = deck.TakeTopCard();

            // flip all the cards over
            player1Card1.FlipOver();
            player1Card2.FlipOver();
            player2Card1.FlipOver();
            player2Card2.FlipOver();
            player2Card3.FlipOver();
            player3Card1.FlipOver();
            player3Card2.FlipOver();
            player3Card3.FlipOver();
            player4Card1.FlipOver();
            player4Card2.FlipOver();

            // print the cards for player 1
            Console.WriteLine(player1Card1.Rank + "," + player1Card1.Suit);
            Console.WriteLine(player1Card2.Rank + "," + player1Card2.Suit);

            // print the cards for player 2
            Console.WriteLine(player2Card1.Rank + "," + player2Card1.Suit);
            Console.WriteLine(player2Card2.Rank + "," + player2Card2.Suit);
            Console.WriteLine(player2Card3.Rank + "," + player2Card3.Suit);

            // print the cards for player 3
            Console.WriteLine(player3Card1.Rank + "," + player3Card1.Suit);
            Console.WriteLine(player3Card2.Rank + "," + player3Card2.Suit);
            Console.WriteLine(player3Card3.Rank + "," + player3Card3.Suit);

            // print the cards for player 4
            Console.WriteLine(player4Card1.Rank + "," + player4Card1.Suit);
            Console.WriteLine(player4Card2.Rank + "," + player4Card2.Suit);

            // Don't add or modify any code below
            // this comment
            input = Console.ReadLine();
        }
    }
}