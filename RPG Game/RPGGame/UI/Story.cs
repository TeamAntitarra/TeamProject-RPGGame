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
    public partial class Story : Form
    {
        public int stage = 1;
        public Story()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Story_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (introText.Location.Y > 100)
            {
                introText.Location = new Point(introText.Location.X, introText.Location.Y - 5);
            }
            else
            {
                switch (stage)
                {
                    case 1:
                        {
                            storyHell();
                            break;
                        }
                    case 2:
                        {
                            storyHeaven();
                            break;
                        }
                    case 3:
                        {
                            storyAngel();
                            break;
                        }
                    case 4:
                        {
                            storyDecide();
                            break;
                        }
                    default:
                        break;
                }

            }
        }
        
        private void storyHell()
        {
            introText.Location = new Point(introText.Location.X, introText.Location.Y + 250);
            introText.Text = "Всичко в кралството вървяло нормално докато един ден селото не било нападнато от зли демони \n        Принудени да изоставят къщите си жителите напуснали селото си.";
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\hell.jpg");
            stage++;
        }
        private void storyHeaven()
        {
            introText.Location = new Point(introText.Location.X, introText.Location.Y + 250);
            introText.Text = "Тогава от небето пред нашия герой се явил ангел";
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\heaven.jpg");
            stage++;
        }
        private void storyAngel()
        {
            introText.Location = new Point(introText.Location.X, introText.Location.Y + 250);
            introText.Text = "Ангелът го погледнал";
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\angel.jpg");
            stage++;
        }
        private void storyDecide()
        {
            introText.Text = "Изборът и съдбата на човечеството е пред теб!!!";
            AcceptButton.Visible = true;
            GiveupButton.Visible = true;
            timer1.Stop();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void GiveupButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
