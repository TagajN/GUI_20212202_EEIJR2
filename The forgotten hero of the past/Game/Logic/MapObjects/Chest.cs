using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Logic.MapObjects
{
    public class Chest : MapObject
    {
        public int count;
        public Chest(double x, double y, int width, int height) : base(x, y, width, height, "chest") { }

        protected string[] ChestIdle =
        {
            "/Art/Game/Chest/ChestIdle/chest1.png","/Art/Game/Chest/ChestIdle/chest2.png",
            "/Art/Game/Chest/ChestIdle/chest3.png","/Art/Game/Chest/ChestIdle/chest4.png",
            "/Art/Game/Chest/ChestIdle/chest5.png","/Art/Game/Chest/ChestIdle/chest6.png",
        };
        private void ChestIdleAnimation(Chest chest)
        {
            if (count > ChestIdle.Length - 1)
                count = 0;
            chest.Image = new BitmapImage((new Uri(ChestIdle[count], UriKind.RelativeOrAbsolute)));
            count++;
        }
        public static void PlayChestAnimation(ObservableCollection<Chest> Chest, Player player)
        {
            foreach (Chest chest in Chest)
            {
                if (chest.X >= player.X - 300 && chest.X <= player.X + 1300)
                {
                    chest.ChestIdleAnimation(chest);
                }
            }
        }
    }
}
