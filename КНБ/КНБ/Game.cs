using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КНБ
{
    public partial class Game : Form
    {
        bool rock = false, scis = false, paper = false;

        public void Choice(int ch)
        {
            if(ch == 0)
            {
                rock = true;
                scis = false;
                paper = false;               
            }
            else if(ch == 1)
            {
                rock = false;
                scis = true;
                paper = false;
            }
            else if (ch == 2)
            {
                rock = false;
                scis = false;
                paper = true;
            }
        }

        public int WhatTurn()
        {
            if (rock == true)
            {
                return 0;
            }
            else if (scis == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public Game()
        {
            InitializeComponent();
        }



        private void rockPb_Click(object sender, EventArgs e)
        {
            rockPb.Image = Properties.Resources.камень1;
            scisPb.Image = Properties.Resources.ножницы;
            paperPb.Image = Properties.Resources.бумага;
            Choice(0);
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void SetWinner(int result)
        {
            if(result == 0)
            {
                label1.Text = "Ничья!";
            }
            else if(result == 1)
            {
                label1.Text = "Ты победил!";
            }
            else
            {
                label1.Text = "Ты проиграл!";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Player.status == 0)
            {
                label1.Text = "Ожидаем хода другого игрока!";
               SetWinner(Player.GetAndAnswer(WhatTurn()));
            }
            else
            {
                label1.Text = "Ожидаем хода другого игрока!"; 
                SetWinner(Player.SendAndGet(WhatTurn()));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatTbMl.Text += Player.name + ": " + textTb.Text + Environment.NewLine;
            textTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChatTbMl.Text = "";
        }

        private void scisPb_Click(object sender, EventArgs e)
        {
            rockPb.Image = Properties.Resources.камень;
            scisPb.Image = Properties.Resources.ножницы1;
            paperPb.Image = Properties.Resources.бумага;
            Choice(1);
        }

        private void paperPb_Click(object sender, EventArgs e)
        {
            rockPb.Image = Properties.Resources.камень;
            scisPb.Image = Properties.Resources.ножницы;
            paperPb.Image = Properties.Resources.бумага1;
            Choice(2);
        }
    }
}
