using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Snake_Game
{

    public partial class Form1 : Form
    {
        //Rectangle player1 = new Rectangle(54, 254, 40, 40);
        Rectangle fruit = new Rectangle(354, 265, 15, 15);
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        string Direction = "Nil";
        int playerSpeed = 6;
        List<Rectangle> bodyParts = new List<Rectangle>();
        int partSize = 40;
        Random fruitRandom = new Random();
        int fruitLocationX = 354;
        int fruitLocationY = 265;
        Stopwatch gameStopwatch = new Stopwatch();
        int Apples = 0;


        public Form1()
        {
            InitializeComponent();
            bodyParts.Add(new Rectangle(55, 254, 40, 40));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(red, bodyParts[0]);
            e.Graphics.FillRectangle(yellow, fruit);
            for (int i = 1; i < bodyParts.Count; i++)
            {
                e.Graphics.FillRectangle(blue, bodyParts[i]);
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Display apples collected
            applesLabel.Text = $"{Apples}";

            //fruit locations
            fruit.X = fruitLocationX;
            fruit.Y = fruitLocationY;

            //wall collisions
            if (bodyParts[0].X <= 0)
            {
                Application.Exit();
            }
            if (bodyParts[0].X >= this.Width - partSize)
            {
                Application.Exit();
            }
            if (bodyParts[0].Y <= 50)
            {
                Application.Exit();
            }
            if (bodyParts[0].Y >= this.Width)
            {
                Application.Exit();
            }

            //check for snake body part collision
            for (int j = 3; j < bodyParts.Count; j++)
            {
                if (bodyParts[j].IntersectsWith(bodyParts[0]))
                {
                    Application.Exit();
                }
            }

            for (int i = bodyParts.Count - 1; i >= 0; i--)
            {
                //snake part add
                if (bodyParts[i].IntersectsWith(fruit))
                {
                    Apples++;
                    bodyParts.Add(new Rectangle(700, 700, 40, 40));
                    fruitLocationX = fruitRandom.Next(50, 450);
                    fruitLocationY = fruitRandom.Next(70, 450);
                }

                //snake directions          
                if (i == 0)
                {
                    switch (Direction)
                    {
                        case "Left":
                            int xLeft = bodyParts[i].X - playerSpeed - partSize;
                            bodyParts[i] = new Rectangle(xLeft, bodyParts[i].Y, bodyParts[i].Width, bodyParts[i].Height);
                            break;
                        case "Right":
                            int xRight = bodyParts[i].X + playerSpeed + partSize;
                            bodyParts[i] = new Rectangle(xRight, bodyParts[i].Y, bodyParts[i].Width, bodyParts[i].Height);
                            break;
                        case "Up":
                            int yUp = bodyParts[i].Y - playerSpeed - partSize;
                            bodyParts[i] = new Rectangle(bodyParts[i].X, yUp, bodyParts[i].Width, bodyParts[i].Height);
                            break;
                        case "Down":
                            int yDown = bodyParts[i].Y + playerSpeed + partSize;
                            bodyParts[i] = new Rectangle(bodyParts[i].X, yDown, bodyParts[i].Width, bodyParts[i].Height);
                            break;

                    }
                }

                //snake body part movement
                else
                {
                    int snakePartX = bodyParts[i - 1].X;
                    int snakePartY = bodyParts[i - 1].Y;
                    bodyParts[i] = new Rectangle(snakePartX, snakePartY, bodyParts[i].Width, bodyParts[i].Height);
                }

                //Checks for victory
                if (bodyParts.Count == 99)
                {
                    Application.Restart();
                }
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W && Direction != "Down")
            {
                Direction = "Up";
            }
            if (e.KeyCode == Keys.S && Direction != "Up")
            {
                Direction = "Down";
            }
            if (e.KeyCode == Keys.D && Direction != "Left")
            {
                Direction = "Right";
            }
            if (e.KeyCode == Keys.A && Direction != "Right")
            {
                Direction = "Left";
            }
        }

        private void settingsTimer_Tick(object sender, EventArgs e)
        {
            if (Direction != "Nil")
            {
                gameStopwatch.Start();
                stopwatchLabel.Text = gameStopwatch.Elapsed + "";
            }
        }
    }
}