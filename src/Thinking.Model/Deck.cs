using System;
using System.Collections.Generic;
using System.Text;

namespace Thinking.Model
{
    public class Deck
    {

        public int Id { get; }
        public string DeckTitle { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastModified { get; set; }


    }
}
