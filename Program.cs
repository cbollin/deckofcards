using System;
using System.Collections.Generic;
namespace ConsoleApplication4
{
public class Card
   {
       public string value;
       public string suit;
       public string num_value; 
       public Card(string val, string ste, string num)
       {
           value = val;
           suit = ste;
           num_value = num;
       }
   }
   public class Deck
   {
       string[] value = {"A", "2", "3", "4", "5","6", "7", "8", "9", "10", "J","Q", "K"};
       string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
       public Card[] cards = new Card[52];
       public Deck()
       {
           int idx = 0;
           int num = 1;
           for(int i = 0; i < 13; i++)
           {
               for(int s = 0; s < 4; s++)
               {
                   cards[idx] = new Card(value[i], suit[s], num.ToString());
                   idx++;
               }
               num++;
           }
           for(int k = 0; k < 52; k++)
           {
               Console.WriteLine(cards[k].value + " " + cards[k].suit + " " + cards[k].num_value);
           }
       }

   }
   public class Program
   {
       public static void Main(string[] args)
       {
          Deck lol = new Deck();
          Console.WriteLine("3rd card from LOL deck: " + lol.cards[3].value + " " + lol.cards[3].suit);
       }
   }
}
// To Do
// Create a class called "Card"

// Give the Card class a property "value" which will hold the value of the card (A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K). This value should be a String
// Give the Card a property "Suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds)
// Give the Card a property "numerical_value" which will hold the numerical value of the card 1-13 as integers
// Next, create a class called "Deck"

// Give the Deck class a property called "cards" of type [Card]
// When initializing the deck make sure that it has the 52 unique cards in its "cards" property
// Give the Deck a deal method that selects the "top-most" card, removes it, and returns it
// Give the Deck a reset method that resets the cards property to the contain the original 52 cards
// Give the Deck a shuffle method that randomly reorders the deck's cards
// Finally, create a class called "Player"

// Give the Player class a name property
// Give the Player a hand property of type [Card]
// Give the Player a draw method of type (Deck) -> Card which draws a card from a deck, adds it to the players hand, and returns it
// Note how we are passing the Deck by reference here since it is a class. 
// Give the Player a discard method of type (Card) -> Bool which discards the Card specified and returns True if the Card existed and was successfully removed or False if the Card was not in the player's hand.