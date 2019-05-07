using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCardsSort
{
    
    class Card
    {
        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card (Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
