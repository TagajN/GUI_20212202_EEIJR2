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
            Platforms.Add(new Rect(1000, 480, 200, 50));
            Platforms.Add(new Rect(1250, 450, 200, 50));
            Platforms.Add(new Rect(1000, 300, 200, 50));
            Platforms.Add(new Rect(1300, 250, 200, 50));
            Platforms.Add(new Rect(1500, 250, 200, 50));

            //Second part
            Platforms.Add(new Rect(2100, 480, 200, 50));
            Platforms.Add(new Rect(2300, 450, 200, 50));
            Platforms.Add(new Rect(2100, 250, 200, 50));
            Platforms.Add(new Rect(1900, 150, 200, 50));
            Platforms.Add(new Rect(2500, 350, 200, 50));
            Platforms.Add(new Rect(2450, 350, 200, 50));
            Platforms.Add(new Rect(2700, 450, 200, 50));
            Platforms.Add(new Rect(2900, 480, 200, 50));

            //third part

            Platforms.Add(new Rect(3300, 480, 200, 50));
            Platforms.Add(new Rect(3550, 450, 200, 50));
            Platforms.Add(new Rect(3800, 480, 200, 50));
            Platforms.Add(new Rect(3800, 300, 200, 50));
            Platforms.Add(new Rect(4000, 250, 200, 50));
            Platforms.Add(new Rect(4200, 200, 200, 50));

            //fourth part
            Platforms.Add(new Rect(5000, 480, 200, 50));
            Platforms.Add(new Rect(4800, 450, 200, 50));
            Platforms.Add(new Rect(5000, 350, 200, 50));
            Platforms.Add(new Rect(5250, 230, 200, 50));
            Platforms.Add(new Rect(5000, 200, 200, 50));
            Platforms.Add(new Rect(5500, 200, 200, 50));
            Platforms.Add(new Rect(5750, 230, 200, 50));
            Platforms.Add(new Rect(6000, 350, 200, 50));

            //fifth part
            Platforms.Add(new Rect(6500, 480, 200, 50));
            Platforms.Add(new Rect(6730, 450, 200, 50));
            Platforms.Add(new Rect(6960, 420, 200, 50));
            Platforms.Add(new Rect(6500, 200, 200, 50));
            Platforms.Add(new Rect(6730, 270, 200, 50));
            Platforms.Add(new Rect(7190, 450, 200, 50));

        }

        public static void Coins(ObservableCollection<Gold> Coins)
        {
            //First part
            Coins.Add(new Gold(1075, 430, 40, 40));
            Coins.Add(new Gold(1325, 400, 40, 40));
            Coins.Add(new Gold(1075, 250, 40, 40));
            Coins.Add(new Gold(1600, 575, 40, 40));
            Coins.Add(new Gold(1700, 575, 40, 40));
            Coins.Add(new Gold(1800, 575, 40, 40));


            //Second part
            Coins.Add(new Gold(2175, 430, 40, 40));
            Coins.Add(new Gold(2375, 400, 40, 40));

            //third part

            Coins.Add(new Gold(3375, 430, 40, 40));
            Coins.Add(new Gold(3625, 400, 40, 40));
            Coins.Add(new Gold(4075, 200, 40, 40));
            Coins.Add(new Gold(4500, 575, 40, 40));
            Coins.Add(new Gold(4600, 575, 40, 40));
            Coins.Add(new Gold(4700, 575, 40, 40));

            //fourth part
            Coins.Add(new Gold(5075, 430, 40, 40));
            Coins.Add(new Gold(4875, 400, 40, 40));
            Coins.Add(new Gold(5075, 150, 40, 40));
            Coins.Add(new Gold(5500, 575, 40, 40));
            Coins.Add(new Gold(5600, 575, 40, 40));
            Coins.Add(new Gold(5700, 575, 40, 40));

            //fifth part
            Coins.Add(new Gold(6575, 430, 40, 40));
            Coins.Add(new Gold(6805, 400, 40, 40));
            Coins.Add(new Gold(7000, 575, 40, 40));
            Coins.Add(new Gold(7100, 575, 40, 40));
            Coins.Add(new Gold(7200, 575, 40, 40));
        }
        public static void Creates(ObservableCollection<Chest> Chests)
        {
            Chests.Add(new Chest(1900, 50, 150, 150));
            Chests.Add(new Chest(6500, 100, 150, 150));
        }

        public static void Portals(ObservableCollection<Portal> portals)
        {
            portals.Add(new Portal(8000, 450, 200, 200));
        }

        public static void Potions(ObservableCollection<Potion> Potions)
        {
            //first part -30 -75
            Potions.Add(new Potion(1575, 220, 40, 40));

            //second part
            Potions.Add(new Potion(2575, 320, 40, 40));
            Potions.Add(new Potion(2900, 590, 40, 40));

            //third part
            Potions.Add(new Potion(4275, 170, 40, 40));
            Potions.Add(new Potion(4000, 590, 40, 40));

            //fourth part
            Potions.Add(new Potion(5575, 170, 40, 40));
            Potions.Add(new Potion(5400, 590, 40, 40));

            //fifth part
            Potions.Add(new Potion(7265, 420, 40, 40));
        }
    
        public static void CreateEnemies(ObservableCollection<Enemy> Enemies)
        {

            //first part
            Enemies.Add(new Enemy(1000, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(1300, 515, 130, 130, "mushroom", 100, 12));
            Enemies.Add(new Enemy(1800, 400, 250, 250, "griffin", 200, 25));


            //second part
            Enemies.Add(new Enemy(2500, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(2900, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(3500, 515, 130, 130, "mushroom", 100, 12));

            //third part
            Enemies.Add(new Enemy(4000, 515, 130, 130, "mushroom", 100, 12));
            Enemies.Add(new Enemy(4600, 400, 250, 250, "griffin", 200, 25));

            //fourth part
            Enemies.Add(new Enemy(4800, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(5300, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(5900, 400, 250, 250, "griffin", 200, 25));

            //fifth part
            Enemies.Add(new Enemy(6500, 515, 130, 130, "mushroom", 100, 12));
            Enemies.Add(new Enemy(6800, 500, 200, 200, "skeleton", 120, 15));
            Enemies.Add(new Enemy(7600, 400, 250, 250, "griffin", 200, 25));

        }
    }
}
