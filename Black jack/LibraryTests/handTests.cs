using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass()]
    public class handTests
    {
        [TestMethod()]
        public void AddCardTest()
        {
            Hand test = new Hand();
            test.AddCard(new Card("Ace", 11, "hearts", 1));
            Assert.AreEqual(11, test.score);
            test.AddCard(new Card("Ace", 11, "spade", 1));
            Assert.AreEqual(12, test.score);
            test.AddCard(new Card("10", 10, "hearts", 1));
            Assert.AreEqual(12, test.score);
            test.AddCard(new Card("Ace", 11, "diamond", 1));
            Assert.AreEqual(13, test.score);
        }
    }
}