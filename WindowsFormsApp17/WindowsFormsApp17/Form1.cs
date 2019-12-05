using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 1;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FileStream olo = new FileStream("C:/Users/Ученик/Desktop/Новая папка (4)/putis.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(olo);
            olo.Seek(0, SeekOrigin.End);
            writer.WriteLine(textBox3.Text);
            writer.WriteLine(textBox4.Text);
            writer.Close();
            olo.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream olo = new FileStream("C:/Users/Ученик/Desktop/Новая папка (4)/putis.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(olo);
            while (!reader.EndOfStream)
            {

                string p = reader.ReadLine();
                if (p == textBox1.Text)
                {
                    p = reader.ReadLine();
                    if (p == textBox2.Text)
                    {
                        MessageBox.Show("вы вошли");
                        tabControl6.SelectedIndex = 2;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("пароль не верный");
                    }
                }
            }
            reader.Close();
            olo.Close();

        }
        int player1 = 0;
        int player2 = 0;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            if (player1 > 0)
            {
                player2 = 1;
                pictureBox1.Image = Properties.Resources.images6;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            else
            {
                player1 = 1;
                pictureBox4.Image = Properties.Resources.images10;
                pictureBox1.Image = Properties.Resources.images6;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 2;
                pictureBox2.Image = Properties.Resources.images5;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            else
            {
                player1 = 2;
                pictureBox4.Image = Properties.Resources.images10;
                pictureBox2.Image = Properties.Resources.images5;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 3;
                pictureBox3.Image = Properties.Resources.images4;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            else
            {
                player1 = 3;
                pictureBox4.Image = Properties.Resources.images10;
                pictureBox3.Image = Properties.Resources.images4;
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (player1 == 1 && player2 == 2)
            {
                MessageBox.Show("ПОБЕДИЛ 1 ИГРОК ");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 1 && player2 == 3)
            {
                MessageBox.Show("ПОБЕДИЛ 2 ИГРОК ");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 1 && player2 == 1)
            {
                MessageBox.Show("НИЧЬЯ");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 2 && player2 == 1)
            {
                MessageBox.Show("ПОБЕДИЛ 2 ИГРОК ");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 2 && player2 == 2)
            {
                MessageBox.Show("НИЧЬЯ");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 2 && player2 == 3)
            {
                MessageBox.Show("ПОБЕДИЛ 1 ИГРОК");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 3 && player2 == 3)
            {
                MessageBox.Show("НИЧЬЯ");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 3 && player2 == 1)
            {
                MessageBox.Show("ПОБЕДИЛ 1 ИГРОК");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            else if (player1 == 3 && player2 == 2)
            {
                MessageBox.Show("ПОБЕДИЛ 2 ИГРОК");
                player1 = 0;
                player2 = 0;
                pictureBox4.Image = Properties.Resources.images11;
                pictureBox1.Image = Properties.Resources.images2;
                pictureBox2.Image = Properties.Resources.images;
                pictureBox3.Image = Properties.Resources.images3;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Close();
        }
       

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox5.Text += textBox6.Text + Environment.NewLine;            
        }
    }
}
    

                                                                                                                                                                                                            