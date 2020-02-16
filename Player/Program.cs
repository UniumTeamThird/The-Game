using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static string WhoOnline(int persId, List<Player> alpha)
        {
            List<int> friends = alpha[persId].ReturnFriends();
            string friendsOut = "OK";
            for (int i = 0; i < friends.Count; i++)
            {
                friendsOut += "_";
                if (alpha[friends[i]].IsOnline())
                {
                    friendsOut += friends[i];
                }
            }
            return (friendsOut);

        }//функция проверки друзей на онлайн (серверная)

        static string Login(string password, string login)
        {
            return ("Login" + "_" + login + "_" + password);
        }
        

        private const string host = "192.168.0.127";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        static string Speach(string message)
        {
            client = new TcpClient();
            client.Connect(host,port);
            stream = client.GetStream();
            BinaryReader receiver = new BinaryReader(stream);
            BinaryWriter sender = new BinaryWriter(stream);
            sender.Write(message);
            sender.Flush();
            return receiver.ReadString();
        }//разговор клиента и сервера(описана торона клиента)
        static void Main(string[] args)
        {
            List <Player> alpha = new List<Player>();
            alpha.Add(new Player());
            int a = 0;
            string mesg = (WhoOnline(a, alpha));
            Console.WriteLine(Speach(mesg));
            Console.ReadKey();
        }//просто пробная отправка
    }
}
