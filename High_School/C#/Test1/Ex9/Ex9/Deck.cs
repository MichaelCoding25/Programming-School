using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Deck
    {
        private Card[] allCards;

        public Deck()
        {
            allCards = new Card[36];
            // Here there are supposed to be a couple lines that set a random value and color to each card in the deck.
        }
        public Card[] GetAllCards()
        {
            return allCards;
        }
        public void SetAllCards(Card[] allCards)
        {
            this.allCards = allCards;
        }
        public Card SeeCard(int i)
        {
            return allCards[i];
        }
    }
}
