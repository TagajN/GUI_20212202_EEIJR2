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
        public Gold(double x, double y, int width, int height) : base(x, y, width, height) { }

        protected string[] gold =
        {
            "/Art/Game/Gold/gold1.png","/Art/Game/Gold/gold2.png",
            "/Art/Game/Gold/gold3.png","/Art/Game/Gold/gold4.png",
            "/Art/Game/Gold/gold5.png","/Art/Game/Gold/gold6.png",
            "/Art/Game/Gold/gold7.png",
        };

        private void CoinAnimation(Gold goldCoin)
        {
            if (count > gold.Length - 1)
                count = 0;
            goldCoin.Image = new BitmapImage((new Uri(gold[count], UriKind.RelativeOrAbsolute)));
            count++;
        }

        public static void PlayCoinAnimation(ObservableCollection<Gold> Gold, Player player)
        {
            foreach (Gold coin in Gold)
            {
                if (coin.X >= player.X - 520 && coin.X <= player.X + 1300)
                {
                    coin.CoinAnimation(coin);
                }
            }
        }
    }
}
