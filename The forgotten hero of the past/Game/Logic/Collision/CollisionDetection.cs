using Game.Logic.MapObjects;
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

    }
}
