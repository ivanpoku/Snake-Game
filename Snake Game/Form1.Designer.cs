namespace Snake_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsTimer = new System.Windows.Forms.Timer(this.components);
            this.stopwatchLabel = new System.Windows.Forms.Label();
            this.applesLabel = new System.Windows.Forms.Label();
            this.appleImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 500;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // settingsTimer
            // 
            this.settingsTimer.Enabled = true;
            this.settingsTimer.Tick += new System.EventHandler(this.settingsTimer_Tick);
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.stopwatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.Location = new System.Drawing.Point(16, 8);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(320, 47);
            this.stopwatchLabel.TabIndex = 0;
            this.stopwatchLabel.Text = "00:00:00.00";
            this.stopwatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applesLabel
            // 
            this.applesLabel.BackColor = System.Drawing.Color.Transparent;
            this.applesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applesLabel.Location = new System.Drawing.Point(408, 8);
            this.applesLabel.Name = "applesLabel";
            this.applesLabel.Size = new System.Drawing.Size(64, 47);
            this.applesLabel.TabIndex = 1;
            this.applesLabel.Text = "0";
            this.applesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appleImage
            // 
            this.appleImage.BackColor = System.Drawing.Color.Transparent;
            this.appleImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appleImage.Location = new System.Drawing.Point(344, 8);
            this.appleImage.Name = "appleImage";
            this.appleImage.Size = new System.Drawing.Size(48, 48);
            this.appleImage.TabIndex = 2;
            this.appleImage.Text = "apple";
            this.appleImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_Game.Properties.Resources.snake_design_Page_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 531);
            this.Controls.Add(this.appleImage);
            this.Controls.Add(this.applesLabel);
            this.Controls.Add(this.stopwatchLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer settingsTimer;
        private System.Windows.Forms.Label stopwatchLabel;
        private System.Windows.Forms.Label applesLabel;
        private System.Windows.Forms.Label appleImage;
    }
}

