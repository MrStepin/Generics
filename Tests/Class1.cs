using Generics;
using System;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Comparier _comparier = new Comparier();
        [Test]
        public void CheckTrueInts()

        {
            Pair<int> pair = new Pair<int>
            {
                First = 5,
                Second = 5
            };
            Assert.IsTrue(_comparier.Compare(pair.First, pair.Second));
        }
        [Test]
        public void CheckFalseInts()

        {
            Pair<int> pair = new Pair<int>
            {
                First = 56,
                Second = 5
            };
            Assert.False(_comparier.Compare(pair.First, pair.Second));
        }
        [Test]
        public void CheckTrueStrings()

        {
            Pair<string> pair = new Pair<string>
            {
                First = "aaabbb",
                Second = "aaabbb"
            };
            Assert.IsTrue(_comparier.Compare(pair.First, pair.Second));
        }
        [Test]
        public void CheckFalseStrings()

        {
            Pair<string> pair = new Pair<string>
            {
                First = "DF",
                Second = "Dfg"
            };
            Assert.False(_comparier.Compare(pair.First, pair.Second));
        }
        [Test]
        public void CheckTrueBool()

        {
            Pair<bool> pair = new Pair<bool>
            {
                First = false,
                Second = false
            };
            Assert.IsTrue(_comparier.Compare(pair.First, pair.Second));
        }
        [Test]
        public void CheckFalseBool()

        {
            Pair<bool> pair = new Pair<bool>
            {
                First = true,
                Second = false
            };
            Assert.False(_comparier.Compare(pair.First, pair.Second));
        }
    }
}
