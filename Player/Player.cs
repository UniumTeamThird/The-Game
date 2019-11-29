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
        public List<int> players;
        public string login;
        public string password;
        public List<int> friends;
        public int ID;
        public int time = 0;// в минутах.
        public Player()
        {
            login = "";
            password = "";
            ID = 1 + players.Count();
            players.Add(ID);
            FileStream add = new FileStream("C:/THE-GAME/USERLIST.txt", FileMode.Open);
            StreamWriter addon = new StreamWriter(add);
            add.Seek(0,SeekOrigin.End);
            addon.WriteLine(ID);
            addon.WriteLine(login);
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string pps = "";
            foreach(int i in tmpHash)
            {
                pps += i;
            }
            addon.WriteLine(pps);
        }
        public void AddFriend(int id)
        {
            if(id.Equals(players))
            {
                friends.Add(id);
            }
            else
            {
                //Sry, friend, but there's no your friend!;
            }
        }
        public void DeleteFriend(int id)
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
        public void FightFriend(int id)
        {
            if (id.Equals(players))
            {

            }
            else
            {
                //Sry, friend, but there's no your friend!;
            }
        }
    }
}
