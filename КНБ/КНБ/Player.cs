using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace КНБ
{
    class Player
    {
        public static string name;
        public static int status;
        public static string friendIP;
        public static int rounds;
        public static int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        static TcpListener listener;


        public Player()
        {

        }

        public static void SetName(string nm)
        {
            name = nm;
        }

        public static int SendAndGet(int myTurn)
        {
            int yourTurn;
            client = new TcpClient();
            client.Connect(friendIP, port);
            stream = client.GetStream();
            BinaryReader receiver = new BinaryReader(stream);
            BinaryWriter sender = new BinaryWriter(stream);
            sender.Write(myTurn);
            sender.Flush();
            yourTurn = receiver.ReadInt32();
            stream.Close();
            return yourTurn;
        }

        public static int GetAndAnswer(int myTurn)
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            TcpClient Client = listener.AcceptTcpClient();
            NetworkStream stream = Client.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream); 
            int yourTurn = reader.ReadInt32();
            if(WhoWon(myTurn, yourTurn) == 1)
            {
                //я победил
                writer.Write(-1);
                Client.Close();
                listener.Stop();
                return 1;
            }
            else if(WhoWon(myTurn, yourTurn) == 2)
            {
                //ты победил
                writer.Write(1);
                Client.Close();
                listener.Stop();
                return -1;
            }
            else
            {
                //ничья
                writer.Write(0);
                Client.Close();
                listener.Stop();
                return 0;
            }
        }

        public static int WhoWon(int player1, int player2)
        {
            if ((player1 == 0 && player2 == 1) || (player1 == 1 && player2 == 2) || (player1 == 2 && player2 == 0))
            {                             
                return 1;
            }
            else if ((player1 == 1 && player2 == 0) || (player1 == 2 && player2 == 1) || (player1 == 0 && player2 == 2))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public static void SetStatus(string st, string ip)
        {
            if(st == "Клиент")
            {
                status = 1;
                SetIP(ip);
            }
            else if(st == "Сервер")
            {
                status = 0;
                SetIP("127.0.0.1");
            }
            else
            {
                throw new Exception("Неверный режим работы!");
            }
        }

        public static void SetIP(string ip)
        {
            friendIP = ip;
        }

        public static void SetRounds(int r)
        {
            rounds = r;
        }
    }
}
