using System;
using System.Collections.Generic;
using System.Text;
using Thinking.Core;

namespace Thinking.Data
{
    public class InMemoryCardData : ICardData
    {

        private readonly IDeckData _deckData = new InMemoryDeckData();

        List<Card> cards;


        public InMemoryCardData()
        {
            cards = new List<Card>
                {
                new Card {Id=1, CardTitle="Test Card 1", CardInformation="This is my card information", DateCreated= DateTime.Now,  DateLastModified=DateTime.Now, Deck = new Deck{Id=1, DeckTitle="Test Deck Title" }, DeckId=1, Order= 2 },
                  new Card {Id=2, CardTitle="Test Card 2", CardInformation="This is my card information 2", DateCreated= DateTime.Now,  DateLastModified=DateTime.Now, Deck = new Deck{Id=1, DeckTitle="Test Deck Title" }, DeckId=1, Order=2 },
                  new Card {Id=2, CardTitle="Test Card 3", CardInformation="This is my card information 3", DateCreated= DateTime.Now,  DateLastModified=DateTime.Now, Deck = new Deck{Id=1, DeckTitle="Test Deck Title" }, DeckId=1, Order=3 },

                };





        }




        public Card AddCardToDeck(Card Card, Deck Deck)
        {
            throw new NotImplementedException();
        }

        public Card GetCard(int CardId)
        {
            return cards.Find(c => c.Id == CardId);
        }

        public IEnumerable<Card> GetCardsByDeck(int deckId)
        {
            return cards.FindAll(c => c.DeckId == deckId);
        }
    }
}
