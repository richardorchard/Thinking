using System;
using System.Collections.Generic;
using System.Text;
using Thinking.Core;

namespace Thinking.Data
{
    public interface ICardData
    {

        IEnumerable<Card> GetCardsByDeck(int deckId);

        Card AddCardToDeck(Card Card, Deck Deck);

        Card GetCard(int CardId);
        

    }
}
