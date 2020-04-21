using System;
using System.Collections.Generic;

namespace Step148TwentyOneVideos
{
    class Program
    {
        static void Main()
        {
            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }
    }
}
