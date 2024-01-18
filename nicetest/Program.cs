using System;
using System.Collections.Generic;

namespace DiceTest
{
    internal class Program
    {
        public class Card
        {
            private int rank;
            private int suit;
            public string name;

            private Random rnd = new Random();

            public Card(int initialRank, int initialSuit)
            {
                rank = initialRank;
                suit = initialSuit;
            }

            public int GetRank()
            {
                return rank;
            }

            public int GetSuit()
            {
                return suit;
            }

            public int GetScore()
            {
                return rank * 4 + suit;
            }

            public string GetCardName()
            {
                switch (suit)
                {
                    case 1:
                        name = "diamonds";
                        break;
                    case 2:
                        name = "spades";
                        break;
                    case 3:
                        name = "hearts";
                        break;
                    case 4:
                        name = "clubs";
                        break;
                }
                return name;
            }
        }

        static void Main(string[] args)
        {
            // Call the Win method to test the Card class
            Win();
        }

        static void Win()
        {
            List<string> generatedCards = new List<string>();

            for (int i = 0; i < 52; i++)
            {
                Card myCard;
                string cardKey;

                do
                {
                    int randomRank = new Random().Next(1, 14);
                    int randomSuit = new Random().Next(1, 5);

                    myCard = new Card(randomRank, randomSuit);
                    cardKey = $"{myCard.GetRank()}_{myCard.GetSuit()}";
                } while (generatedCards.Contains(cardKey));

                generatedCards.Add(cardKey);

                string cardName = myCard.GetCardName();
                Console.WriteLine($"Card Rank: {myCard.GetRank()}");
                Console.WriteLine($"Card Suit: {myCard.GetSuit()}");
                Console.WriteLine($"Card Score: {myCard.GetScore()}");
                Console.WriteLine($"You got the {myCard.GetRank()} of {cardName}\n");
            }
        }
    }
}
