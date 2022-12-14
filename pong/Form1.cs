using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading; 

namespace pong
{
    public partial class Form1 : Form
    {

        // starting spawns 
        Rectangle player1 = new Rectangle(0, 180, 20, 20);
        Rectangle player2 = new Rectangle(505, 180, 20, 20);
        Rectangle Wsquare = new Rectangle(257, 180, 20, 20);
        Rectangle Ysquare = new Rectangle(257, 300, 12, 12); 
        
        // player score variables
        int player1Score = 0;
        int player2Score = 0;
        // player speed variables 
        int player1Speed = 4;
        int player2Speed = 4;
        int ballXSpeed = -4;
        int ballYSpeed = 4;
        // x and y variables
        int WX;

        int WY;

        int YX;

        int YY; 

        
     

        // key variables
        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool rightDown = false;
        // creating rand gens 
        Random WXGen = new Random();
        Random WYGen = new Random();
        Random YXGen = new Random();
        Random YYGen = new Random(); 

        
        // drawing utencils
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        Pen whiteBarrier = new Pen(Color.White, 3); 
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { // giving keys value
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
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break; 

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
            // give keys value
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
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
            }
        }

        

        private void tick(object sender, EventArgs e)
        {
            //W and Y square spawn generators 
            WX = WXGen.Next(1, 400);
            WY = WYGen.Next(1, 400); 

            YX = YYGen.Next(1, 400);

            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (aDown == true)
            {
                player1.X -= player1Speed;
            }
            if (dDown == true)
            {
                player1.X += +player1Speed; 
            }

            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }
            if  (rightDown == true)
            {
                player2.X += player2Speed; 
            }
            if (leftDown == true)
            {
                player2.X -=player2Speed;
            }


            
            
           // collison sound and code 
            SoundPlayer player = new SoundPlayer(Properties.Resources.boopSound);

           


            if (player1.IntersectsWith(Wsquare))
            {
                player1Score++;
                Wsquare.X = WX;     
                Wsquare.Y = WY;
                p1ScoreLabel.Text = $"{player1Score}";
                player.Play();
                player1Speed = 4; 
            }
            else if (player2.IntersectsWith(Wsquare))
            {
                player2Score++;
                
                Wsquare.X = WX;
                Wsquare.Y = WY;
                p2ScoreLabel.Text = $"{player2Score}";
                player.Play();
                player2Speed = 4; 
            }

            if (player1.IntersectsWith(Ysquare))
            {
                player1Speed = 10;
                Ysquare.X = YX;
                Wsquare.Y = YY;
                player.Play();
            }
            else if (player2.IntersectsWith(Ysquare))
            {
                player2Speed = 10;
                Ysquare.X = YX;
                Ysquare.Y = YY;
                player.Play();
            }
                        

            

            

            
              

            
            
            

            
          
        

            // checking  score and stop game if either player is at 5 outputting win text 
            if (player1Score == 5)
            {
                ticks.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
               
            }
            else if (player2Score == 5)
            {
                 ticks.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
               
            }
            
           

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //drawing everything
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(orangeBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, Wsquare);
            e.Graphics.FillRectangle(yellowBrush, Ysquare);



        }
       

    }
}

