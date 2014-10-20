using System;
using System.Windows.Forms;
using RPGGame.Interfaces;
using RPGGame.GameEngine;

namespace RPGGame.UI
{
    public partial class GameForm : Form
    {

        public const int TimeInterval = 200;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
            IUserInputInterface controler = new KeyboardMouseInterface(this);
            IPaintInterface painter = new PaintBrush(this);
            Engine engine = new Engine(controler, painter);

            Timer timer = new Timer();
            timer.Interval = TimeInterval;
            timer.Tick += (s, args) =>
            {
                engine.Update();
            };

            timer.Start();
        }
    }
}
