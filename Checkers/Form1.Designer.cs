
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
            this.components = new System.ComponentModel.Container();
            this.G = new System.Windows.Forms.Panel();
            this.W = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SFDeathCount = new System.Windows.Forms.Label();
            this.SSDeathCount = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.PictureBox();
            this.labPlayerTurn = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.W.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(10, 9);
            this.G.MaximumSize = new System.Drawing.Size(810, 810);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(0, 0);
            this.G.TabIndex = 0;
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Gold;
            this.W.Controls.Add(this.label4);
            this.W.Controls.Add(this.labelw);
            this.W.Location = new System.Drawing.Point(362, 129);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(137, 204);
            this.W.TabIndex = 0;
            this.W.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(389, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Play again";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelw
            // 
            this.labelw.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.labelw.ForeColor = System.Drawing.Color.White;
            this.labelw.Location = new System.Drawing.Point(215, 150);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(482, 75);
            this.labelw.TabIndex = 0;
            this.labelw.Text = "You Win";
            this.labelw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(816, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(816, 759);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // SFDeathCount
            // 
            this.SFDeathCount.AutoSize = true;
            this.SFDeathCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFDeathCount.ForeColor = System.Drawing.Color.Green;
            this.SFDeathCount.Location = new System.Drawing.Point(872, 9);
            this.SFDeathCount.Name = "SFDeathCount";
            this.SFDeathCount.Size = new System.Drawing.Size(32, 33);
            this.SFDeathCount.TabIndex = 3;
            this.SFDeathCount.Text = "0";
            // 
            // SSDeathCount
            // 
            this.SSDeathCount.AutoSize = true;
            this.SSDeathCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSDeathCount.ForeColor = System.Drawing.Color.Red;
            this.SSDeathCount.Location = new System.Drawing.Point(816, 723);
            this.SSDeathCount.Name = "SSDeathCount";
            this.SSDeathCount.Size = new System.Drawing.Size(32, 33);
            this.SSDeathCount.TabIndex = 4;
            this.SSDeathCount.Text = "0";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.Location = new System.Drawing.Point(1122, 152);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(100, 100);
            this.PlayerTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTurn.TabIndex = 5;
            this.PlayerTurn.TabStop = false;
            // 
            // labPlayerTurn
            // 
            this.labPlayerTurn.AutoSize = true;
            this.labPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayerTurn.Location = new System.Drawing.Point(1118, 129);
            this.labPlayerTurn.Name = "labPlayerTurn";
            this.labPlayerTurn.Size = new System.Drawing.Size(104, 20);
            this.labPlayerTurn.TabIndex = 6;
            this.labPlayerTurn.Text = "Players Turn";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1234, 836);
            this.Controls.Add(this.labPlayerTurn);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.SSDeathCount);
            this.Controls.Add(this.SFDeathCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G);
            this.Controls.Add(this.W);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.W.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SFDeathCount;
        private System.Windows.Forms.Label SSDeathCount;
        private System.Windows.Forms.Panel W;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PlayerTurn;
        private System.Windows.Forms.Label labPlayerTurn;
        private System.Windows.Forms.Timer timer;
    }
}

