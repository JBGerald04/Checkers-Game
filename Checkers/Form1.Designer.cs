
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
            this.W = new System.Windows.Forms.Panel();
            this.LbPlay = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.SSDeathCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SFDeathCount = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.PictureBox();
            this.labPlayerTurn = new System.Windows.Forms.Label();
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
            this.G.Location = new System.Drawing.Point(13, 11);
            this.G.Margin = new System.Windows.Forms.Padding(4);
            this.G.MaximumSize = new System.Drawing.Size(1080, 997);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(0, 0);
            this.G.TabIndex = 0;
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Gold;
            this.W.Controls.Add(this.LbPlay);
            this.W.Controls.Add(this.labelw);
            this.W.Controls.Add(this.SSDeathCount);
            this.W.Location = new System.Drawing.Point(0, 0);
            this.W.Margin = new System.Windows.Forms.Padding(4);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(1645, 1029);
            this.W.TabIndex = 0;
            this.W.Visible = false;
            // 
            // LbPlay
            // 
            this.LbPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LbPlay.ForeColor = System.Drawing.Color.White;
            this.LbPlay.Location = new System.Drawing.Point(519, 277);
            this.LbPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPlay.Name = "LbPlay";
            this.LbPlay.Size = new System.Drawing.Size(215, 62);
            this.LbPlay.TabIndex = 1;
            this.LbPlay.Text = "Play again";
            this.LbPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbPlay.Click += new System.EventHandler(this.LbPlay_Click);
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
            // SSDeathCount
            // 
            this.SSDeathCount.AutoSize = true;
            this.SSDeathCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSDeathCount.ForeColor = System.Drawing.Color.Red;
            this.SSDeathCount.Location = new System.Drawing.Point(1163, 954);
            this.SSDeathCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSDeathCount.Name = "SSDeathCount";
            this.SSDeathCount.Size = new System.Drawing.Size(40, 42);
            this.SSDeathCount.TabIndex = 4;
            this.SSDeathCount.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1088, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1088, 934);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // SFDeathCount
            // 
            this.SFDeathCount.AutoSize = true;
            this.SFDeathCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFDeathCount.ForeColor = System.Drawing.Color.Green;
            this.SFDeathCount.Location = new System.Drawing.Point(1163, 11);
            this.SFDeathCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SFDeathCount.Name = "SFDeathCount";
            this.SFDeathCount.Size = new System.Drawing.Size(40, 42);
            this.SFDeathCount.TabIndex = 3;
            this.SFDeathCount.Text = "0";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.Location = new System.Drawing.Point(1496, 187);
            this.PlayerTurn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(133, 123);
            this.PlayerTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTurn.TabIndex = 5;
            this.PlayerTurn.TabStop = false;
            // 
            // labPlayerTurn
            // 
            this.labPlayerTurn.AutoSize = true;
            this.labPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayerTurn.Location = new System.Drawing.Point(1491, 159);
            this.labPlayerTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPlayerTurn.Name = "labPlayerTurn";
            this.labPlayerTurn.Size = new System.Drawing.Size(134, 26);
            this.labPlayerTurn.TabIndex = 6;
            this.labPlayerTurn.Text = "Players Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1645, 1029);
            this.Controls.Add(this.labPlayerTurn);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.SFDeathCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G);
            this.Controls.Add(this.W);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.W.ResumeLayout(false);
            this.W.PerformLayout();
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
        private System.Windows.Forms.Label LbPlay;
        private System.Windows.Forms.PictureBox PlayerTurn;
        private System.Windows.Forms.Label labPlayerTurn;
    }
}

