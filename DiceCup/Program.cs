using System;
using Gtk;

namespace DiceCup
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                CLI cLI = new CLI(args);
                cLI.Run();
            }
            else
            {
                Application.Init();
                MainWindow win = new MainWindow();
                win.Show();
                Application.Run();
            }
        }
    }
}
