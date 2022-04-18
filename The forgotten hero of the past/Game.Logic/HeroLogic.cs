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
        public int Direction { get; set; }

        public enum Controls
        {
            Left, Right, Up, Down, Attack
        }
        public void Control(Controls control)
        {
            switch (control)
            {
                case Controls.Left:
                    if(xCordinate >= 10)
                    {
                        xCordinate -= 10;
                    }
                    break;
                case Controls.Right:
                    if (xCordinate <= 1710)
                    {
                        xCordinate += 10;
                    }
                    break;
                case Controls.Up:
                    if (yCordinate >= -800)
                    {
                        yCordinate -= 10;
                    }
                    
                    break;
                case Controls.Down:
                    if (yCordinate <= -10)
                    {
                        yCordinate += 10;
                    }
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
