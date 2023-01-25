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
            this.startLabelText = new System.Windows.Forms.Label();
            this.startLabelBackground = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
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
            // startLabelText
            // 
            this.startLabelText.BackColor = System.Drawing.Color.White;
            this.startLabelText.Font = new System.Drawing.Font("Wargate Normal", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabelText.Location = new System.Drawing.Point(120, 144);
            this.startLabelText.Name = "startLabelText";
            this.startLabelText.Size = new System.Drawing.Size(240, 160);
            this.startLabelText.TabIndex = 3;
            this.startLabelText.Text = "Snake Game";
            this.startLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startLabelBackground
            // 
            this.startLabelBackground.BackColor = System.Drawing.Color.White;
            this.startLabelBackground.Font = new System.Drawing.Font("Wargate Normal", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabelBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startLabelBackground.Location = new System.Drawing.Point(104, 128);
            this.startLabelBackground.Name = "startLabelBackground";
            this.startLabelBackground.Size = new System.Drawing.Size(272, 328);
            this.startLabelBackground.TabIndex = 4;
            this.startLabelBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Wargate Normal", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // restartLabel
            // 
            this.restartLabel.BackColor = System.Drawing.Color.DimGray;
            this.restartLabel.Font = new System.Drawing.Font("Wargate Normal", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(120, 256);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(240, 80);
            this.restartLabel.TabIndex = 6;
            this.restartLabel.Text = "RESTART?";
            this.restartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_Game.Properties.Resources.snake_design_Page_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 531);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startLabelText);
            this.Controls.Add(this.startLabelBackground);
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
        private System.Windows.Forms.Label startLabelText;
        private System.Windows.Forms.Label startLabelBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label restartLabel;
    }
}

