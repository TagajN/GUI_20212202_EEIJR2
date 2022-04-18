using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Logic
{
    public class HeroLogic : IGameModel
    {
        public event EventHandler Changed;
        public int xCordinate { get; set; }
        public int yCordinate { get; set; }
        public enum Controls
        {
            Left, Right, Up, Down, Attack
        }
        public void Control(Controls control)
        {
            switch (control)
            {
                case Controls.Left:
                    xCordinate -= 10;
                    break;
                case Controls.Right:
                    xCordinate += 10;
                    break;
                case Controls.Up:
                    yCordinate -= 10;
                    break;
                case Controls.Down:
                    yCordinate += 10;
                    break;
                case Controls.Attack:
                    break;
                default:
                    break;
            }

            Changed?.Invoke(this, null);
        }
    }
}
