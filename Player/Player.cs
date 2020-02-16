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
        public List<int> friends = new List<int> { };
        public int ID;
        public int time;// в минутах.
        public Boolean status;
        public Player()
        {
            login = "";
            password = "";
            ID = 0;//перевести players.count в string.
            time = 0;
            FileStream add = new FileStream("C:/THE-GAME/USERLIST.txt", FileMode.Open);
            StreamWriter addon = new StreamWriter(add);
            add.Seek(0,SeekOrigin.End);
            addon.WriteLine(ID);
            addon.WriteLine(login);
            addon.WriteLine(password);
        }
        public void Login(string pIn)
        {
            HashingString(pIn);
            if(password == timeData)
            {

            }
            else
            {

            }
            timeData = "";
        }
        public void HashingString(string into)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(into);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            timeData = "";
            foreach (int i in tmpHash)
            {
                timeData+= i;
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
        public List<int> ReturnFriends()
        {
            return(friends);
        }
        public Boolean IsOnline()
        {
            return (status);
        }
    }
}
