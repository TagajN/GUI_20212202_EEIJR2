﻿using Game.Logic.MapObjects;
using Game.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game.Logic.CollisionDetection
{
    public class CollisionDetection : GameWindow
    {
        public static bool OnPlatform;

        public static bool PlatformCollision(Player Player, ObservableCollection<Rect> Platform)
        {
            Rect PlayerHitbox = new Rect(Player.X + 3, Player.Y + Player.Height - 55, Player.Width - 80, 1);

            for (int i = Platform.Count - 1; i >= 0; i--)
            {
                Rect PlatformHitbox = new Rect(Platform[i].X, Platform[i].Y, Platform[i].Width-65, Platform[i].Height-45);

                if (PlayerHitbox.IntersectsWith(PlatformHitbox))
                {
                    Player.Gravity = 0;
                    Player.Jumping = false;
                    PlatformHitbox.Y = PlayerHitbox.Y + PlayerHitbox.Height - 55;
                    OnPlatform = true;
                    return true;
                }
                OnPlatform = false;
            }
            return false;
        }

        public static bool RightCollision(MapObject Object, ObservableCollection<Rect> Platform)
        { 
            Rect Hitbox;
            if (Object.Name == "player")
            {
                Hitbox = new Rect(Object.X + Object.Width - 80, Object.Y + 1, 1, Object.Height - 55);
            }
            if (Object.Name == "skeleton")
            {
                Hitbox = new Rect(Object.X + Object.Width - 100, Object.Y + 1, 1, Object.Height - 55);
            }
            if (Object.Name == "mushroom")
            {
                Hitbox = new Rect(Object.X + Object.Width - 40, Object.Y + 1, 1, Object.Height - 55);
            }
            if (Object.Name == "griffin")
            {
                Hitbox = new Rect(Object.X + Object.Width - 40, Object.Y + 1, 1, Object.Height - 55);
            }

            for (int i = Platform.Count - 1; i >= 0; i--) {
                Rect PlatformHitbox = new Rect(Platform[i].X, Platform[i].Y, Platform[i].Width - 65, Platform[i].Height - 45);

                if (Object.Name =="player")
                {
                    if (Hitbox.IntersectsWith(PlatformHitbox) && !OnPlatform)
                        return true;
                }
                else
                {
                    if (Hitbox.IntersectsWith(PlatformHitbox))
                        return true;
                }
            }
            return false;
        }

        public static bool LeftCollision(MapObject Object, ObservableCollection<Rect> Platform)
        {
            Rect Hitbox;
            if (Object.Name == "player")
            {
                Hitbox = new Rect(Object.X + 20, Object.Y + 1, 1, Object.Height - 55);
            }
            if (Object.Name == "skeleton")
            {
                Hitbox = new Rect(Object.X + 35, Object.Y + 1, 1, Object.Height - 55);
            }
            if (Object.Name == "mushroom")
            {
                Hitbox = new Rect(Object.X + Object.Width - 160, Object.Y + 1, 1, Object.Height - 55);
            }
            if (Object.Name == "griffin")
            {
                Hitbox = new Rect(Object.X + Object.Width - 250, Object.Y + 1, 1, Object.Height - 55);
            }

            for (int i = Platform.Count - 1; i >= 0; i--)
            {
                Rect PlatformHitbox = new Rect(Platform[i].X, Platform[i].Y, Platform[i].Width - 65, Platform[i].Height - 45);
                if (Object.Name == "player")
                {
                    if (Hitbox.IntersectsWith(PlatformHitbox) && !OnPlatform)
                        return true;
                }
                else
                {
                    if (Hitbox.IntersectsWith(PlatformHitbox))
                        return true;
                }
            }
            return false;
        }

        public static void GoldCollision(Player Player, ObservableCollection<Gold> coins)
        {
            Rect PlayerHitbox = new Rect(Player.X + Player.Width - 100, Player.Y + 1, 1, Player.Height - 55);

            for (int i = coins.Count - 1; i >= 0; i--)
            {
                Rect CoinHitBox = new Rect(coins[i].X, coins[i].Y, coins[i].Width, coins[i].Height);

                if (PlayerHitbox.IntersectsWith(CoinHitBox))
                {
                    coins.RemoveAt(i);
                    Player.Gold++;
                }
            }
        }

        public static void PotionCollision(Player Player, ObservableCollection<Potion> potions)
        {
            Rect PlayerHitbox = new Rect(Player.X + Player.Width - 100, Player.Y + 1, 1, Player.Height - 55);

            for (int i = potions.Count - 1; i >= 0; i--)
            {
                Rect PotionHitBox = new Rect(potions[i].X, potions[i].Y, potions[i].Width, potions[i].Height);

                if (PlayerHitbox.IntersectsWith(PotionHitBox))
                {
                    potions.RemoveAt(i);
                    if (Player.Health + 30 <= Player.MaxHP)
                    {
                        Player.Health += 30;
                    }
                    else
                    {
                        Player.Health = Player.MaxHP;
                    }
                    
                }
            }
        }

    }
}
