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
                //Platforms.Add(new Rect(300 + i * 1700, 570, 200, 50));
                //Platforms.Add(new Rect(200 + i * 1200, 350, 200, 50));
                //Platforms.Add(new Rect(300 + i * 1500, 300, 200, 50));
                //Platforms.Add(new Rect(400 + i * 2000, 200, 100, 50));
            }
        }

        public static void Coins(ObservableCollection<Gold> Coins)
        {
            for (int i = 1; i <= 15; i++)
            {
                Coins.Add(new Gold(i * 100, 540, 40, 40));
            }
            
        }

        public static void Potions(ObservableCollection<Potion> Potions)
        {
            for (int i = 1; i <= 15; i++)
            {
                Potions.Add(new Potion(i * 100, 580, 40, 40));
            }
        }
    
        public static void CreateEnemies(ObservableCollection<Enemy> Enemies)
        {
            for (int i = 1; i <= 20; i++)
            {
               //Enemies.Add(new Enemy(i * 1500, 500, 200, 200,"skeleton",100,25));
               //Enemies.Add(new Enemy(i * 2000, 515, 130, 130, "mushroom",100,12));
               //Enemies.Add(new Enemy(i * 3000, 400, 250, 250, "griffin",230, 30));
            }
        }
    }
}
