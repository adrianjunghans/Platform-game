using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, GameOver;

        int JumpSpeed;
        int force;
        int Score = 0;
        int PlayerSpeed = 10;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            Player.Top += JumpSpeed;
            
            if(goLeft == true)
            {
                Player.Left -= PlayerSpeed;
                
            }

            if(goRight == true)
            {
                Player.Left += PlayerSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false; 
            }

            if(jumping == true)
            {
                JumpSpeed -= 7;
                force -= 2;
            }

            else
            {
                JumpSpeed = 15;
            }

            

            foreach(Control x in this.Controls)
            {
                 
                if(x is PictureBox)
                {
                    if((string)x.Tag == "platform")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            
                            force = 8;
                            Player.Top = x.Top - Player.Height;

                        }

                        x.BringToFront();
                    }

                    if ((string)x.Tag == "platformFront")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            RestartGame();
                            MessageBox.Show("Verloren");
                        }
                        x.BringToFront();
                    }

                }
                if (Player.Left < -150)
                {
                    Platform.Left += 800;
                }

            }
            
        }

        
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
        //Wenn A gedrückt, dann Links laufen
        if(e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
        //Wenn D gedrückt, dann Rechts laufen
        if(e.KeyCode == Keys.D)
            {
                goRight = true;
            }
        //Wenn Leer Taste bereits gedrückt dann Gravitation
        if(e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true; 
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if(jumping == true)
            {
                jumping = false; 
            }

            if(e.KeyCode == Keys.Enter && GameOver == true)
            {
                RestartGame();
            }


        }

        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            GameOver = false;
            int Score = 0;

            Convert.ToString(Score);

            txtScore.Text = "Score" + Score;

            foreach(Control x in this.Controls)
                if(x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }

            Player.Left = 12;
            Player.Top = 335;

            GameTimer.Start();

        }
    }
}
