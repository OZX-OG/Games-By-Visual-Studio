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
    public partial class Form_Speed_Mode : Form
    {
        public Form_Speed_Mode()
        {
            InitializeComponent();
        }
        enum Dir { Right, Left, Up, None }

        int speed = 6;
        int score = 0;
        int scoreClient = 0;
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

            scoreClient = speed - 5;
            score++;
            lblScore.Text = "Score: " + score;
            lblspeed.Text = "Speed: " + scoreClient;



            ////Tatch Player
            if (Player.Bounds.IntersectsWith(car1.Bounds) || Player.Bounds.IntersectsWith(car2.Bounds))
            {
                timerAction.Enabled = false;
                lblGameOverr.Visible = true;
                lblGameOver.Visible = true;
                TopScore = score;
                if (TopScore > score) lblTopScore.Text = "Last Score: " + TopScore;
                else lblTopScore.Text = "Last Score: " + TopScore;
            }

            ///Mech move
            if (dir == Dir.Left && Player.Left > 0)
                Player.Left -= speed;
            if (dir == Dir.Right && Player.Left < pnlGame.Width - Player.Width)
                Player.Left += speed;
        }

        private void FormSpeedGame_KeyDown(object sender, KeyEventArgs e)
        {
            ////Move
            if (e.KeyData == Keys.Left || e.KeyData == Keys.Q)
                dir = Dir.Left;
            else if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
                dir = Dir.Right;
            else if (e.KeyData == Keys.Up || e.KeyData == Keys.Z)
            {
                if (speed < 20) speed += 1;
                else speed = 20;
            }
            else if (e.KeyData == Keys.Down || e.KeyData == Keys.S)
            {
                if (speed > 2) speed -= 1;
                else speed = 2;

            }
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
                Player.Left = pnlGame.Width / 2;
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

        private void FormSpeedGame_KeyUp(object sender, KeyEventArgs e)
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
            car1.Left = 0;
            car2.Left = pnlGame.Height - car2.Width;
            speed = 6;
        }
    }
}
