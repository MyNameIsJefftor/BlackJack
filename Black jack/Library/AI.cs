using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AI
    {
        public AI(Hand hand, Deck deck)
        {
            StartPlay(hand, deck);
        }

        private void StartPlay(Hand hand, Deck deck)
        {
            if(hand.score > 17)
            {
                return;
            }
            hand.draw(deck);
            StartPlay(hand, deck);
        }
    }
}