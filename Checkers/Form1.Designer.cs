
namespace Assessment_Task_2
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
            this.G = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelp1 = new System.Windows.Forms.Label();
            this.labelp2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.G.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.W.SuspendLayout();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Controls.Add(this.W);
            this.G.Location = new System.Drawing.Point(13, 11);
            this.G.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(2140, 1476);
            this.G.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assessment_Task_2.Properties.Resources.g;
            this.pictureBox1.Location = new System.Drawing.Point(1088, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assessment_Task_2.Properties.Resources.r;
            this.pictureBox2.Location = new System.Drawing.Point(1088, 934);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelp1
            // 
            this.labelp1.AutoSize = true;
            this.labelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp1.ForeColor = System.Drawing.Color.Green;
            this.labelp1.Location = new System.Drawing.Point(1163, 11);
            this.labelp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelp1.Name = "labelp1";
            this.labelp1.Size = new System.Drawing.Size(40, 42);
            this.labelp1.TabIndex = 3;
            this.labelp1.Text = "0";
            // 
            // labelp2
            // 
            this.labelp2.AutoSize = true;
            this.labelp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelp2.ForeColor = System.Drawing.Color.Red;
            this.labelp2.Location = new System.Drawing.Point(1088, 890);
            this.labelp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelp2.Name = "labelp2";
            this.labelp2.Size = new System.Drawing.Size(40, 42);
            this.labelp2.TabIndex = 4;
            this.labelp2.Text = "0";
            this.labelp2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(1163, 964);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1225, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 1";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Player1.Location = new System.Drawing.Point(1355, 43);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(132, 37);
            this.Player1.TabIndex = 7;
            this.Player1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Player1_KeyPress);
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Player2.Location = new System.Drawing.Point(1292, 958);
            this.Player2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(132, 37);
            this.Player2.TabIndex = 8;
            this.Player2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Player1_KeyPress);
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Gold;
            this.W.Controls.Add(this.label4);
            this.W.Controls.Add(this.labelw);
            this.W.Location = new System.Drawing.Point(611, 388);
            this.W.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(1525, 1084);
            this.W.TabIndex = 0;
            this.W.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(519, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 62);
            this.label4.TabIndex = 1;
            this.label4.Text = "Play again";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelw
            // 
            this.labelw.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.labelw.ForeColor = System.Drawing.Color.White;
            this.labelw.Location = new System.Drawing.Point(287, 185);
            this.labelw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(643, 92);
            this.labelw.TabIndex = 0;
            this.labelw.Text = "You Win";
            this.labelw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1525, 1055);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelp2);
            this.Controls.Add(this.labelp1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Checkers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.G.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.W.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelp1;
        private System.Windows.Forms.Label labelp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.Panel W;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Label label4;
    }
}

