namespace RPGGame
{
    using System;
    using System.Windows.Forms;
    using RPGGame.UI;

    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RPGGameMenu());
        }
    }
}
