using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warcaby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iSize, green = 0, red = 0;
        PictureBox[,] picPlate;
        string color = "g", k = "", B1 = "", B2 = "", k2 = "";

        private void label4_Click(object sender, EventArgs e)
        {
            W.Visible = false;
            for (int h = 0; h < iSize; h++)
                for (int l = 0; l < iSize; l ++)
                {
                    if (h < (iSize / 2) - 1 && picPlate[h, l].BackColor == Color.Black) { picPlate[h, l].Image = Properties.Resources.r; picPlate[h, l].Name = h + " " + l + " r"; }
                    else if (h > (iSize / 2) && picPlate[h, l].BackColor == Color.Black)
                    {
                        picPlate[h, l].Image = Properties.Resources.g; picPlate[h, l].Name = h + " " + l + " g";
                    }
                    if (h == ((iSize / 2) - 1) || h == (iSize / 2)) picPlate[h, l].Image = null;
                }
            labelp1.Text = "0";
            labelp2.Text = "0";
            Player1.ReadOnly = false;
            Player2.ReadOnly = false;
            Player1.Text = "";
            Player2.Text = "";
            Player1.BackColor = Color.White;
            Player2.BackColor = Color.White;
            Player1.ForeColor = Color.Black;
            Player2.ForeColor = Color.Black;
            red = 0;
            green = 0;
        }

        private void Player1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBox t = sender as TextBox;
                if (t.Text != "" && Player1.Text != Player2.Text)
                { 
                    t.ReadOnly = true;
                    if (t.Name == "Player2")
                        t.BackColor = Color.Green;
                    else
                        t.BackColor = Color.Red;
                    t.ForeColor = Color.White;
                }
                else
                {
                    if (t.Text == "")
                        MessageBox.Show("Player Name can't be blank");
                    if (Player1.Text == Player2.Text)
                        MessageBox.Show("The players can't have the same name");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Parent = this;
            panel1.BringToFront();
            W.Visible = false;
            play.Click += (sender2, e2) =>
            {
                panel1.Visible = false;
            };
            play.MouseHover += (sender3, e3) =>
            {
                Label l = sender3 as Label;
                l.ForeColor = Color.Black;
                panel1.BackColor = Color.White;
            };
            play.MouseLeave += (sender3, e3) =>
            {
                Label l = sender3 as Label;
                l.ForeColor = Color.White;
                panel1.BackColor = Color.Black;
            };
            iSize = 8;
            picPlate = new PictureBox[iSize, iSize];
            int iLeft = 2, iTop = 2;
            Color[] colors = new Color[2];
            for(int i = 0; i < iSize; i++)
            {
                iLeft = 2;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[1] = Color.White; colors[0] = Color.Black; }
                for (int j = 0; j < iSize; j++)
                {
                    picPlate[i, j] = new PictureBox();
                    picPlate[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    picPlate[i, j].Location = new Point(iLeft, iTop);
                    picPlate[i, j].Size = new Size(60, 60);
                    iLeft += 60;
                    picPlate[i, j].Name = i + " " + j;
                    if (i < (iSize / 2) - 1 && picPlate[i, j].BackColor == Color.Black)
                    {
                        picPlate[i, j].Image = Properties.Resources.r;
                        picPlate[i, j].Name += " r";
                    }
                    else if (i > (iSize / 2) && picPlate[i, j].BackColor == Color.Black)
                    {
                        picPlate[i, j].Image = Properties.Resources.g;
                        picPlate[i, j].Name += " g";
                    }
                    picPlate[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    picPlate[i, j].MouseHover += (sender2, e2) =>
                    {
                        PictureBox pic = sender2 as PictureBox;
                        if (pic.Image != null) pic.BackColor = Color.FromArgb(255, 64, 64, 64);
                    };
                    picPlate[i, j].MouseLeave += (sender2, e2) =>
                    {
                        PictureBox pic = sender2 as PictureBox;
                        if (pic.Image != null) pic.BackColor = Color.Black;
                    };

                    picPlate[i, j].Click += (sender3, e3) =>
                    {
                        if (Player1.ReadOnly && Player2.ReadOnly)
                        {
                            PictureBox pic = sender3 as PictureBox;
                            if (pic.Image != null)
                            {
                                int c = -1, x, y;
                                F();

                                if (pic.Name.Split(' ')[2] == "b")
                                {
                                    if (color == "r") color = "g";
                                    else color = "r";
                                    x = Convert.ToInt32(k.Split(' ')[0]);
                                    y = Convert.ToInt32(k.Split(' ')[1]);
                                    B1 = "";
                                    B2 = "";
                                    if (k.Split(' ')[2] == "r")
                                    {
                                        pic.Image = Properties.Resources.r;
                                        pic.Name = pic.Name.Replace("b", "r");
                                    }
                                    else if (k.Split(' ')[2] == "g")
                                    {
                                        pic.Image = Properties.Resources.g;
                                        pic.Name = pic.Name.Replace("b", "g");
                                    }
                                    picPlate[x, y].Image = null;

                                    if (k2 != "")
                                    {
                                        x = Convert.ToInt32(k2.Split(' ')[0]);
                                        y = Convert.ToInt32(k2.Split(' ')[1]);
                                        picPlate[x, y].Image = null;
                                        if (k2.Split(' ')[2] == "r") red++;
                                        else green++;
                                        labelp1.Text = green + "";
                                        labelp2.Text = red + "";
                                        if (red >= 12)
                                        {
                                            labelw.Text = "You win " + Player2.Text;
                                            W.Visible = true;
                                        }
                                        else if (green >= 12)
                                        {
                                            labelw.Text = "You win " + Player1.Text;
                                            W.Visible = true;
                                        }
                                        k2 = "";
                                    }

                                }
                                else if (pic.Name.Split(' ')[2] == color)
                                {
                                    x = Convert.ToInt32(pic.Name.Split(' ')[0]);
                                    y = Convert.ToInt32(pic.Name.Split(' ')[1]);
                                    k = pic.Name;
                                    if (pic.Name.Split(' ')[2] == "r") c = 1;
                                    try
                                    {
                                        if (picPlate[x + c, y + 1].Image == null)
                                        {
                                            picPlate[x + c, y + 1].Image = Properties.Resources.b;
                                            picPlate[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " b";
                                            B1 = (x + c) + " " + (y + 1);
                                        }
                                        else if (picPlate[x + c, y + 1].Name.Split(' ')[2] != pic.Name.Split(' ')[2] && picPlate[x + (c * 2), y + 2].Image == null)
                                        {
                                            picPlate[x + (c * 2), y + 2].Image = Properties.Resources.b;
                                            picPlate[x + (c * 2), y + 2].Name = (x + (c * 2)) + " " + (y + 2) + " b";
                                            B1 = (x + (c * 2)) + " " + (y + 2);
                                            k2 = (x + c) + " " + (y + 1) + " " + picPlate[x + c, y + 1].Name.Split(' ')[2];
                                        }
                                    }
                                    catch { }

                                    try
                                    {
                                        if (picPlate[x + c, y - 1].Image == null)
                                        {
                                            picPlate[x + c, y - 1].Image = Properties.Resources.b;
                                            picPlate[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " b";
                                            B2 = (x + c) + " " + (y - 1);
                                        }
                                        else if (picPlate[x + c, y - 1].Name.Split(' ')[2] != pic.Name.Split(' ')[2] && picPlate[x + (c * 2), y - 2].Image == null)
                                        {
                                            picPlate[x + (c * 2), y - 2].Image = Properties.Resources.b;
                                            picPlate[x + (c * 2), y - 2].Name = (x + (c * 2)) + " " + (y - 2) + " b";
                                            B2 = (x + (c * 2)) + " " + (y - 2);
                                            k2 = (x + c) + " " + (y - 1) + " " + picPlate[x + c, y - 1].Name.Split(' ')[2];
                                        }
                                    }
                                    catch { }
                                }
                            }
                        }
                    };

                    picGround.Controls.Add(picPlate[i, j]);
                }
                iTop += 60;
            }
        }

        public void F()
        {
            if(B1 != "")
            {
                int x, y;
                x = Convert.ToInt32(B1.Split(' ')[0]);
                y = Convert.ToInt32(B1.Split(' ')[1]);
                picPlate[x, y].Image = null;
            }

            if (B2 != "")
            {
                int x, y;
                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                picPlate[x, y].Image = null;
            }
        }
    }
}
