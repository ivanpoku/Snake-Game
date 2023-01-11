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
        Rectangle player1 = new Rectangle(10, 170, 60, 60);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush limeBrush = new SolidBrush(Color.LimeGreen);
        int playerSpeed = 6;
        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(greenBrush, player1);

        }

        /*private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }*/

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (wDown == true)
            {
                player1.Y -= playerSpeed;
            }
            if (sDown == true)
            {
                player1.Y += playerSpeed;
            }
            Refresh();
        }
    }
}