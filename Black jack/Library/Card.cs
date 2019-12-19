using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Card
    {
        public string Face { get; set; }
        public int PointValue { get; set; }
        public string Suit { get; set; }

        public Card(string Fac, int Val, string Sui)
        {
            Face = Fac;
            PointValue = Val;
            Suit = Sui;
        }
        public string display()
        {
            return $"{Face} {PointValue} {Suit}";
        }
    }
}
