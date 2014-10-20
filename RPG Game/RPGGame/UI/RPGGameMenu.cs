using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGame.UI
{
    public partial class RPGGameMenu : Form
    {
        GameForm gameForm = new GameForm();
        Credits creditsForm = new Credits();

        public RPGGameMenu()
        {
            InitializeComponent();
        }

        private void RPGGameMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           gameForm.Show(); 
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creditsForm.Show();
        }
    }
}
