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
    public partial class Form_Modes : Form
    {
        public Form_Modes()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNormalMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Normal_Mode FNG = new Form_Normal_Mode();
            FNG.Show();
        }


        private void btnHardMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Hard_Mode fhg = new Form_Hard_Mode();
            fhg.Show();
        }

        private void btnNormalSpeedMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Speed_Mode fsg = new Form_Speed_Mode();
            fsg.Show();
        }

        private void btnHardSpeedMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Hard_Speed_Mode fhsg = new Form_Hard_Speed_Mode();
            fhsg.Show();
        }

        private void btnMoveMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Move_Mode fmm = new Form_Move_Mode();
            fmm.Show();
        }

        private void btnHardMoveMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Hard_Move_Mode fhmm = new Form_Hard_Move_Mode();
            fhmm.Show();
        }
    }
}
