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
            List<int> friends = alpha[persId].returnFriends();
            string friendsOut = "OK";
            for (int i = 0; i < friends.Count; i++)
            {
                friendsOut += "+";
                if (alpha[friends[i]].IsOnline())
                {
                    friendsOut += friends[i];
                }
            }
            return (friendsOut);

        }//функция проверки друзей на онлайн
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
        }
        static void Main(string[] args)
        {
            List <Player> alpha = new List<Player>();
            alpha.Add(new Player());
            int a = 0;
            string allo = "";
            allo = (WhoOnline(a, alpha));
            Console.WriteLine(Speach(allo));
            Console.ReadKey();
        }
    }
}
