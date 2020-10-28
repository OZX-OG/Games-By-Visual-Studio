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
    public partial class Form_Move_Mode : Form
    {
        public Form_Move_Mode()
        {
            InitializeComponent();
        }

        enum Dir { Right, Left, Up, Down, None }

        int speed = 6;
        int score = 0;
        int TopScore = 0;
        Dir dir = Dir.None;
        Random r = new Random();

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


            if (car1.Visible)
                car1.Top += speed;
            if (car1.Top > pnlGame.Height)
            {
                car1.Visible = false;
                car1.Top = -car1.Height;
                car1.Left = r.Next((pnlGame.Width - car1.Width) / 2);
                int car = r.Next(1, 6);
                if (car == 1) car1.Image = Properties.Resources.car1;
                else if (car == 2) car1.Image = Properties.Resources.car2;
                else if (car == 3) car1.Image = Properties.Resources.car3;
                else if (car == 4) car1.Image = Properties.Resources.car4;
                else car1.Image = Properties.Resources.car5;
                car1.Visible = true;
            }

            if (car2.Visible)
                car2.Top += speed;
            if (car2.Top > pnlGame.Height)
            {
                car2.Visible = false;
                car2.Top = -car2.Height;
                car2.Left = r.Next(pnlGame.Width / 2, pnlGame.Width - car2.Width);
                int car = r.Next(1, 6);
                if (car == 1) car2.Image = Properties.Resources.car1;
                else if (car == 2) car2.Image = Properties.Resources.car2;
                else if (car == 3) car2.Image = Properties.Resources.car3;
                else if (car == 4) car2.Image = Properties.Resources.car4;
                else car2.Image = Properties.Resources.car5;
                car2.Visible = true;
            }

            score++;
            if (score > 1000) speed = 7;
            if (score > 2000) speed = 8;
            if (score > 3000) speed = 9;
            if (score > 4000) speed = 10;
            if (score > 5000) speed = 11;
            if (score > 6000) speed = 12;
            if (score > 7000) speed = 13;
            if (score > 8000) speed = 14;
            if (score > 9000) speed = 15;
            if (score > 10000) speed = 16;
            lblScore.Text = "Score: " + score;
            lblspeed.Text = "Speed: " + (speed - 5);




            if (Player.Bounds.IntersectsWith(car1.Bounds) || Player.Bounds.IntersectsWith(car2.Bounds))
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
            if (dir == Dir.Up && Player.Top > 75)
                Player.Top -= speed;
            if (dir == Dir.Down && Player.Bottom < (pnlGame.Height - Player.Height) + 70) 
                Player.Top += speed;
        }

        private void Form_Move_Mode_KeyDown(object sender, KeyEventArgs e)
        {
            ////Move
            if (e.KeyData == Keys.Left || e.KeyData == Keys.Q)
                dir = Dir.Left;
            else if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
                dir = Dir.Right;
            else if (e.KeyData == Keys.Up || e.KeyData == Keys.Z)
                dir = Dir.Up;
            else if (e.KeyData == Keys.Down || e.KeyData == Keys.S)
                dir = Dir.Down;
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
                    Player.Location = new Point(220, 356);
                    score = 0;
                    car1.Left = 0;
                    car2.Left = pnlGame.Height - car2.Width;
                    speed = 6;
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
                Player.Location = new Point(220, 356);
                score = 0;
                car1.Left = 0;
                car2.Left = pnlGame.Height - car2.Width;
                speed = 6;
            }

            ////Modes
            if (e.KeyData == Keys.M)
            {
                this.Close();
                Form_Modes fm = new Form_Modes();
                fm.Show();
            }
        }

        private void Form_Move_Mode_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.None;
        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            lblGameOverr.Visible = false;
            timerAction.Enabled = true;
            Player.Location = new Point(220, 356);
            score = 0;
            car1.Left = 0;
            car2.Left = pnlGame.Height - car2.Width;
            speed = 6;
        }
    }
}
