using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Logic.MapObjects
{
    public class Score
    {
        private int points;
        private string date;
        private int kill;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public int Kill
        {
            get { return kill; }
            set { kill = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
