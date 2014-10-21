namespace RPGGame.UI
{
    partial class Story
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Story));
            this.introText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GiveupButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introText
            // 
            this.introText.AutoSize = true;
            this.introText.BackColor = System.Drawing.Color.Transparent;
            this.introText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.introText.Location = new System.Drawing.Point(12, 362);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(655, 68);
            this.introText.TabIndex = 0;
            this.introText.Text = resources.GetString("introText.Text");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GiveupButton
            // 
            this.GiveupButton.BackColor = System.Drawing.Color.Red;
            this.GiveupButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GiveupButton.Location = new System.Drawing.Point(51, 305);
            this.GiveupButton.Name = "GiveupButton";
            this.GiveupButton.Size = new System.Drawing.Size(146, 23);
            this.GiveupButton.TabIndex = 2;
            this.GiveupButton.Text = "Откажи се";
            this.GiveupButton.UseVisualStyleBackColor = false;
            this.GiveupButton.Visible = false;
            this.GiveupButton.Click += new System.EventHandler(this.GiveupButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Lime;
            this.AcceptButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AcceptButton.Location = new System.Drawing.Point(470, 305);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(146, 23);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Започни приключението";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Visible = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Story
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 340);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.GiveupButton);
            this.Controls.Add(this.introText);
            this.MaximizeBox = false;
            this.Name = "Story";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.Story_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GiveupButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}