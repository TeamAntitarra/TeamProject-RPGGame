using System;
using System.Windows.Forms;
using RPGGame.Interfaces;
using RPGGame.GameEngine;

namespace RPGGame.UI
{
    public partial class GameForm : Form
    {

        public const int TimeInterval = 1;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
            IUserInputInterface controler = new KeyboardMouseInterface(this);
            IPaintInterface painter = new PaintBrush(this);
            var engine = new Engine(controler, painter);
            var timer = new Timer {Interval = TimeInterval};
            timer.Tick += (s, args) => engine.Update();

            timer.Start();
        }

    }
}
