using System;
using System.Collections.Generic;

namespace DiceCup
{
    /// <summary>
    /// Dice cup rolls ten-side dices.
    /// It has been designed to play Vampire: The Masquerade 20th anniversary edition.
    /// </summary>
    public class DiceCup
    {
        private readonly Random randomGenerator;

        public DiceCup()
        {
            this.randomGenerator = new Random();
        }

        public List<int> Roll(int dices)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < dices; i++)
            {
                result.Add(randomGenerator.Next(1, 11)); //10-side dices
            }
            return result;
        }

        public string ParseRoll(List<int> results, int difficulty,
                                bool tensTwoSuccesses, out int successes,
                                out int failures, out int botches)
        {
            successes = 0;
            failures = 0;
            botches = 0;

            foreach (int i in results)
            {
                if (i >= difficulty)
                {
                    successes += (tensTwoSuccesses && i == 10) ? 2 : 1;
                }
                else
                {
                    if (i != 1)
                        failures += 1;
                    else
                        botches += 1;
                }
            }
            if (successes > 0)
            {
                successes = (successes - botches > 0) ? successes - botches : 0;
            }
            else
            {
                successes -= botches;
            }

            string summary = successes == 1 ? "Marginal success!"
                    : successes == 2 ? "Moderate success!"
                    : successes == 3 ? "Complete success!"
                    : successes == 4 ? "Exceptional success!"
                    : successes >= 5 ? "Phenomenal success!"
                    : successes == 0 ? "Failure!" : "Botche!";

            return summary;
        }
    }
}
