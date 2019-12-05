using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player
    {
        Random rnd = new Random();
        public string login;
        public string password;
        public string timeData;
        public List<string> friends;
        public string ID;
        public int time;// в минутах.
        public Player()
        {
            login = "";
            password = "";
            ID = "";
            time = 0;
            FileStream add = new FileStream("C:/THE-GAME/USERLIST.txt", FileMode.Open);
            StreamWriter addon = new StreamWriter(add);
            add.Seek(0,SeekOrigin.End);
            addon.WriteLine(ID);
            addon.WriteLine(login);
            addon.WriteLine(password);
        }
        public void Login(string ppd)
        {
            HashingString(ppd);
            if(password == timeData)
            {

            }
            else
            {

            }
            timeData = "";
        }
        public void HashingString(string fh)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(fh);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            timeData = "";
            foreach (int i in tmpHash)
            {
                timeData+= i;
            }
        }
        public void AddFriend(string id)
        {
            if(id.Equals(players))
            {
                FileStream add = new FileStream("C:/THE-GAME/USERLIST.txt", FileMode.Open);
                StreamWriter addon = new StreamWriter(add);
                StreamReader read = new StreamReader(add);
                while(read.ReadLine()!=login)
                {

                }
                add.Seek(1,SeekOrigin.Current);
                friends.Add(id);
                addon.Write(id + ",");
            }
            else
            {
                //Sry, friend, but there's no your friend!;
            }
        }
        public void DeleteFriend(string id)
        {
            if(id.Equals(friends))
            {
                friends.Remove(id);
            }
            else
            {
                //Sry, but we don't recognize ID
            }
        }
        public void FightFriend(int id,List<int> players, int dat)
        {
            if (id.Equals(players))
            {
                SendData(dat);
            }
            else
            {
                //Sry, friend, but there's no your friend!;
            }
        }
        public void SendData(int dat)
        {
            //There's a process of sending this information to friend
        }
    }
}
