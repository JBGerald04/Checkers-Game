
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
            this.label4 = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SFDeathCount = new System.Windows.Forms.Label();
            this.SSDeathCount = new System.Windows.Forms.Label();
            this.G.SuspendLayout();
            this.W.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Controls.Add(this.W);
            this.G.Location = new System.Drawing.Point(13, 11);
            this.G.Margin = new System.Windows.Forms.Padding(4);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(2140, 1476);
            this.G.TabIndex = 0;
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Gold;
            this.W.Controls.Add(this.label4);
            this.W.Controls.Add(this.labelw);
            this.W.Location = new System.Drawing.Point(611, 388);
            this.W.Margin = new System.Windows.Forms.Padding(4);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assessment_Task_2.Properties.Resources.g;
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
            this.pictureBox2.Image = global::Assessment_Task_2.Properties.Resources.r;
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
            // SSDeathCount
            // 
            this.SSDeathCount.AutoSize = true;
            this.SSDeathCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSDeathCount.ForeColor = System.Drawing.Color.Red;
            this.SSDeathCount.Location = new System.Drawing.Point(1088, 890);
            this.SSDeathCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSDeathCount.Name = "SSDeathCount";
            this.SSDeathCount.Size = new System.Drawing.Size(40, 42);
            this.SSDeathCount.TabIndex = 4;
            this.SSDeathCount.Text = "0";
            this.SSDeathCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1525, 1055);
            this.Controls.Add(this.SSDeathCount);
            this.Controls.Add(this.SFDeathCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Checkers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.G.ResumeLayout(false);
            this.W.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

