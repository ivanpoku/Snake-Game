using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{

    public partial class Form1 : Form
    {
        int[ , ] gridLocations = new int[80,2];
        Rectangle player1 = new Rectangle(54, 254, 40, 40);
        Rectangle fruit = new Rectangle(354, 265, 15, 15);
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        string Direction = "Nil";
        int playerSpeed = 6;
        int[] snakeParts = new int[80];
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(red, player1);
            e.Graphics.FillRectangle(yellow, fruit);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //movement
            if (Direction == "Up")
            {
                player1.Y -= playerSpeed;
            }
            else if (Direction == "Down")
            {
                player1.Y += playerSpeed;
            }
            else if (Direction == "Left")
            {
                player1.X -= playerSpeed;
            }
            else if (Direction == "Right")
            {
                player1.X += playerSpeed;
            }

            //wall collisions
            if(player1.X <= 0)
            {
                Application.Exit();
            }
            if (player1.X >= this.Width)
            {
                Application.Exit();
            }
            if (player1.Y <= 70)
            {
                Application.Exit();
            }
            if (player1.Y >= this.Width)
            {
                Application.Exit();
            }

            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    Direction = "Up";
                    break;
                case Keys.S:
                    Direction = "Down";
                    break;
                case Keys.A:
                    Direction = "Left";
                    break;
                case Keys.D:
                    Direction = "Right";
                    break;

            }
        }
    }
}