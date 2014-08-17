using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        static void Main(string[] args)
        {
            string cardValue = "";
            string cardSuit = "";
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    switch (i)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            cardValue = Convert.ToString(i);
                            break;
                        case 11:
                            cardValue = "J";
                            break;
                        case 12:
                            cardValue = "Q";
                            break;
                        case 13:
                            cardValue = "K";
                            break;
                        case 14:
                            cardValue = "A";
                            break;
                        default:
                            Console.WriteLine("Error.");
                            break;
                    }
                    switch(j)
                    {
                        case 0:
                            cardSuit = "Clubs";
                            break;
                        case 1:
                            cardSuit = "Diamonds";
                            break;
                        case 2:
                            cardSuit = "Hearts";
                            break;
                        case 3:
                            cardSuit = "Spades";
                            break;
                    }
                    Console.Write(cardValue + " of " + cardSuit + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
