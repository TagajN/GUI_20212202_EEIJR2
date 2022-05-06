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
        public static void Load(ObservableCollection<Rect> Platforms, ObservableCollection<Gold> Coins, ObservableCollection<Potion> Potions, ObservableCollection<Enemy> Enemies)
        {
            foreach (string line in System.IO.File.ReadLines("Map/GAMEMAP.txt"))
            {
                string item = line;
                string[] values = item.Split(" ");
                if (values[4] == "P")
                {
                    Platforms.Add(new Rect(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3])));
                }
                if (values[4] == "G")
                {
                    Coins.Add(new Gold(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3])));
                }
                if (values[4] == "H")
                {
                    Potions.Add(new Potion(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3])));
                }
                if (values.Length == 8)
                {
                    Enemies.Add(new Enemy(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]), values[4], int.Parse(values[5]), int.Parse(values[6])));
                }

            }
        }
    }
}
