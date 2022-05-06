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
        public Chest(double x, double y, int width, int height) : base(x, y, width, height) { }

        protected string[] ChestIdle =
        {
            "/Art/Game/Chest/ChestIdle/chest1.png","/Art/Game/ChestIdle/Chest/chest2.png",
            "/Art/Game/Chest/ChestIdle/chest3.png","/Art/Game/ChestIdle/Chest/chest4.png",
            "/Art/Game/Chest/ChestIdle/chest5.png","/Art/Game/ChestIdle/Chest/chest6.png",
        };
        protected string[] ChestOpen =
       {
            "/Art/Game/Chest/ChestOpen/chestOpen1.png","/Art/Game/Chest/ChestOpen/chestOpen2.png",
            "/Art/Game/Chest/ChestOpen/chestOpen3.png","/Art/Game/Chest/ChestOpen/chestOpen4.png",
            "/Art/Game/Chest/ChestOpen/chestOpen5.png","/Art/Game/Chest/ChestOpen/chestOpen6.png",
            "/Art/Game/Chest/ChestOpen/chestOpen7.png","/Art/Game/Chest/ChestOpen/chestOpen8.png",
            "/Art/Game/Chest/ChestOpen/chestOpen9.png","/Art/Game/Chest/ChestOpen/chestOpen10.png",
            "/Art/Game/Chest/ChestOpen/chestOpen11.png","/Art/Game/Chest/ChestOpen/chestOpen12.png",
            "/Art/Game/Chest/ChestOpen/chestOpen13.png",
        };

        private void ChestIdleAnimation(Chest chest)
        {
            if (count > ChestIdle.Length - 1)
                count = 0;
            chest.Image = new BitmapImage((new Uri(ChestIdle[count], UriKind.RelativeOrAbsolute)));
            count++;
        }
        private void ChestOpenAnimation(Chest chest)
        {
            if (count > ChestOpen.Length - 1)
                count = 0;
            chest.Image = new BitmapImage((new Uri(ChestOpen[count], UriKind.RelativeOrAbsolute)));
            count++;
        }

        public static void PlayCoinAnimation(ObservableCollection<Chest> Chest, Player player)
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
