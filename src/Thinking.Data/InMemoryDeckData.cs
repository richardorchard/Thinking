using System;
using System.Collections.Generic;
using System.Linq;
using Thinking.Core;

namespace Thinking.Data
{


    public class InMemoryDeckData : IDeckData
    {
        List<Deck> decks;

        public InMemoryDeckData()
        {
            decks = new List<Deck>()
            {
                new Deck{Id=1, Category=new Category{ CategoryName="Music"}, CategoryId=1, User=new User{username="Richard Orchard" }, UserId=1, DateCreated= DateTime.Now, DateLastModified = DateTime.Now, DeckTitle="Queen" },

                 new Deck{Id=2, Category=new Category{ CategoryName="Dog Stuff"}, CategoryId=2, User=new User{username="Buffy Orchard" }, UserId=2, DateCreated= DateTime.Now, DateLastModified = DateTime.Now, DeckTitle="Bones" },


                   new Deck{Id=3, Category=new Category{ CategoryName="Dog Stuff"}, CategoryId=2, User=new User{username="Buffy Orchard" }, UserId=2, DateCreated= DateTime.Now, DateLastModified = DateTime.Now, DeckTitle="Sleeping" },


                   new Deck{Id=4, Category=new Category{ CategoryName="Movies"}, CategoryId=1, User=new User{username="Richard Orchard" }, UserId=1, DateCreated= DateTime.Now, DateLastModified = DateTime.Now, DeckTitle="Favourite Movies" }

            };
        }

        public Deck Add(Deck newDeck)
        {
            decks.Add(newDeck);
            newDeck.Id = decks.Max(d => d.Id) + 1;
            return newDeck;



        }

        public int Commit()
        {
            return 1;
        }

        public Deck Delete(int id)
        {


            var deck = decks.FirstOrDefault(d => d.Id == id);

            if (deck != null)
            {
                decks.Remove(deck);
            }

            return null;


        }

        public IEnumerable<Deck> GetAllDecks()
        {
            return decks;
        }

        public Deck GetById(int id)
        {
            return decks.SingleOrDefault(d => d.Id == id);
        }

        public int GetCountOfDecks()
        {
            return decks.Count;
        }

        public Deck Update(Deck updatedDeck)
        {
            var deck = decks.SingleOrDefault(d => d.Id == updatedDeck.Id);


            if (deck != null)
            {
                deck.Category = updatedDeck.Category;
                deck.CategoryId = updatedDeck.CategoryId;
                deck.DateLastModified = updatedDeck.DateLastModified;

                deck.DeckTitle = updatedDeck.DeckTitle;
                deck.User = updatedDeck.User;
                deck.UserId = updatedDeck.UserId;

            }

            return deck;
        }
    }
}
