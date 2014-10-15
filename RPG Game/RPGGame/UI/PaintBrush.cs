using System;
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

        private Image tamplerImage;
        private Image LordTruikworImage;
        private Form gameWindow;
        private List<PictureBox> pictureBoxes;

        public PaintBrush(Form form)
        {
            this.gameWindow = form;
            this.LoadResources();
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
                default:
                    break;
            }

            return image;
        }

        public void LoadResources()
        {
            this.tamplerImage = Image.FromFile(TamplerImagePath);
            this.LordTruikworImage = Image.FromFile(LordTruikworImagePath);
        }

        public void AddObject(IRenderable renderableObject)
        {
            throw new NotImplementedException();
        }

        public void RemoveObject(IRenderable renderableObject)
        {
            throw new NotImplementedException();
        }

        public void RedrawObject(IRenderable renderableObject)
        {
            throw new NotImplementedException();
        }
    }
}
