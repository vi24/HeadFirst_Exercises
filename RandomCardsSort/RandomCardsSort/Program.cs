using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomCardsSort
{
    class Program
    {

        public static int TheTruth = 42;

        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();
            CardComparer_byValue cardComparer_ByValue = new CardComparer_byValue();
            ShuffleComparer shuffleComparer = new ShuffleComparer();
            for (int i = 1; i <= 10; i++)
            {
                cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            Console.WriteLine("Five random cards: ");
            Show_Cards(GetCardNames(cards));
            cards.Sort(cardComparer_ByValue);
            Console.WriteLine("\nThose same cards, sorted:");
            Show_Cards(GetCardNames(cards));
            Console.ReadKey();
            Console.WriteLine("\nThose same cards, shuffled:");
            Shuffle(cards, random);
            Show_Cards(GetCardNames(cards));
            Console.ReadKey();
            Console.WriteLine("\nThose same cards, again shuffled:");
            Shuffle(cards, shuffleComparer);
            Show_Cards(GetCardNames(cards));
            Console.ReadKey();
        }

        public static void Show_Cards(IEnumerable<string> cardNames)
        {
            foreach(string name in cardNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void Shuffle(List<Card> cards, Random random)
        {
            for (int i = 0; i < cards.Count * 2; i++)
            {
                Card newCard = cards[random.Next(cards.Count)];
                cards.Remove(newCard);
                cards.Add(newCard);
            }
        }

        public static void Shuffle(List<Card> cards, ShuffleComparer shuffleComparer)
        {
            cards.Sort(shuffleComparer);
        }

        public static IEnumerable<string> GetCardNames(List<Card> cards)
        {
            List<string> cardNames = new List<string>();
            foreach(Card card in cards)
            {
                cardNames.Add(card.Name);
            }

            return cardNames;
        }
    }
}
