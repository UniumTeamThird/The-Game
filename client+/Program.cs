using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Client
{
    class Program
    {
        static string userName;
        private const string host = "192.168.0.132";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        static void HashingString(string into, out string timeData)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(into);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            timeData = "";
            foreach (int i in tmpHash)
            {
                timeData += i;
            }
        }
        static void Register(string newLogin, string newPassword,int countPlayers)
        {
            FileStream lookFor = new FileStream("", FileMode.Open);
            StreamWriter write = new StreamWriter(lookFor);
            lookFor.Seek(0, SeekOrigin.End);
            write.WriteLine(newLogin);
            HashingString(newPassword, out string hashPassword);
            write.WriteLine(hashPassword);
            write.WriteLine(+countPlayers);
            write.WriteLine();
        }
        static void Player(string login, string password ,out Boolean logStatusFree,out Boolean fStatus)
        {
            FileStream lookFor = new FileStream("", FileMode.Open);
            StreamReader reader = new StreamReader(lookFor);
            fStatus = false;
            logStatusFree = true;
            while (!reader.EndOfStream)
            {
                string mLogin = reader.ReadLine();
                string mPassword = reader.ReadLine();
                if (mLogin == login)
                {
                    logStatusFree = false;
                    HashingString(password, out string hPassword);
                    if(mPassword == hPassword)
                    {
                        fStatus = true;
                        break;
                    }
                }
                
            }
            lookFor.Close();
            reader.Close();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            userName = Console.ReadLine();
            client = new TcpClient();
            try
            {
                client.Connect(host, port); //подключение клиента
                stream = client.GetStream(); // получаем поток

                string message = userName;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start(); //старт потока
                Console.WriteLine("Добро пожаловать, {0}", userName);
                SendMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        // отправка сообщений
        static void SendMessage()
        {
            Console.WriteLine("Введите сообщение: ");

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                foreach(char i in message)
                {
                    if(i == '/')
                    {
                        switch(message)
                        {
                            case "/login":
                                Console.WriteLine("Введите логин:");
                                string login = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Введите пароль:");
                                string password = Console.ReadLine();
                                Console.WriteLine();
                                Player(login, password, out Boolean time,out Boolean status);
                                break;
                            case "/register":
                                Console.WriteLine("Введите логин:");
                                string newLogin = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Введите пароль:");
                                string newPassword = Console.ReadLine();
                                Console.WriteLine();
                                Player(newLogin, newPassword, out Boolean loginF, out Boolean fullS);
                                if(loginF)
                                {

                                }
                                break;
                            default:
                                Console.WriteLine("Wrong Command");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        // получение сообщений
        static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    Console.WriteLine(message);//вывод сообщения
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }
    }
}