using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_Task_2
{
    public partial class Form1 : Form
    {
        // Variables
        int rows, SFCount, SSCount;
        PictureBox[,] pictureBoxes;
        string checker = "SF", checkerQ = "", lastCheckerClicked = "", rightMoveCoord = "", leftMoveCoord = "", killCoord = "", killCoord2 = "";
        private int _ticks;

        public Form1()
        {
            InitializeComponent();
            SwapPlayer(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GenerateCheckerBoard();
            W.Visible = false;
            for (int h = 0; h < rows; h++)
                for (int l = 0; l < rows; l++)
                {
                    if (h < (rows / 2) - 1 && pictureBoxes[h, l].BackColor == Color.Black) { pictureBoxes[h, l].Image = Properties.Resources.SS;pictureBoxes[h, 1].SizeMode = PictureBoxSizeMode.StretchImage; pictureBoxes[h, l].Name = h + " " + l + " SS"; }
                    else if (h > (rows / 2) && pictureBoxes[h, l].BackColor == Color.Black)
                    {
                        pictureBoxes[h, l].Image = Properties.Resources.SF; pictureBoxes[h, l].Name = h + " " + l + " SF";
                    }
                    if (h == ((rows / 2) - 1) || h == (rows / 2)) pictureBoxes[h, l].Image = null;
                }
            SFDeathCount.Text = "0";
            SSDeathCount.Text = "0";
            SSCount = 0;
            SFCount = 0;
        }

        private void Play_MouseHover(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = Color.Black;
            //panel1.BackColor = Color.White;
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateCheckerBoard();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // https://www.google.com/search?q=how+to+make+a+timer+in+c%23+winforms&rlz=1C1GCEA_enAU957AU957&oq=how+to+make+a+timer+in+c%23+winforms&aqs=chrome..69i57.16531j0j7&sourceid=chrome&{google:instantExtendedEnabledParameter}ie=UTF-8#kpvalbx=_2JEIYf2VJJm94-EP9rat6Ao44
        }

        private void Checker_Click(object sender, EventArgs e)
        {
            timer.Start();
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox.Image == null)
            {
                return;
            }
            int direction = -1, x, y;
            x = Convert.ToInt32(clickedPictureBox.Name.Split(' ')[0]);
            y = Convert.ToInt32(clickedPictureBox.Name.Split(' ')[1]);
            string player = clickedPictureBox.Name.Split(' ')[2];
            Why();

            // Check checker clicked was the correct colour for the current player
            if (player == checker || player == checkerQ)
            {
                lastCheckerClicked = clickedPictureBox.Name;
                if (player == "SS" || player == "SFQ")
                {
                    direction = 1;
                }
                if (player == "SF" || player == "SSQ")
                {
                    direction = -1;
                }
                // Highlight move option to the right.
                try
                {
                    if (pictureBoxes[x + direction, y + 1].Image == null)  //Normal move forward
                    {
                        pictureBoxes[x + direction, y + 1].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + direction, y + 1].Name = (x + direction) + " " + (y + 1) + " HLBlue";
                        rightMoveCoord = (x + direction) + " " + (y + 1);
                    }
                    // Checking if enemy is down right, highlight square after jump
                    else if (pictureBoxes[x + direction, y + 1].Name.Split(' ')[2] != player &&
                             pictureBoxes[x + (direction * 2), y + 2].Image == null)  //Jump forward 
                    {
                        pictureBoxes[x + (direction * 2), y + 2].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + (direction * 2), y + 2].Name = (x + (direction * 2)) + " " + (y + 2) + " HLBlue";
                        rightMoveCoord = (x + (direction * 2)) + " " + (y + 2);
                        killCoord = (x + direction) + " " + (y + 1) + " " + pictureBoxes[x + direction, y + 1].Name.Split(' ')[2];
                    }
                }
                catch { }
                // Highlight the option to the left
                try
                {
                    if (pictureBoxes[x + direction, y - 1].Image == null)
                    {
                        pictureBoxes[x + direction, y - 1].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + direction, y - 1].Name = (x + direction) + " " + (y - 1) + " HLBlue";
                        leftMoveCoord = (x + direction) + " " + (y - 1);
                    }
                    //  Checking if enemy is down left, highlight square after jump
                    else if (pictureBoxes[x + direction, y - 1].Name.Split(' ')[2] != player &&
                             pictureBoxes[x + (direction * 2), y - 2].Image == null)
                    {
                        pictureBoxes[x + (direction * 2), y - 2].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + (direction * 2), y - 2].Name = (x + (direction * 2)) + " " + (y - 2) + " HLBlue";
                        leftMoveCoord = (x + (direction * 2)) + " " + (y - 2);
                        killCoord = (x + direction) + " " + (y - 1) + " " + pictureBoxes[x + direction, y - 1].Name.Split(' ')[2];
                    }
                }
                catch { }
            }

            bool QHL = false;
            if (player == checkerQ)
            {
                if (player == "SSQ")
                {
                    direction = -1;
                }
                else if (player == "SFQ")
                {
                    direction = 1;
                }
                try
                {
                    QHL = true;
                    if (pictureBoxes[x + direction, y + 1].Image == null)  //Normal move forward
                    {
                        pictureBoxes[x + direction, y + 1].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + direction, y + 1].Name = (x + direction) + " " + (y + 1) + " HLBlue";
                        rightMoveCoord = (x + direction) + " " + (y + 1);
                    }
                    // Checking if enemy is down right, highlight square after jump
                    else if (pictureBoxes[x + direction, y + 1].Name.Split(' ')[2] != player &&
                             pictureBoxes[x + (direction * 2), y + 2].Image == null)  //Jump forward 
                    {
                        pictureBoxes[x + (direction * 2), y + 2].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + (direction * 2), y + 2].Name = (x + (direction * 2)) + " " + (y + 2) + " HLBlue";
                        rightMoveCoord = (x + (direction * 2)) + " " + (y + 2);
                        killCoord2 = (x + direction) + " " + (y + 1) + " " + pictureBoxes[x + direction, y + 1].Name.Split(' ')[2];
                    }
                }
                catch { }
                // Highlight the option to the left
                try
                {
                    if (pictureBoxes[x + direction, y - 1].Image == null)
                    {
                        pictureBoxes[x + direction, y - 1].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + direction, y - 1].Name = (x + direction) + " " + (y - 1) + " HLBlue";
                        leftMoveCoord = (x + direction) + " " + (y - 1);
                    }
                    //  Checking if enemy is down left, highlight square after jump
                    else if (pictureBoxes[x + direction, y - 1].Name.Split(' ')[2] != player &&
                             pictureBoxes[x + (direction * 2), y - 2].Image == null)
                    {
                        pictureBoxes[x + (direction * 2), y - 2].Image = Properties.Resources.HLBlue;
                        pictureBoxes[x + (direction * 2), y - 2].Name = (x + (direction * 2)) + " " + (y - 2) + " HLBlue";
                        leftMoveCoord = (x + (direction * 2)) + " " + (y - 2);
                        killCoord2 = (x + direction) + " " + (y - 1) + " " + pictureBoxes[x + direction, y - 1].Name.Split(' ')[2];
                    }
                }
                catch { }
            }
            //Check if the player chose to move
            else if (player == "HLBlue")
            {
                SwapPlayer(false);
                x = Convert.ToInt32(lastCheckerClicked.Split(' ')[0]);
                y = Convert.ToInt32(lastCheckerClicked.Split(' ')[1]);
                player = lastCheckerClicked.Split(' ')[2];
                rightMoveCoord = "";
                leftMoveCoord = "";

                // Move SeaShell checker
                if (player == "SS")
                {
                    clickedPictureBox.Image = Properties.Resources.SS;
                    clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    clickedPictureBox.Name = clickedPictureBox.Name.Replace("HLBlue", "SS");
                }
                // Move Starfish checker
                else if (player == "SF")
                {
                    clickedPictureBox.Image = Properties.Resources.SF;
                    clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    clickedPictureBox.Name = clickedPictureBox.Name.Replace("HLBlue", "SF");
                }

                // Delete original checker
                pictureBoxes[x, y].Image = null;

                int originalX = Convert.ToInt32(clickedPictureBox.Name.Split(' ')[0]);
                int originalY = Convert.ToInt32(clickedPictureBox.Name.Split(' ')[1]);
                string originalPlayer = clickedPictureBox.Name.Split(' ')[2];
                bool Queen = false;

                // Check if they are kingable?
                if (player == "SS" && originalX == 7)
                {
                    MessageBox.Show("SS has reached the bottom");
                    pictureBoxes[originalX, originalY].Image = Properties.Resources.SSQ;
                    Queen = true;
                }
                if (player == "SF" && originalX == 0)
                {
                    MessageBox.Show("SF has reached the top");
                    pictureBoxes[originalX, originalY].Image = Properties.Resources.SFQ;
                    Queen = true;
                }


                // Are we killing another checker?
                if (killCoord != "" || killCoord2 != "")
                {
                    int killX = Convert.ToInt32(killCoord.Split(' ')[0]);
                    int killY = Convert.ToInt32(killCoord.Split(' ')[1]);
                    string killPlayer = killCoord.Split(' ')[2];
                    int killX2 = 0, killY2 = 0;
                    string killPlayer2;


                    if (Queen == true && QHL == true)
                    {
                        killX2 = Convert.ToInt32(killCoord2.Split(' ')[0]);
                        killY2 = Convert.ToInt32(killCoord2.Split(' ')[1]);
                        killPlayer2 = killCoord2.Split(' ')[2];
                    }



                    // If the coord has less than 2 spaces, there is no kill
                    if (Math.Abs(originalY - y) < 2)
                    {
                        return;
                    }
                    SwapPlayer(true);
                    pictureBoxes[killX, killY].Image = null;
                    if (Queen == true && QHL == true)
                    {
                        pictureBoxes[killX2, killY2].Image = null;
                        if (killCoord2.Split(' ')[2] == "SS")
                        {
                            SSCount++;
                        }
                        else if (killCoord2.Split(' ')[2] == "SF")
                        {
                            SFCount++;
                        }
                    }
                    if (killCoord.Split(' ')[2] == "SS")
                    {
                        SSCount++;
                    }
                    else if (killCoord.Split(' ')[2] == "SF")
                    {
                        SFCount++;
                    }
                    SSDeathCount.Text = SSCount + "";
                    SFDeathCount.Text = SFCount + "";
                    if (SSCount >= 12)
                    {
                        labelw.Text += "You Win ";
                        W.Visible = true;
                    }
                    else if (SFCount >= 12)
                    {
                        labelw.Text = "You Win ";
                        W.Visible = true;
                    }
                    killCoord = "";
                }
            }
        }

        private void SwapPlayer(bool jump)
        {
            if (checker == "SS" || checkerQ == "SSQ")
            {
                checker = "SF";
                checkerQ = "SFQ";
                PlayerTurn.Image = Properties.Resources.SF;
            }
            else if (checker == "SF" || checkerQ == "SFQ")
            {
                checker = "SS";
                checkerQ = "SSQ";
                PlayerTurn.Image = Properties.Resources.SS;
            }
            //if (jump == true)
            //{
                
            //}
            //else if (jump == false)
            //{

            //}
        }

        private void Checker_MouseHover(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p.Image != null) p.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void Checker_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p.Image != null) p.BackColor = Color.CadetBlue;
        }

        private void GenerateCheckerBoard()
        {
            rows = 8;
            pictureBoxes = new PictureBox[rows, rows];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };

            for (int x = 0; x < rows; x++)
            {
                left = 2;
                if (x % 2 == 0) { colors[0] = Color.FloralWhite; colors[1] = Color.CadetBlue; }
                else { colors[0] = Color.CadetBlue; colors[1] = Color.FloralWhite; }
                for (int y = 0; y < rows; y++)
                {
                    pictureBoxes[x, y] = new PictureBox();
                    pictureBoxes[x, y].BackColor = colors[(y % 2 == 0) ? 1 : 0];
                    pictureBoxes[x, y].Location = new Point(left, top);
                    pictureBoxes[x, y].Size = new Size(100, 100);
                    left += 100;
                    pictureBoxes[x, y].Name = x + " " + y;
                    if (x < (rows / 2) - 1 && pictureBoxes[x, y].BackColor == Color.CadetBlue) { pictureBoxes[x, y].Image = Properties.Resources.SS; pictureBoxes[x, y].Name += " SS"; }
                    else if (x > (rows / 2) && pictureBoxes[x, y].BackColor == Color.CadetBlue) { pictureBoxes[x, y].Image = Properties.Resources.SF; pictureBoxes[x, y].Name += " SF"; }
                    pictureBoxes[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxes[x, y].MouseHover += Checker_MouseHover;
                    pictureBoxes[x, y].MouseLeave += Checker_MouseLeave;

                    pictureBoxes[x, y].Click += Checker_Click;
                    G.Controls.Add(pictureBoxes[x, y]);
                }
                top += 100;
            }
        }

        public void Why()
        {
            if (rightMoveCoord != "")
            {
                int x, y;
                x = Convert.ToInt32(rightMoveCoord.Split(' ')[0]);
                y = Convert.ToInt32(rightMoveCoord.Split(' ')[1]);
                pictureBoxes[x, y].Image = null;
            }
            if (leftMoveCoord != "")
            {
                int x, y;
                x = Convert.ToInt32(leftMoveCoord.Split(' ')[0]);
                y = Convert.ToInt32(leftMoveCoord.Split(' ')[1]);
                pictureBoxes[x, y].Image = null;
            }
        }
    }
}