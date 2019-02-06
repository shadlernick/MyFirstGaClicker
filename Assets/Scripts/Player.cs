using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Player
    {
        string name;
        int score;

        public Player(string Name)
        {
            this.name = Name;
            this.score = 0;
        }
    }
}
