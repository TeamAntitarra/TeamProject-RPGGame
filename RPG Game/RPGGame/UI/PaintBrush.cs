using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using RPGGame.Interfaces;

namespace RPGGame.UI
{
    public class PaintBrush : IPaintInterface
    {
        private const string TamplerImagePath = "../../Images/tampler.png";
        private const string LordTruikworImagePath = "../../Images/lordtruikwor.png";
        private const string TreeImagePath = "../../Images/tree.png";
        private const string RockImagePath = "../../Images/rock.png";
        private const string ZombieImagePath = "../../Images/zombie.png";

        private Image tamplerImage;
        private Image LordTruikworImage;
        private Image TreeImage;
        private Image RockImage;
        private Image ZombieImage;
        private Form gameWindow;
        private List<PictureBox> pictureBoxes;

        public PaintBrush(Form form)
        {
            this.gameWindow = form;
            this.LoadResources();
            this.pictureBoxes = new List<PictureBox>();
        }

        private void CreatePictureBox(IRenderable renderableObject)
        {
            var spriteImage = GetObjectImage(renderableObject);
            var picBox = new PictureBox();
            picBox.BackColor = Color.Transparent;
            picBox.Image = spriteImage;
            picBox.Parent = this.gameWindow;
            picBox.Location = new Point(renderableObject.X, renderableObject.Y);
            picBox.Size = new Size(renderableObject.SizeX, renderableObject.SizeY);
            picBox.Tag = renderableObject;
            this.pictureBoxes.Add(picBox);
            this.gameWindow.Controls.Add(picBox);
        }

        private Image GetObjectImage(IRenderable renderableObject)
        {
            Image image = null;
            switch (renderableObject.Id)
            {
                case "Templar":
                    image = this.tamplerImage;
                    break;
                case "Lord Truikwor":
                    image = this.LordTruikworImage;
                    break;
                case "Tree":
                    image = this.TreeImage;
                    break;
                case "Rock":
                    image = this.RockImage;
                    break;
                case "Zombie":
                    image = this.ZombieImage;
                    break;
                default:
                    break;
            }

            return image;
        }

        public void LoadResources()
        {
            this.tamplerImage = Image.FromFile(TamplerImagePath);
            this.LordTruikworImage = Image.FromFile(LordTruikworImagePath);
            this.TreeImage = Image.FromFile(TreeImagePath);
            this.RockImage = Image.FromFile(RockImagePath);
            this.ZombieImage = Image.FromFile(ZombieImagePath);
        }

        public void AddObject(IRenderable renderableObject)
        {
            this.CreatePictureBox(renderableObject);
        }

        public void RemoveObject(IRenderable renderableObject)
        {
            var picBox = GetPictureBoxByObject(renderableObject);
            this.gameWindow.Controls.Remove(picBox);
            this.pictureBoxes.Remove(picBox);
        }

        public void RedrawObject(IRenderable objectToBeRedrawn)
        {
            var newCoordinates = new Point(objectToBeRedrawn.X, objectToBeRedrawn.Y);
            PictureBox picBox = GetPictureBoxByObject(objectToBeRedrawn);
            picBox.Location = newCoordinates;
        }

        private PictureBox GetPictureBoxByObject(IRenderable renderableObject)
        {
            return this.pictureBoxes.First(p => p.Tag == renderableObject);
        }
    }
}
