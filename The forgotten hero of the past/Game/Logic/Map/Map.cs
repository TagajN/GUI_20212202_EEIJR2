using Game.Logic.MapObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game.Logic.Map
{
    public class Map
    {
        public static void Platforms(ObservableCollection<Rect> Platforms)
        {
            for (int i = 1; i <= 20; i++)
            {
                Platforms.Add(new Rect(100 + i * 1700, 570, 200, 50));
                Platforms.Add(new Rect(400 + i * 2000, 200, 100, 50));
            }
        }

        public static void Coins(ObservableCollection<Gold> Coins)
        {
            for (int i = 1; i <= 10; i++)
            {
                Coins.Add(new Gold(400 + i * 2000, 160, 40, 40));
                Coins.Add(new Gold(400 + i * 2000, 160, 40, 40));
                Coins.Add(new Gold(400 + i * 2000, 160, 40, 40));
            }
        }
    }
}
