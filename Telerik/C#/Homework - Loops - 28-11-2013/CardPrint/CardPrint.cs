using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPrint
{
    class CardPrint
    {
        // Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. 
        // Use nested for loops and switch-case.
        static void Main(string[] args)
        {
            string card = "";
            string cardPaint = "";
            for (int value = 1; value <= 13; value++)
            {
                if (value > 1 && value <= 10) 
                    card = value+""; 

                else 
                    switch(value)
                    {
                        case 11:
                            card = "Jack";
                            break;
                        case 12:
                            card = "Queen";
                            break;
                        case 13:
                            card = "King";
                            break;
                        default: // Only happens when the card's value is equal to 1
                            card = "Ace";
                            break;
                    }

                for (int paint = 0; paint < 4; paint++)
                {
                    switch (paint)
                    {
                        
                        case 1:
                            cardPaint = "Diamonds";
                            break;
                        case 2:
                            cardPaint = "Hearts";
                            break;
                        case 3:
                            cardPaint = "Spades";
                            break;
                        default: // Only happens when the card's paint is equal to 0
                            cardPaint = "Clubs";
                            break;
                    }
                    Console.WriteLine(card+" of "+cardPaint);
                }
            }
        }
    }
}
