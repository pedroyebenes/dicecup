using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DiceCup
{
    [TestFixture()]
    public class DiceCupTest
    {
        DiceCup diceCup;

        [SetUp]
        public void Init()
        {
            diceCup = new DiceCup();
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(20)]
        public void TestRoll(int dices)
        {
            List<int> results = diceCup.Roll(dices);
            Assert.AreEqual(results.Count, dices);
            foreach (int i in results)
            {
                Assert.GreaterOrEqual(i, 1);
                Assert.LessOrEqual(i, 10);
            }
        }

        private void TestSummary(int dices, int difficulty, bool tensTwoSuccesses)
        {
            Assert.LessOrEqual(difficulty, 10);
            Assert.Greater(dices, 0);

            List<int> results = diceCup.Roll(dices);
            string summary = diceCup.ParseRoll(results, difficulty, tensTwoSuccesses,
                                               out int successes, out int failures, out int botches);
            Assert.True(summary != "");
            if (successes == 0 && !tensTwoSuccesses)
            {
                Assert.AreEqual(successes + failures + 2 * botches, dices);
            }
        }

        [Test]
        [Repeat(100)]
        public void TestSummary1_9_0()
        {
            TestSummary(1, 9, false);
        }

        [Test]
        [Repeat(100)]
        public void TestSummary10_9_0()
        {
            TestSummary(10, 9, false);
        }

        [Test]
        [Repeat(100)]
        public void TestSummary20_9_0()
        {
            TestSummary(20, 9, false);
        }
    }
}
