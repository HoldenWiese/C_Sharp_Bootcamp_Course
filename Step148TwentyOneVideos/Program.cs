using System;
using System.Collections.Generic;

namespace Step148TwentyOneVideos
{
    class Program
    {
        static void Main()
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Holden";
            game += player;
            game -= player;
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
