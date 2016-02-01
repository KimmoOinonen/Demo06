using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Deck
    {
        public string DeckName { get; set; }

        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void PrintCollection()
        {
            Console.WriteLine("Cards:");
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
        public override string ToString()
        {
            return "Name of the card deck: " + DeckName;
        }
    }
}
