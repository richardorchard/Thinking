using System;
using System.Collections.Generic;
using System.Text;

namespace Thinking.Core
{
    public class Deck
    {

        public int Id { get; set; }
        public string DeckTitle { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastModified { get; set; }


    }
}
