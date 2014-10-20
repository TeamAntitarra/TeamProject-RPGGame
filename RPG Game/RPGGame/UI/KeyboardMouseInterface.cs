namespace RPGGame.UI
{
    using System;
    using RPGGame.Interfaces;
    using System.Windows.Forms;

    public class KeyboardMouseInterface : IUserInputInterface
    {
        public event EventHandler OnRightPressed;

        public event EventHandler OnLeftPressed;

        public event EventHandler OnUpPressed;

        public event EventHandler OnDownPressed;

        public event EventHandler OnMouseClicked;

        public KeyboardMouseInterface(Form form)
        {
            form.KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (this.OnUpPressed != null)
                    {
                        this.OnUpPressed(this.OnUpPressed, new EventArgs());
                    }
                    break;
                case Keys.S:
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this.OnDownPressed, new EventArgs());
                    }
                     break;
                case Keys.A:
                     if (this.OnLeftPressed != null)
                     {
                         this.OnLeftPressed(this.OnLeftPressed, new EventArgs());
                     }
                    break;
                case Keys.D:
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this.OnRightPressed, new EventArgs());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
