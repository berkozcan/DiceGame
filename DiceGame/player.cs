using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GreedyChicken
{
    class player
    {
        public string name;
        public int bank;
        public int score;
        public Color color;
        public player(string name,int bank,int score,Color color)
        {
            this.name = name;
            this.bank = bank;
            this.score = score;
            this.color = color;
        }
    }
}
