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
            //First part
            Coins.Add(new Gold(575, 430, 40, 40));
            Coins.Add(new Gold(825, 400, 40, 40));
            Coins.Add(new Gold(575, 250, 40, 40));
            Coins.Add(new Gold(1100, 575, 40, 40));
            Coins.Add(new Gold(1200, 575, 40, 40));
            Coins.Add(new Gold(1300, 575, 40, 40));


            //Second part
            Coins.Add(new Gold(1675, 430, 40, 40));
            Coins.Add(new Gold(1875, 400, 40, 40));

            //third part

            Coins.Add(new Gold(2875, 430, 40, 40));
            Coins.Add(new Gold(3125, 400, 40, 40));
            Coins.Add(new Gold(3575, 200, 40, 40));
            Coins.Add(new Gold(4000, 575, 40, 40));
            Coins.Add(new Gold(4100, 575, 40, 40));
            Coins.Add(new Gold(4200, 575, 40, 40));

            //fourth part
            Coins.Add(new Gold(4575, 430, 40, 40));
            Coins.Add(new Gold(4375, 400, 40, 40));
            Coins.Add(new Gold(4575, 150, 40, 40));
            Coins.Add(new Gold(5000, 575, 40, 40));
            Coins.Add(new Gold(5100, 575, 40, 40));
            Coins.Add(new Gold(5200, 575, 40, 40));

            //fifth part
            Coins.Add(new Gold(6075, 430, 40, 40));
            Coins.Add(new Gold(6305, 400, 40, 40));
            Coins.Add(new Gold(6500, 575, 40, 40));
            Coins.Add(new Gold(6600, 575, 40, 40));
            Coins.Add(new Gold(6700, 575, 40, 40));
        }

        public static void Potions(ObservableCollection<Potion> Potions)
        {
            //first part -30 -75
            Potions.Add(new Potion(1075, 220, 40, 40));

            //second part
            Potions.Add(new Potion(2075, 320, 40, 40));
            Potions.Add(new Potion(2400, 590, 40, 40));

            //third part
            Potions.Add(new Potion(3775, 170, 40, 40));
            Potions.Add(new Potion(3500, 590, 40, 40));

            //fourth part
            Potions.Add(new Potion(5075, 170, 40, 40));
            Potions.Add(new Potion(4900, 590, 40, 40));

            //fifth part
            Potions.Add(new Potion(6765, 420, 40, 40));
        }
    
        public static void CreateEnemies(ObservableCollection<Enemy> Enemies)
        {

            //first part
            Enemies.Add(new Enemy(500, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(800, 515, 130, 130, "mushroom", 100, 12));
            Enemies.Add(new Enemy(1100, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(1500, 400, 250, 250, "griffin", 200, 25));


            //second part
            Enemies.Add(new Enemy(1800, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(2200, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(2600, 515, 130, 130, "mushroom", 100, 12));

            //third part
            Enemies.Add(new Enemy(2800, 515, 130, 130, "mushroom", 100, 12));
            Enemies.Add(new Enemy(3600, 400, 250, 250, "griffin", 200, 25));

            //fourth part
            Enemies.Add(new Enemy(4300, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(4800, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(5400, 400, 250, 250, "griffin", 200, 25));

            //fifth part
            Enemies.Add(new Enemy(6000, 515, 130, 130, "mushroom", 100, 12));
            Enemies.Add(new Enemy(6300, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(7100, 400, 250, 250, "griffin", 200, 25));

        }
    }
}
