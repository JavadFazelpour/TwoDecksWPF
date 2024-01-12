using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();
        public Deck() { Reset(); }

        public void Reset()
        {
            throw new NotImplementedException("aaaa");
        }
        public Card Deal(int index)
        {
            throw new NotImplementedException("aaaa");
        }
        public void Shuffle()
        {

        }
        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort(new CardComparerByValue());
            // Use a foreach loop to call Add for each card in sortedCards
            throw new NotImplementedException("The Sort method sorts the cards.");
}
    }
}
