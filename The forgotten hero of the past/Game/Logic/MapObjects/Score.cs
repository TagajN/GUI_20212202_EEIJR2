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

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
