using System;
using System.Windows.Forms;
using RPGGame.Interfaces;
using RPGGame.GameEngine;

namespace RPGGame.UI
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            Engine engine = new Engine();
            IPaintInterface painter = new PaintBrush(this);
        }
    }
}
