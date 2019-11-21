using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player
    {
        Random rnd = new Random();
        public string login;
        public string password;
        public List<int> friends;
        public int ID;
        public int time = 0;// в минутах.
        public Player()
        {
            login = "";
            password = "";
            ID = ++players.count;
        }
        public void Addend(int id)
        {
            if(id.Equals(players))
            {
                friends.Add(id);
            }
            else
            {
                Sry, friend, but there's no your friend!;
            }
        }
    }
}
