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
    public class Gold : MapObject
    {
        public int count;
        public static ImageBrush GoldImage;

        public Gold(double x, double y, int width, int height) : base(x, y, width, height) { }

        private static int coinCounter;

        public static int CoinCounter
        {
            get { return coinCounter; }
            set { coinCounter = value; }
        }

        protected string[] gold =
        {
            "/Art/Game/Gold/gold1.png","/Art/Game/Gold/gold2.png",
            "/Art/Game/Gold/gold3.png","/Art/Game/Gold/gold4.png",
            "/Art/Game/Gold/gold5.png","/Art/Game/Gold/gold6.png",
            "/Art/Game/Gold/gold7.png",
        };

        private void CoinAnimation(Gold coin)
        {
            if (count > gold.Length - 1)
                count = 0;
            coin.Image = new BitmapImage((new Uri(gold[count], UriKind.RelativeOrAbsolute)));
            count++;
        }

        public static void PlayCoinAnimation(ObservableCollection<Gold> Golds, Player player)
        {
            foreach (Gold gold in Golds)
            {
                if (gold.X >= player.X - 500 && gold.X <= player.X + 1300)
                {
                    gold.CoinAnimation(gold);
                }
            }
        }
    }
}
