using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCardsSort
{
    class ShuffleComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            Random random = new Random();
            return random.Next(-2, 2);
        }
    }
}
