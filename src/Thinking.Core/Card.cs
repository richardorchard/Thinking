using System;
using System.Collections.Generic;
using System.Text;

namespace Thinking.Core
{
    public class Card
    {

        public int Id { get; set; }

        public string CardTitle { get; set; }

        public string CardInformation { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastModified { get; set; }

        public Deck Deck { get; set; }

        public int DeckId { get; set; }

        public int Order { get; set; }




    }
}
