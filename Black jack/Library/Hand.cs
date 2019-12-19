using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Hand
    {
        public List<Card> handCards { get; private set; }
        public int score { get; set; }
        public Hand()
        {
            handCards = new List<Card>();
            score = 0;
        }
        public void draw(Deck deck)
        {
            Card temp = deck.dealCard();
            AddCard(temp);
        }
        public void AddCard(Card newCard)
        {
            if (score + 11 > 21 && newCard.Face == "Ace")
            {
                newCard.PointValue = 1;
            }
            handCards.Add(newCard);
            ScoreCheck();
            if(score > 21)
            {
                //Menus.GameOver("you went bust!");
            }

        }
        public void display()
        {
            foreach (var card in handCards)
            {
                Console.WriteLine(card.display());
            }
        }
        public void ScoreCheck()
        {
            score = 0;
            foreach (var card in handCards)
            {
                score += card.PointValue;
                if (score > 21)
                {
                    if (card.Face == "Ace" && card.PointValue == 11)
                    {
                        card.PointValue = 1;
                        ScoreCheck();
                    }
                }
            }

        }
    }
}
