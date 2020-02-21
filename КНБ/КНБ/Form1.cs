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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                ipTb.Enabled = true;
                startBt.Text = "Подключиться";
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                ipTb.Enabled = false;
                startBt.Text = "Создать сервер";
            }
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            Player.SetName(nameTb.Text);
            Player.SetStatus(comboBox1.Text, ipTb.Text);
            Player.SetRounds(int.Parse(roundsTb.Text));
            MessageBox.Show(Player.name + ", " + Player.status + ", " + Player.friendIP + ", " + Player.rounds);
            Game game = new Game();
            game.Show();
            this.Hide();
        }
    }
}
