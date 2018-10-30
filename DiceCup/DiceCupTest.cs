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
            if (successes == 1)
                Assert.True(summary == "Marginal success!", summary + " instead of " + "Marginal success!");
            else if (successes == 2)
                Assert.True(summary == "Moderate success!", summary + " instead of " + "Moderate success!");
            else if (successes == 3)
                Assert.True(summary == "Complete success!", summary + " instead of " + "Complete success!");
            else if (successes == 4)
                Assert.True(summary == "Exceptional success!", summary + " instead of " + "Exceptional success!");
            else if (successes >= 5)
                Assert.True(summary == "Phenomenal success!", summary + " instead of " + "Phenomenal success!");
            else if (botches > 0 && successes == 0)
                Assert.True(summary == "Botche!", summary + " instead of " + "Botche!");
            else
                Assert.True(summary == "Failure!", summary + " instead of " + "Failure!");
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
        public void TestSummary20_6_0()
        {
            TestSummary(20, 6, false);
        }

        [Test]
        [Repeat(100)]
        public void TestSummary20_6_1()
        {
            TestSummary(20, 6, true);
        }

        [Test]
        [Repeat(100)]
        public void TestSummary20_9_0()
        {
            TestSummary(20, 9, false);
        }

        [Test]
        [Repeat(100)]
        public void TestSummary20_9_1()
        {
            TestSummary(20, 9, true);
        }
    }
}
