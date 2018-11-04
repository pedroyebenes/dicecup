using System;
using System.Collections.Generic;

public class CLI
{
    protected int dices = 5;
    protected int difficulty = 6;
    protected bool tensTwoSuccesses = false;

    protected DiceCup.DiceCup diceCup;

    public CLI(string[] args)
    {
        CheckForHelp(args);
        ParseArguments(args);

        this.diceCup = new DiceCup.DiceCup();
    }

    private void CheckForHelp(string[] args)
    {
        foreach (string s in args)
        {
            if (s == "-h")
            {
                Console.WriteLine("DiceCup rolls 10-side dices.\n");
                Console.WriteLine("If no argument is provided, GUI is lanched. Command line arguments:");
                Console.WriteLine("            -d=X difficulty (default=6)");
                Console.WriteLine("            -n=Y number of dices (default=5)");
                Console.WriteLine("            -t=Z tens two successes, 0 is false, otherwise true (default=0)");
                Console.WriteLine("\nExample: ./DiceCup.exe -d=6 -n=5 -t=0");
                System.Environment.Exit(0);
            }
        }
    }

    private bool ParseIntArgument(string arg, string name, out int result)
    {
        bool parsed = false;
        result = 0;
        string[] s = arg.Split('=');

        if (s.Length == 2)
        {
            if (s[0] == name)
            {
                if (Int32.TryParse(s[1], out int i))
                {
                    result = i;
                    parsed = true;
                }
            }
        }
        return parsed;
    }

    private void ParseArguments(string[] args)
    {
        foreach (string s in args)
        {
            if (ParseIntArgument(s, "-n", out int value))
            {
                dices = value;
            }
            else if (ParseIntArgument(s, "-d", out value))
            {
                difficulty = value;
            }
            else if (ParseIntArgument(s, "-t", out value))
            {
                tensTwoSuccesses = (value != 0);
            }
        }
    }

    public void Run()
    {
        List<int> results = diceCup.Roll(dices);

        string summary = diceCup.ParseRoll(results, difficulty, tensTwoSuccesses,
                                           out int successes, out int failures, out int botches);

        string s = "[ "; 
        foreach (int i in results)
        {
            s += i + " ";
        }
        s += "]";
        Console.WriteLine(s + " (difficulty: " + difficulty + ")");
        Console.WriteLine(summary + " --> Successes: " + successes + " Failures: " + failures + " Botches: " + botches);
    }
}
