using System;
using AlgoritmsCodingBat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsAlgoritmsCodingBat
{
    [TestClass]
    public class TestsLogic_2
    {
        internal Logic_2 Logic2 = new Logic_2();

        [TestMethod]
        public void TestMakeBricks()
        {

        }

        [TestMethod]
        public void TestLoneSum()
        {

        }

        [TestMethod]
        public void TestLuckySum()
        {

        }

        [TestMethod]
        public void TestNoTeenSum()
        {
            Assert.AreEqual(6,Logic2.NoTeenSum(1, 2, 3));
            Assert.AreEqual(3, Logic2.NoTeenSum(2, 13, 1));
            Assert.AreEqual(3, Logic2.NoTeenSum(2, 1, 14));
            Assert.AreEqual(18, Logic2.NoTeenSum(2, 1, 15));
            Assert.AreEqual(19, Logic2.NoTeenSum(2, 1, 16));
            Assert.AreEqual(3, Logic2.NoTeenSum(2, 1, 17));
            Assert.AreEqual(32, Logic2.NoTeenSum(15, 16, 1)); 
            Assert.AreEqual(30, Logic2.NoTeenSum(15, 15, 19));
            Assert.AreEqual(31, Logic2.NoTeenSum(15, 19, 16));
            Assert.AreEqual(5, Logic2.NoTeenSum(5, 17, 18));
            Assert.AreEqual(16, Logic2.NoTeenSum(17, 18, 16));
            Assert.AreEqual(0, Logic2.NoTeenSum(17, 19, 18));
        }

        [TestMethod]
        public void TestRoundSum()
        {
            Assert.AreEqual(60, Logic2.RoundSum(16, 17, 18));
            Assert.AreEqual(30, Logic2.RoundSum(12, 13, 14));
            Assert.AreEqual(10, Logic2.RoundSum(6, 4, 4));
            Assert.AreEqual(20, Logic2.RoundSum(4, 6, 5));
            Assert.AreEqual(10, Logic2.RoundSum(4, 4, 6));
            Assert.AreEqual(10, Logic2.RoundSum(9, 4, 4));
            Assert.AreEqual(0, Logic2.RoundSum(0, 0, 1));
            Assert.AreEqual(10, Logic2.RoundSum(0, 9, 0));
            Assert.AreEqual(40, Logic2.RoundSum(10, 10, 19));
            Assert.AreEqual(90, Logic2.RoundSum(20, 30, 40));
            Assert.AreEqual(100, Logic2.RoundSum(45, 21, 30));
            Assert.AreEqual(60, Logic2.RoundSum(23, 11, 26));
            Assert.AreEqual(70, Logic2.RoundSum(23, 24, 25));
            Assert.AreEqual(80, Logic2.RoundSum(25, 24, 25));
            Assert.AreEqual(70, Logic2.RoundSum(23, 24, 29));
            Assert.AreEqual(70, Logic2.RoundSum(11, 24, 36));
            Assert.AreEqual(90, Logic2.RoundSum(24, 36, 32));
            Assert.AreEqual(50, Logic2.RoundSum(14, 12, 26));
            Assert.AreEqual(40, Logic2.RoundSum(12, 10, 24));
        }

        [TestMethod]
        public void TestCloseFar()
        {
            Assert.AreEqual(true, Logic2.CloseFar(1, 2, 10));
            Assert.AreEqual(false, Logic2.CloseFar(1, 2, 3));
            Assert.AreEqual(true, Logic2.CloseFar(4, 1, 3));
            Assert.AreEqual(false, Logic2.CloseFar(4, 5, 3));
            Assert.AreEqual(false, Logic2.CloseFar(4, 3, 5));
            Assert.AreEqual(true, Logic2.CloseFar(-1, 10, 0));
            Assert.AreEqual(true, Logic2.CloseFar(0, -1, 10));
            Assert.AreEqual(true, Logic2.CloseFar(10, 10, 8));
            Assert.AreEqual(false, Logic2.CloseFar(10, 8, 9));
            Assert.AreEqual(false, Logic2.CloseFar(8, 9, 10));
            Assert.AreEqual(false, Logic2.CloseFar(8, 9, 7));
            Assert.AreEqual(true, Logic2.CloseFar(8, 6, 9));
           
        }

        [TestMethod]
        public void TestBlackjack()
        {
            Assert.AreEqual(21, Logic2.Blackjack(19, 21));
            Assert.AreEqual(21, Logic2.Blackjack(21, 19));
            Assert.AreEqual(19, Logic2.Blackjack(19,22));
            Assert.AreEqual(19, Logic2.Blackjack(22, 19));
            Assert.AreEqual(0, Logic2.Blackjack(22, 50));
            Assert.AreEqual(0, Logic2.Blackjack(22, 22));
            Assert.AreEqual(1, Logic2.Blackjack(33, 1));
            Assert.AreEqual(2, Logic2.Blackjack(1, 2));
            Assert.AreEqual(0, Logic2.Blackjack(34, 33));
            Assert.AreEqual(19, Logic2.Blackjack(17, 19));
            Assert.AreEqual(18, Logic2.Blackjack(18, 17));
            Assert.AreEqual(16, Logic2.Blackjack(16, 23));
            Assert.AreEqual(4, Logic2.Blackjack(3, 4));
            Assert.AreEqual(3, Logic2.Blackjack(3, 2));
            Assert.AreEqual(21, Logic2.Blackjack(21, 20));

        }

        [TestMethod]
        public void TestEvenlySpaced()
        {
            Assert.AreEqual(true, Logic2.EvenlySpaced(2, 4, 6));
            Assert.AreEqual(true, Logic2.EvenlySpaced(4, 6, 2));
            Assert.AreEqual(false, Logic2.EvenlySpaced(4, 6, 3));
            Assert.AreEqual(true, Logic2.EvenlySpaced(6, 2, 4));
            Assert.AreEqual(false, Logic2.EvenlySpaced(6, 2, 8));
            Assert.AreEqual(true, Logic2.EvenlySpaced(2, 2, 2));
            Assert.AreEqual(false, Logic2.EvenlySpaced(2, 2, 3));
            Assert.AreEqual(true, Logic2.EvenlySpaced(9, 10, 11));
            Assert.AreEqual(true, Logic2.EvenlySpaced(10, 9, 11));
            Assert.AreEqual(false, Logic2.EvenlySpaced(10, 9, 9));
            Assert.AreEqual(false, Logic2.EvenlySpaced(2, 4, 4));
            Assert.AreEqual(false, Logic2.EvenlySpaced(2, 2, 4));
            Assert.AreEqual(false, Logic2.EvenlySpaced(3, 6, 12));
            Assert.AreEqual(false, Logic2.EvenlySpaced(12, 3, 6));
        }

        [TestMethod]
        public void TestMakeChocolate()
        {
            Assert.AreEqual(4, Logic2.MakeChocolate(4, 1, 9));
            Assert.AreEqual(-1, Logic2.MakeChocolate(4, 1, 10));
            Assert.AreEqual(2, Logic2.MakeChocolate(4, 1, 7));
            Assert.AreEqual(2, Logic2.MakeChocolate(6, 2, 7));
            Assert.AreEqual(0, Logic2.MakeChocolate(4, 1, 5));
            Assert.AreEqual(4, Logic2.MakeChocolate(4, 1, 4));
            Assert.AreEqual(4, Logic2.MakeChocolate(5, 4, 9));
            Assert.AreEqual(3, Logic2.MakeChocolate(9, 3, 18));
            Assert.AreEqual(-1, Logic2.MakeChocolate(3, 1, 9));
            Assert.AreEqual(-1, Logic2.MakeChocolate(1, 2, 7));
            Assert.AreEqual(1, Logic2.MakeChocolate(1, 2, 6));
            Assert.AreEqual(0, Logic2.MakeChocolate(1, 2, 5));
            Assert.AreEqual(5, Logic2.MakeChocolate(6, 1, 10));
            Assert.AreEqual(6, Logic2.MakeChocolate(6, 1, 11));
            Assert.AreEqual(-1, Logic2.MakeChocolate(6, 1, 12));
            Assert.AreEqual(-1, Logic2.MakeChocolate(6, 1, 13));
            Assert.AreEqual(0, Logic2.MakeChocolate(6, 2, 10));
            Assert.AreEqual(1, Logic2.MakeChocolate(6, 2, 11));
            Assert.AreEqual(2, Logic2.MakeChocolate(6, 2, 12));
            Assert.AreEqual(50, Logic2.MakeChocolate(60, 100, 550));
            Assert.AreEqual(6, Logic2.MakeChocolate(1000, 1000000, 5000006));
            Assert.AreEqual(7, Logic2.MakeChocolate(7, 1, 12));
            Assert.AreEqual(-1, Logic2.MakeChocolate(7, 1, 13));
            Assert.AreEqual(3, Logic2.MakeChocolate(7, 2, 13));
        }


    }
}
