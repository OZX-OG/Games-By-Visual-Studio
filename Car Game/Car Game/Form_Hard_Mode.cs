using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Game
{
    public partial class Form_Hard_Mode : Form
    {
        public Form_Hard_Mode()
        {
            InitializeComponent();
        }

        enum Dir { Right, Left, None }

        int speed = 7;
        int score = 0;
        int TopScore = 0;
        Dir dir = Dir.None;
        Random r = new Random();

        void Cars14(PictureBox PB)
        {
            if (PB.Visible)
                PB.Top += speed;
            if (PB.Top > pnlGame.Height)
            {
                PB.Visible = false;
                PB.Top = -PB.Height;
                PB.Left = r.Next((pnlGame.Width - PB.Width) / 2);
                PB.Visible = true;
            }
        }

        void Cars58(PictureBox PB)
        {
            if (PB.Visible)
                PB.Top += speed;
            if (PB.Top > pnlGame.Height)
            {
                PB.Visible = false;
                PB.Top = -PB.Height;
                PB.Left = r.Next(pnlGame.Width / 2, pnlGame.Width - PB.Width);
                PB.Visible = true;
            }
        }

        /////////Respon Game Over and Replay
        void ResponReplayCars14(PictureBox PB, PictureBox PB1, PictureBox PB2, PictureBox PB3)
        {
            PB.Left = 38;
            PB1.Left = (38 * 2) + 10;
            PB2.Left = (86 * 2) + 10;
            PB3.Left = 282;
        }
        void ResponReplayCars58(PictureBox PB, PictureBox PB1, PictureBox PB2, PictureBox PB3)
        {
            PB.Left = pnlGame.Height - car5.Width;
            PB1.Left = pnlGame.Height - car6.Width + 100;
            PB2.Left = pnlGame.Height - car7.Width + 200;
            PB3.Left = pnlGame.Height - car8.Width + 250;
        }

        /////////Speeds Lines
        void SpeedsLines(PictureBox PB)
        {
            PB.Top += speed;
            if (PB.Top > pnlGame.Height) PB.Top = -PB.Height;
        }

        private void timerAction_Tick(object sender, EventArgs e)
        {
            SpeedsLines(L1);
            SpeedsLines(L2);
            SpeedsLines(L3);
            SpeedsLines(L4);
            SpeedsLines(L5);
            SpeedsLines(L6);
            SpeedsLines(L7);
            SpeedsLines(L8);
            SpeedsLines(L9);
            SpeedsLines(L10);
            

            Cars14(car1);
            Cars14(car2);
            Cars14(car3);
            Cars14(car4);

            Cars58(car5);
            Cars58(car6);
            Cars58(car7);
            Cars58(car8);

            score++;
            if (score > 1000) speed = 8;
            if (score > 2000) speed = 9;
            if (score > 3000) speed = 10;
            if (score > 4000) speed = 11;
            if (score > 5000) speed = 12;
            if (score > 6000) speed = 13;
            if (score > 7000) speed = 14;
            if (score > 8000) speed = 15;
            if (score > 9000) speed = 16;
            if (score > 10000) speed = 17;
            lblScore.Text = "Score: " + score;
            lblspeed.Text = "Speed: " + (speed - 6);




            if (Player.Bounds.IntersectsWith(car1.Bounds) || Player.Bounds.IntersectsWith(car2.Bounds) || Player.Bounds.IntersectsWith(car3.Bounds) || Player.Bounds.IntersectsWith(car4.Bounds) || Player.Bounds.IntersectsWith(car5.Bounds) || Player.Bounds.IntersectsWith(car6.Bounds) || Player.Bounds.IntersectsWith(car7.Bounds) || Player.Bounds.IntersectsWith(car8.Bounds))
            {
                timerAction.Enabled = false;
                lblGameOverr.Visible = true;
                lblGameOver.Visible = true;
                TopScore = score;
                if (TopScore > score) lblTopScore.Text = "Last Score: " + TopScore;
                else lblTopScore.Text = "Last Score: " + TopScore;
            }

            if (dir == Dir.Left && Player.Left > 0)
                Player.Left -= speed;
            if (dir == Dir.Right && Player.Left < pnlGame.Width - Player.Width)
                Player.Left += speed;
        
        }

        private void FormHardGame_KeyDown(object sender, KeyEventArgs e)
        {
            ////Move
            if (e.KeyData == Keys.Left || e.KeyData == Keys.Q)
                dir = Dir.Left;
            else if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
                dir = Dir.Right;
            else dir = Dir.None;

            ////Pause
            if (lblPause.Visible == false || lblPausee.Visible == false)
            {
                if (e.KeyData == Keys.Escape || e.KeyData == Keys.P)
                {
                    lblPausee.Visible = true;
                    lblPause.Visible = true;
                    timerAction.Enabled = false;
                }
            }
            else
            {
                if (e.KeyData == Keys.Escape || e.KeyData == Keys.P)
                {
                    lblPausee.Visible = false;
                    lblPause.Visible = false;
                    timerAction.Enabled = true;
                }
            }

            ////Game Over
            if (lblGameOver.Visible == true)
            {
                if (e.KeyData == Keys.Space || e.KeyData == Keys.Enter || e.KeyData == Keys.Escape || e.KeyData == Keys.P)
                {
                    lblPause.Visible = false;
                    lblPausee.Visible = false;
                    lblGameOver.Visible = false;
                    lblGameOverr.Visible = false;
                    timerAction.Enabled = true;
                    Player.Left = pnlGame.Width / 2;
                    score = 0;
                    ResponReplayCars14(car1, car2, car3, car4);
                    ResponReplayCars58(car5, car6, car7, car8);
                    speed = 7;
                }
            }

            ////Replay
            if (e.KeyData == Keys.R)
            {
                lblPause.Visible = false;
                lblPausee.Visible = false;
                lblGameOver.Visible = false;
                lblGameOverr.Visible = false;
                timerAction.Enabled = true;
                Player.Left = pnlGame.Width / 2;
                score = 0;
                ResponReplayCars14(car1, car2, car3, car4);
                ResponReplayCars58(car5, car6, car7, car8);
                speed = 7;
            }

            ////Modes
            if (e.KeyData == Keys.M)
            {
                this.Close();
                Form_Modes fm = new Form_Modes();
                fm.Show();
            }
        }
        private void FormHardGame_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.None;
        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            lblGameOverr.Visible = false;
            timerAction.Enabled = true;
            Player.Left = pnlGame.Width / 2;
            score = 0;
            ResponReplayCars14(car1, car2, car3, car4);
            ResponReplayCars58(car5, car6, car7, car8);
            speed = 6;
        }
    }
}
