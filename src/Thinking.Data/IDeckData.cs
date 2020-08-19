using System.Collections;
using System.Collections.Generic;
using Thinking.Core;

namespace Thinking.Data
{
    public interface IDeckData
    {

        IEnumerable<Deck> GetAllDecks();

        Deck GetById(int id);


        Deck Update(Deck updatedDeck);

        Deck Add(Deck newDeck);


        Deck Delete(int id);


        int Commit();

        int GetCountOfDecks();



    }
}