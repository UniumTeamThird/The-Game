using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace КНБ
{
    public partial class Form1 : Form
    {
        public static string name;
        public static int status;
        public static string friendIP;
        public static int rounds;
        public static int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        static TcpListener listener;

        public Form1()
        {
            InitializeComponent();
            roundsTb.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                ipTb.Enabled = true;
                roundsTb.Enabled = false;
                startBt.Text = "Подключиться";
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                ipTb.Enabled = false;
                roundsTb.Enabled = true;
                startBt.Text = "Создать сервер";
            }
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Сервер")
            {
                Player.SetName(nameTb.Text);
                Player.SetStatus(comboBox1.Text, ipTb.Text);
                MessageBox.Show(Player.name + ", " + Player.status + ", " + Player.friendIP + ", " + Player.rounds);
                Game gam = new Game();
                gam.Show();
                this.Hide();
            }
            else
            {

                Player.SetName(nameTb.Text);
                Player.SetStatus(comboBox1.Text, ipTb.Text);
                client = new TcpClient();
                client.Connect(nameTb.Text, port);
                stream = client.GetStream();               
                Game game = new Game();
                stream.Close();
                game.Show();
                this.Hide();
            }
        }
    }
}
