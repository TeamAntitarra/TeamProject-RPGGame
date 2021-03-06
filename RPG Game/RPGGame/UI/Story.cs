﻿using System;
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
                            StoryHell();
                            break;
                        }
                    case 2:
                        {
                            StoryHeaven();
                            break;
                        }
                    case 3:
                        {
                            StoryAngel();
                            break;
                        }
                    case 4:
                        {
                            StoryDecide();
                            break;
                        }
                    default:
                        break;
                }

            }
        }
        
        private void StoryHell()
        {
            introText.Location = new Point(introText.Location.X, introText.Location.Y + 250);
            introText.Text = @"    Всичко в кралството вървяло нормално докато един ден селото не било нападнато от зли бъгове 
                                Бъговете рушали всичко наред. Запалвали къщите на хората убивали добитъка им.
                                    Принудени да изоставят къщите си жителите напуснали селото
                              Чак след часове преследване, селяните се скрили в гората да отпочинат.";
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\hell.jpg");
            stage++;
        }
        private void StoryHeaven()
        {
            introText.Location = new Point(introText.Location.X, introText.Location.Y + 250);
            introText.Text = @"Тогава от небето блеснала ярка светлина,всички се уплашили и се покрили освен нашия герой
                                    ,и се спуснал ангел и се насочил право към единствения останал на поляната";
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\heaven.jpg");
            stage++;
        }
        private void StoryAngel()
        {
            introText.Location = new Point(introText.Location.X, introText.Location.Y + 250);
            introText.Text = @"Ангелът застанал над него и му проговорил.
                            -Ти момче беше отреден от ордена на Ангелите-програмисти
                 От теб се иска да помогнеш на нас и цялото човечество, да се утървем от злите бъгове
                                          Приемаш ли тази мисия?";
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\angel.jpg");
            stage++;
        }
        private void StoryDecide()
        {
            introText.Text = @"Изборът и съдбата на човечеството е пред теб!!!";
            AcceptButton.Visible = true;
            GiveupButton.Visible = true;
            timer1.Stop();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var gameForm = new GameForm();
            gameForm.Show();
            this.Close();
        }

        private void GiveupButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
