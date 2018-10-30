using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    DiceCup.DiceCup diceCup;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        this.diceCup = new DiceCup.DiceCup();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void UpdateTextView(List<int> results)
    {
        string t = "[ "; // for the text view 
        string l = "[ "; // for the label
        foreach (int i in results)
        {
            t += i + " ";
            if (i >= hscaleDifficulty.Value)
            {
                l += "<span font='20,Bold'>" + i + "</span> ";
            }
            else if (i == 1)
            {
                l += "<span font='20,Italic'>" + i + "</span> ";
            }
            else
            {
                l += i + " ";
            }
        }
        t += "]\n";
        l += "]\n";
        labelResults.LabelProp = "<span font='20'>" + l + "</span>";
        textview.Buffer.Text = t + textview.Buffer.Text;
    }

    protected void UpdateLabels(string summary, int successes, int failures, int botches)
    {
        labelSummary.Text = summary;
        labelSuccesses.Text = "Successes: " + successes;
        labelFailures.Text = "Failures: " + failures;
        labelBotches.Text = "Botches: " + botches;
    }

    protected void OnButtonRollClicked(object sender, EventArgs e)
    {
        List<int> results = diceCup.Roll((int)hscaleDices.Value);

        int difficulty = (int)hscaleDifficulty.Value;
        bool tensTwoSuccesses = checkbuttonTens.Active;

        string summary = diceCup.ParseRoll(results, difficulty, tensTwoSuccesses,
                                           out int successes, out int failures, out int botches);
        UpdateTextView(results);
        UpdateLabels(summary, successes, failures, botches);
    }
}
