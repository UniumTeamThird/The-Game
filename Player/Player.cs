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
