using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Game.Logic.MapObjects
{
    public class Potion : MapObject
    {
        public int count;
        public Potion(double x, double y, int width, int height) : base(x, y, width, height, "potion") { }

        protected string[] pot =
        {
            "/Art/Game/Potion/potion1.png","/Art/Game/Potion/potion2.png",
            "/Art/Game/Potion/potion3.png","/Art/Game/Potion/potion4.png",
        };

        private void PotionAnimation(Potion poti)
        {
            if (count > pot.Length - 1)
                count = 0;
            poti.Image = new BitmapImage((new Uri(pot[count], UriKind.RelativeOrAbsolute)));
            count++;
        }

        public static void PlayPotionAnimation(ObservableCollection<Potion> potion, Player player)
        {
            foreach (Potion item in potion)
            {
                if (item.X >= player.X - 520 && item.X <= player.X + 1300)
                {
                    item.PotionAnimation(item);
                }
            }
        }
    }
}
