namespace learn_english
{
    partial class Form1
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
            this.btn_next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_ans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_rightAns = new System.Windows.Forms.Label();
            this.lbl_AllAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(265, 321);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(209, 43);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Start";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "write arabic words in english";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_ans
            // 
            this.txtbox_ans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtbox_ans.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ans.ForeColor = System.Drawing.Color.White;
            this.txtbox_ans.Location = new System.Drawing.Point(149, 201);
            this.txtbox_ans.Name = "txtbox_ans";
            this.txtbox_ans.Size = new System.Drawing.Size(456, 30);
            this.txtbox_ans.TabIndex = 2;
            this.txtbox_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_ans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_ans_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "right Answer:";
            // 
            // lbl_q
            // 
            this.lbl_q.Font = new System.Drawing.Font("Century", 14F);
            this.lbl_q.Location = new System.Drawing.Point(151, 127);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(437, 39);
            this.lbl_q.TabIndex = 4;
            this.lbl_q.Text = "- Press Enter to start -";
            this.lbl_q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_a
            // 
            this.lbl_a.Font = new System.Drawing.Font("Century", 14F);
            this.lbl_a.Location = new System.Drawing.Point(151, 254);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(437, 39);
            this.lbl_a.TabIndex = 5;
            this.lbl_a.Text = "0";
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rightAns
            // 
            this.lbl_rightAns.AutoSize = true;
            this.lbl_rightAns.Location = new System.Drawing.Point(2, 103);
            this.lbl_rightAns.Name = "lbl_rightAns";
            this.lbl_rightAns.Size = new System.Drawing.Size(119, 20);
            this.lbl_rightAns.TabIndex = 6;
            this.lbl_rightAns.Text = "right answer: 0";
            // 
            // lbl_AllAns
            // 
            this.lbl_AllAns.AutoSize = true;
            this.lbl_AllAns.Location = new System.Drawing.Point(22, 127);
            this.lbl_AllAns.Name = "lbl_AllAns";
            this.lbl_AllAns.Size = new System.Drawing.Size(99, 20);
            this.lbl_AllAns.TabIndex = 7;
            this.lbl_AllAns.Text = "All Words: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(739, 376);
            this.Controls.Add(this.txtbox_ans);
            this.Controls.Add(this.lbl_AllAns);
            this.Controls.Add(this.lbl_rightAns);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_q);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_next);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn English - by: OZX-OG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_rightAns;
        private System.Windows.Forms.Label lbl_AllAns;
    }
}

