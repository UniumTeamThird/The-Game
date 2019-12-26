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
            tabControl1.SelectedIndex = 1;
            
        }        
        private void button3_Click(object sender, EventArgs e)
        {
            FileStream olo = new FileStream("C:/Users/Ученик/Desktop/Новая папка (4)/putis.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(olo);
            olo.Seek(0,SeekOrigin.End);
            writer.WriteLine(textBox3.Text);
            writer.WriteLine(textBox4.Text);
            writer.Close();
            olo.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream olo = new FileStream("C:/Users/Ученик/Desktop/Новая папка (4)/putis.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(olo);
            while (!reader.EndOfStream)
            {
                
                string p = reader.ReadLine();
                int o = 0;
                if (p == textBox1.Text)
                {
                   o = 1;
                   p = reader.ReadLine();
                    
                    if (p == textBox2.Text)
                    {
                        
                        MessageBox.Show("вы вошли");
                        tabControl1.SelectedIndex = 2;                    
                        break;                        
                        
                    }
                    else 
                    {
                        MessageBox.Show("пароль не верный");
                    }
                    
                    
                } 
                if (o!= 1)
                {
                    MessageBox.Show("пользователь не найден");
                    break;
                }
            }
            reader.Close();
            olo.Close();

        }       
        int player1 = 0;
        int player2 = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 1;
            }
            else
            {
                player1 = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 2;
            }
            else
            {
                player1 = 2;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 3;
            }
            else
            {
                player1 = 3;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (player1 == 1 && player2 == 2)
            {
                MessageBox.Show("ПОБЕДИЛ 1 ИГРОК ");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 1 && player2 == 3)
            {
                MessageBox.Show("ПОБЕДИЛ 2 ИГРОК ");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 1 && player2 == 1)
            {
                MessageBox.Show("НИЧЬЯ");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 2 && player2 == 1)
            {
                MessageBox.Show("ПОБЕДИЛ 2 ИГРОК ");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 2 && player2 == 2)
            {
                MessageBox.Show("НИЧЬЯ");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 2 && player2 == 3)
            {
                MessageBox.Show("ПОБЕДИЛ 1 ИГРОК");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 3 && player2 == 3)
            {
                MessageBox.Show("НИЧЬЯ");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 3 && player2 == 1)
            {
                MessageBox.Show("ПОБЕДИЛ 1 ИГРОК");
                player1 = 0;
                player2 = 0;
            }
            else if (player1 == 3 && player2 == 2)
            {
                MessageBox.Show("ПОБЕДИЛ 2 ИГРОК");
                player1 = 0;
                player2 = 0;
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }    
        private void button6_Click(object sender, EventArgs e)
        {           

            textBox6.Text = textBox6.Text + " "+ textBox5.Text;
            textBox6.SelectionStart = textBox6.Text.Length;

            textBox6.ScrollToCaret();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 1;
            }
            else
            {
                player1 = 1;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 2;
            }
            else
            {
                player1 = 2;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (player1 > 0)
            {
                player2 = 3;
            }
            else
            {
                player1 = 3;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("qwerty");
            comboBox2.Items.Add("qwerty1");
            comboBox2.Items.Add("qwerty2");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("qwertyu");
            comboBox2.Items.Add("qwerty");
        }
    }
}

                                                                                                                                                                                                            