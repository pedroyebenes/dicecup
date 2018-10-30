
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox2;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label labelResults;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Label labelDices;

	private global::Gtk.HScale hscaleDices;

	private global::Gtk.Label labelDifficulty;

	private global::Gtk.HScale hscaleDifficulty;

	private global::Gtk.CheckButton checkbuttonTens;

	private global::Gtk.VSeparator vseparator3;

	private global::Gtk.Label labelSuccesses;

	private global::Gtk.Label labelFailures;

	private global::Gtk.Label labelBotches;

	private global::Gtk.VSeparator vseparator2;

	private global::Gtk.Label labelSummary;

	private global::Gtk.VSeparator vseparator1;

	private global::Gtk.Button buttonRoll;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.WidthRequest = 900;
		this.HeightRequest = 450;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Dice cup");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("DiceCup.img.dice.ico");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.BorderWidth = ((uint)(20));
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelResults = new global::Gtk.Label();
		this.labelResults.Name = "labelResults";
		this.labelResults.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\'20,Bold\'>[ ]</span>");
		this.labelResults.UseMarkup = true;
		this.labelResults.Justify = ((global::Gtk.Justification)(2));
		this.vbox2.Add(this.labelResults);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelResults]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview = new global::Gtk.TextView();
		this.textview.CanFocus = true;
		this.textview.Name = "textview";
		this.textview.Editable = false;
		this.textview.Overwrite = true;
		this.textview.Justification = ((global::Gtk.Justification)(3));
		this.GtkScrolledWindow.Add(this.textview);
		this.vbox2.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
		w3.Position = 1;
		this.hbox2.Add(this.vbox2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox2]));
		w4.Position = 0;
		w4.Padding = ((uint)(10));
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.WidthRequest = 175;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelDices = new global::Gtk.Label();
		this.labelDices.Name = "labelDices";
		this.labelDices.LabelProp = global::Mono.Unix.Catalog.GetString("Dices");
		this.vbox1.Add(this.labelDices);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelDices]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hscaleDices = new global::Gtk.HScale(null);
		this.hscaleDices.CanFocus = true;
		this.hscaleDices.Name = "hscaleDices";
		this.hscaleDices.UpdatePolicy = ((global::Gtk.UpdateType)(1));
		this.hscaleDices.Adjustment.Lower = 1D;
		this.hscaleDices.Adjustment.Upper = 20D;
		this.hscaleDices.Adjustment.PageIncrement = 10D;
		this.hscaleDices.Adjustment.StepIncrement = 1D;
		this.hscaleDices.Adjustment.Value = 10D;
		this.hscaleDices.DrawValue = true;
		this.hscaleDices.Digits = 0;
		this.hscaleDices.ValuePos = ((global::Gtk.PositionType)(2));
		this.vbox1.Add(this.hscaleDices);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hscaleDices]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelDifficulty = new global::Gtk.Label();
		this.labelDifficulty.Name = "labelDifficulty";
		this.labelDifficulty.LabelProp = global::Mono.Unix.Catalog.GetString("Difficulty");
		this.vbox1.Add(this.labelDifficulty);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelDifficulty]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hscaleDifficulty = new global::Gtk.HScale(null);
		this.hscaleDifficulty.CanFocus = true;
		this.hscaleDifficulty.Name = "hscaleDifficulty";
		this.hscaleDifficulty.UpdatePolicy = ((global::Gtk.UpdateType)(2));
		this.hscaleDifficulty.Adjustment.Lower = 3D;
		this.hscaleDifficulty.Adjustment.Upper = 9D;
		this.hscaleDifficulty.Adjustment.PageIncrement = 10D;
		this.hscaleDifficulty.Adjustment.StepIncrement = 1D;
		this.hscaleDifficulty.Adjustment.Value = 6D;
		this.hscaleDifficulty.DrawValue = true;
		this.hscaleDifficulty.Digits = 0;
		this.hscaleDifficulty.ValuePos = ((global::Gtk.PositionType)(2));
		this.vbox1.Add(this.hscaleDifficulty);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hscaleDifficulty]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.checkbuttonTens = new global::Gtk.CheckButton();
		this.checkbuttonTens.CanFocus = true;
		this.checkbuttonTens.Name = "checkbuttonTens";
		this.checkbuttonTens.Label = global::Mono.Unix.Catalog.GetString("10\'s are 2 successes");
		this.checkbuttonTens.DrawIndicator = true;
		this.checkbuttonTens.UseUnderline = true;
		this.vbox1.Add(this.checkbuttonTens);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.checkbuttonTens]));
		w9.Position = 4;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vseparator3 = new global::Gtk.VSeparator();
		this.vseparator3.Name = "vseparator3";
		this.vbox1.Add(this.vseparator3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vseparator3]));
		w10.Position = 5;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelSuccesses = new global::Gtk.Label();
		this.labelSuccesses.Name = "labelSuccesses";
		this.labelSuccesses.LabelProp = global::Mono.Unix.Catalog.GetString("Successes:");
		this.vbox1.Add(this.labelSuccesses);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelSuccesses]));
		w11.Position = 6;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelFailures = new global::Gtk.Label();
		this.labelFailures.Name = "labelFailures";
		this.labelFailures.LabelProp = global::Mono.Unix.Catalog.GetString("Failures:");
		this.vbox1.Add(this.labelFailures);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelFailures]));
		w12.Position = 7;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelBotches = new global::Gtk.Label();
		this.labelBotches.Name = "labelBotches";
		this.labelBotches.LabelProp = global::Mono.Unix.Catalog.GetString("Botches:");
		this.vbox1.Add(this.labelBotches);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelBotches]));
		w13.Position = 8;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vseparator2 = new global::Gtk.VSeparator();
		this.vseparator2.Name = "vseparator2";
		this.vbox1.Add(this.vseparator2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vseparator2]));
		w14.Position = 9;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelSummary = new global::Gtk.Label();
		this.labelSummary.Name = "labelSummary";
		this.vbox1.Add(this.labelSummary);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelSummary]));
		w15.Position = 10;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator();
		this.vseparator1.Name = "vseparator1";
		this.vbox1.Add(this.vseparator1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vseparator1]));
		w16.Position = 11;
		// Container child vbox1.Gtk.Box+BoxChild
		this.buttonRoll = new global::Gtk.Button();
		this.buttonRoll.WidthRequest = 128;
		this.buttonRoll.HeightRequest = 64;
		this.buttonRoll.CanFocus = true;
		this.buttonRoll.Name = "buttonRoll";
		this.buttonRoll.UseUnderline = true;
		this.buttonRoll.Label = global::Mono.Unix.Catalog.GetString("Roll!");
		this.vbox1.Add(this.buttonRoll);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonRoll]));
		w17.Position = 12;
		w17.Expand = false;
		w17.Fill = false;
		this.hbox2.Add(this.vbox1);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox1]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		w18.Padding = ((uint)(20));
		this.Add(this.hbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 900;
		this.DefaultHeight = 600;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.buttonRoll.Clicked += new global::System.EventHandler(this.OnButtonRollClicked);
	}
}