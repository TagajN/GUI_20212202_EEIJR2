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
            //First part
            Platforms.Add(new Rect(500, 480, 200, 50));
            Platforms.Add(new Rect(750, 450, 200, 50));
            Platforms.Add(new Rect(500, 300, 200, 50));
            Platforms.Add(new Rect(800, 250, 200, 50));
            Platforms.Add(new Rect(1000, 250, 200, 50));

            //Second part
            Platforms.Add(new Rect(1600, 480, 200, 50));
            Platforms.Add(new Rect(1800, 450, 200, 50));
            Platforms.Add(new Rect(1600, 250, 200, 50));
            Platforms.Add(new Rect(1400, 150, 200, 50));
            Platforms.Add(new Rect(2000, 350, 200, 50));
            Platforms.Add(new Rect(1950, 350, 200, 50));
            Platforms.Add(new Rect(2200, 450, 200, 50));
            Platforms.Add(new Rect(2400, 480, 200, 50));

            //third part

            Platforms.Add(new Rect(2800, 480, 200, 50));
            Platforms.Add(new Rect(3050, 450, 200, 50));
            Platforms.Add(new Rect(3300, 480, 200, 50));
            Platforms.Add(new Rect(3300, 300, 200, 50));
            Platforms.Add(new Rect(3500, 250, 200, 50));
            Platforms.Add(new Rect(3700, 200, 200, 50));

            //fourth part
            Platforms.Add(new Rect(4500, 480, 200, 50));
            Platforms.Add(new Rect(4300, 450, 200, 50));
            Platforms.Add(new Rect(4500, 350, 200, 50));
            Platforms.Add(new Rect(4750, 230, 200, 50));
            Platforms.Add(new Rect(4500, 200, 200, 50));
            Platforms.Add(new Rect(5000, 200, 200, 50));
            Platforms.Add(new Rect(5250, 230, 200, 50));
            Platforms.Add(new Rect(5500, 350, 200, 50));

            //fifth part
            Platforms.Add(new Rect(6000, 480, 200, 50));
            Platforms.Add(new Rect(6230, 450, 200, 50));
            Platforms.Add(new Rect(6460, 420, 200, 50));
            Platforms.Add(new Rect(6000, 200, 200, 50));
            Platforms.Add(new Rect(6230, 270, 200, 50));
            Platforms.Add(new Rect(6690, 450, 200, 50));

        }

        public static void Coins(ObservableCollection<Gold> Coins)
        {
            for (int i = 1; i <= 15; i++)
            {
                Coins.Add(new Gold(i * 500, 540, 40, 40));
            }
            
        }

        public static void Potions(ObservableCollection<Potion> Potions)
        {
            for (int i = 1; i <= 15; i++)
            {
               Potions.Add(new Potion(i * 400, 580, 40, 40));
            }
        }
    
        public static void CreateEnemies(ObservableCollection<Enemy> Enemies)
        {
            for (int i = 1; i <= 20; i++)
            {
               //Enemies.Add(new Enemy(i * 1500, 500, 200, 200,"skeleton",100,10));
              // Enemies.Add(new Enemy(i * 2000, 515, 130, 130, "mushroom",100,12));
               //Enemies.Add(new Enemy(i * 3000, 400, 250, 250, "griffin",230, 30));
            }
        }
    }
}
