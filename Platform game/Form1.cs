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
        int PlayerSpeed = 6;

        private int move;

       

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
                force -= 3;
            }

            else
            {
                JumpSpeed = 10;
            }

            

            foreach(Control x in this.Controls)
            {


                
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "platform")
                    {
                        if(Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 15;
                            Player.Top = x.Top - Player.Height;
                        }

                        x.BringToFront();
                    }

                    if (goRight == true)
                    {
                        int move = 400;

                        //Verschiebung von Welt
                        if (Player.Left > move)
                        {


                            Platform.Left -= 1;
                            Object.Left -= 8;
                            ObjectUp.Left -= 8;
                        }

                        //Erzeugung von Welt
                        if (Object.Left < -250)
                        {
                            Object.Left = +1200;

                            if (ObjectUp.Left < -250)
                            {
                                ObjectUp.Left = +1600;

                            }

                        }
                    }


                    if (goLeft == true)
                    {

                        int move = 0;

                        //Verschiebung von Welt
                        if (Player.Left > move)
                        {


                            Platform.Left += 1;
                            Object.Left += 8;
                            ObjectUp.Left += 8;
                        }

                        //Erzeugung von Welt
                        if (Object.Left < +500)
                        {
                            Object.Left = -1200;

                            if (ObjectUp.Left < +500)
                            {
                                ObjectUp.Left = -1600;

                            }


                        }

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

                    if ((string)x.Tag == "platformUp")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 15;
                            Player.Top = x.Top - Player.Height;
                        }
                        x.BringToFront();
                    }


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
            if (e.KeyCode == Keys.S)
            {
                Player.Height -= 50;
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

            if(e.KeyCode == Keys.S)
            {
                Player.Height = 75;
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
        
            foreach (Control x in this.Controls)
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
        
            Player.Left = 10;
            Player.Top = 335;
            Platform.Width = 3000;

            

            GameTimer.Start();

        }
    }
}
