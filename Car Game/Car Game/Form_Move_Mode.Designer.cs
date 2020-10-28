namespace Car_Game
{
    partial class Form_Move_Mode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPausee = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblGameOverr = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.L6 = new System.Windows.Forms.PictureBox();
            this.lblspeed = new System.Windows.Forms.Label();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.L5 = new System.Windows.Forms.PictureBox();
            this.L4 = new System.Windows.Forms.PictureBox();
            this.L3 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.PictureBox();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.PictureBox();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(50, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "R: Replay               P - ESP: To Pause               M: Exit and Change Mode  " +
    "             ";
            // 
            // lblPausee
            // 
            this.lblPausee.AutoSize = true;
            this.lblPausee.BackColor = System.Drawing.Color.DarkGray;
            this.lblPausee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPausee.ForeColor = System.Drawing.Color.White;
            this.lblPausee.Location = new System.Drawing.Point(164, 232);
            this.lblPausee.Name = "lblPausee";
            this.lblPausee.Size = new System.Drawing.Size(118, 13);
            this.lblPausee.TabIndex = 12;
            this.lblPausee.Text = "Press ESP To Continue";
            this.lblPausee.Visible = false;
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.DarkGray;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(146, 198);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(161, 49);
            this.lblPause.TabIndex = 11;
            this.lblPause.Text = "Pause\r\n\r\n";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPause.Visible = false;
            // 
            // lblGameOverr
            // 
            this.lblGameOverr.AutoSize = true;
            this.lblGameOverr.BackColor = System.Drawing.Color.DarkGray;
            this.lblGameOverr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGameOverr.ForeColor = System.Drawing.Color.White;
            this.lblGameOverr.Location = new System.Drawing.Point(139, 232);
            this.lblGameOverr.Name = "lblGameOverr";
            this.lblGameOverr.Size = new System.Drawing.Size(195, 13);
            this.lblGameOverr.TabIndex = 10;
            this.lblGameOverr.Text = "You Can Press Enter or Space To playe";
            this.lblGameOverr.Visible = false;
            this.lblGameOverr.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.DarkGray;
            this.lblGameOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(138, 195);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(197, 55);
            this.lblGameOver.TabIndex = 9;
            this.lblGameOver.Text = "Game Over\r\n";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::Car_Game.Properties.Resources.car5;
            this.car2.Location = new System.Drawing.Point(347, 160);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(38, 75);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car2.TabIndex = 8;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::Car_Game.Properties.Resources.car2;
            this.car1.Location = new System.Drawing.Point(100, 28);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(38, 75);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car1.TabIndex = 7;
            this.car1.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Car_Game.Properties.Resources.car0;
            this.Player.InitialImage = null;
            this.Player.Location = new System.Drawing.Point(220, 356);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(38, 75);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 6;
            this.Player.TabStop = false;
            this.Player.Tag = "0";
            // 
            // L6
            // 
            this.L6.BackColor = System.Drawing.Color.White;
            this.L6.Location = new System.Drawing.Point(378, 272);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(10, 143);
            this.L6.TabIndex = 5;
            this.L6.TabStop = false;
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeed.Location = new System.Drawing.Point(400, 45);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(86, 24);
            this.lblspeed.TabIndex = 8;
            this.lblspeed.Text = "Speed: 6";
            // 
            // timerAction
            // 
            this.timerAction.Enabled = true;
            this.timerAction.Interval = 1;
            this.timerAction.Tick += new System.EventHandler(this.timerAction_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(206, 45);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 24);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            // 
            // L5
            // 
            this.L5.BackColor = System.Drawing.Color.White;
            this.L5.Location = new System.Drawing.Point(378, 29);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(10, 143);
            this.L5.TabIndex = 4;
            this.L5.TabStop = false;
            // 
            // L4
            // 
            this.L4.BackColor = System.Drawing.Color.White;
            this.L4.Location = new System.Drawing.Point(231, 272);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(10, 143);
            this.L4.TabIndex = 3;
            this.L4.TabStop = false;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.White;
            this.L3.Location = new System.Drawing.Point(231, 29);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(10, 143);
            this.L3.TabIndex = 2;
            this.L3.TabStop = false;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(84, 29);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(10, 143);
            this.L1.TabIndex = 0;
            this.L1.TabStop = false;
            // 
            // lblTopScore
            // 
            this.lblTopScore.AutoSize = true;
            this.lblTopScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScore.Location = new System.Drawing.Point(10, 45);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(118, 24);
            this.lblTopScore.TabIndex = 9;
            this.lblTopScore.Text = "Last Score: 0";
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(84, 272);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(10, 143);
            this.L2.TabIndex = 1;
            this.L2.TabStop = false;
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGame.BackColor = System.Drawing.Color.Black;
            this.pnlGame.Controls.Add(this.lblPausee);
            this.pnlGame.Controls.Add(this.lblPause);
            this.pnlGame.Controls.Add(this.lblGameOverr);
            this.pnlGame.Controls.Add(this.lblGameOver);
            this.pnlGame.Controls.Add(this.car2);
            this.pnlGame.Controls.Add(this.car1);
            this.pnlGame.Controls.Add(this.Player);
            this.pnlGame.Controls.Add(this.L6);
            this.pnlGame.Controls.Add(this.L5);
            this.pnlGame.Controls.Add(this.L4);
            this.pnlGame.Controls.Add(this.L3);
            this.pnlGame.Controls.Add(this.L2);
            this.pnlGame.Controls.Add(this.L1);
            this.pnlGame.Location = new System.Drawing.Point(14, 72);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(472, 450);
            this.pnlGame.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(128, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Up or Z: To Go Up          Down or S: to GO Down";
            // 
            // Form_Move_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblspeed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTopScore);
            this.Controls.Add(this.pnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Move_Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Move_Mode";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Move_Mode_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Move_Mode_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPausee;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblGameOverr;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox L6;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox L5;
        private System.Windows.Forms.PictureBox L4;
        private System.Windows.Forms.PictureBox L3;
        private System.Windows.Forms.PictureBox L1;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.PictureBox L2;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label2;
    }
}