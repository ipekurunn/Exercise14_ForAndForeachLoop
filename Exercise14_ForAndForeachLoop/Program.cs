using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleCards;
namespace Exercise14_ForAndForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem1 Create objects
            Deck deck = new Deck();
            Card[] hand = new Card[5];
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                hand[i] = deck.TakeTopCard();
                hand[i].FlipOver();
                hand[i].Print();
            }

        }
    }
}
