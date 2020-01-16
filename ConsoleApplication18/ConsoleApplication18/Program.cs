using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static string Check(int mId)
        {
            List<int> friends = Player[mId].FrRet;
            string friendsOut = "";
            for(int i  = 0; i < friends.Count; i ++)
            {
                if(i > 0)
                {
                    friendsOut += "_";
                }
                if(Player[friends[i]].IsOnline)
                {
                    friendsOut += friends[i];
                }
            }
            return (friendsOut);

        }
        static void Main(string[] args)
        {
        }
    }
}
