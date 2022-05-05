using Game.Logic.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Game.Logic.Background
{
    public class BackgroundAnimation
    {
        public static double leftOffset = 500;
        public static double rightOffset = 1300;

        public static void Move(Image img, Player player, double offset)
        {
            if (player.IsLeft == true)
            {
                Canvas.SetLeft(img, Canvas.GetLeft(img) + offset);

            }
            else if (player.IsRight == true)
            {
                Canvas.SetLeft(img, Canvas.GetLeft(img) - offset);
            }
        }

        public static void Move(Image img1, Image img2, Image img3, Player player, double offset)
        {
            Move(img1, player, offset);
            Move(img2, player, offset);
            Move(img3, player, offset);
        }

        public static void UpdateRight(Image img1, Image img2, Image img3, Player player, double distance)
        {
            if (player.IsRight)
            {
                if (Canvas.GetLeft(img1) + img1.Width <= player.X - distance)
                {
                    Canvas.SetLeft(img1, Canvas.GetLeft(img3) + img3.Width);
                }
                if (Canvas.GetLeft(img2) + img2.Width <= player.X - distance)
                {
                    Canvas.SetLeft(img2, Canvas.GetLeft(img1) + img1.Width);
                }
                if (Canvas.GetLeft(img3) + img3.Width <= player.X - distance)
                {
                    Canvas.SetLeft(img3, Canvas.GetLeft(img2) + img2.Width);
                }
            }
        }

        public static void UpdateLeft(Image img1, Image img2, Image img3, Player player, double distance)
        {
            if (player.IsLeft)
            {
                if (Canvas.GetLeft(img3) >= player.X + distance)
                {
                    Canvas.SetLeft(img3, Canvas.GetLeft(img1) - img1.Width);
                }
                if (Canvas.GetLeft(img2) >= player.X + distance)
                {
                    Canvas.SetLeft(img2, Canvas.GetLeft(img3) - img3.Width);
                }
                if (Canvas.GetLeft(img1) >= player.X + distance)
                {
                    Canvas.SetLeft(img1, Canvas.GetLeft(img2) - img2.Width);
                }
            }
        }

        public static void MoveHPBar(Grid bar, Player player, double offset)
        {
            if (player.IsRight || player.IsLeft)
            {
                if (player.X >= 500 || player.X <= 500)
                {
                    Canvas.SetLeft(bar, player.X - 470);
                }
            }

        }
    }
}
