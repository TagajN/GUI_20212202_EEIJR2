using Game.Model;
using Game.Model.ChEnInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace Game.Renderer
{
    public class Display
    {
        /// <summary>
        /// Knight animation
        /// </summary>
        List<string> idle = new List<string>

        {
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle1.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle2.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle3.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle4.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle5.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle6.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle7.png",
            "pack://application:,,,/Game;component/AnimationKnight/idle/idle8.png",

        };


        List<string> run = new List<string>
        {
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run1.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run2.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run3.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run4.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run5.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run6.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run7.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run8.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run9.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run10.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run11.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run12.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run13.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run14.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run15.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run16.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run17.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run18.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run19.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/run/run20.png",
        };

        List<string> attack = new List<string>
        {
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack1.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack2.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack3.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack4.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack5.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack6.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack7.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack8.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack9.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack10.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack11.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack12.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack13.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack14.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack15.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack16.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack17.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack18.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack19.png",
            "pack://application:,,,/Game.Renderer;component/AnimationKnight/attack/attack20.png",
        };

        int playerCounter = 0;

        public void PlayPlayerAnimation(Rectangle Player_Canvas, ICharacter playerobj)
        {

            if (playerobj.XCordinate == 1000)
            {
                if (playerCounter >= idle.Count)
                {
                    playerCounter = 0;
                }
                Player_Canvas.Fill = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri(idle[playerCounter], UriKind.Absolute))
                };
                playerCounter++;
            }
            /*else
            {
                if (playerobj.XCordinate < 0)
                {
                    Player_Canvas.LayoutTransform = new ScaleTransform(1, 1, 0, 0);
                }
                else
                {
                    Player_Canvas.LayoutTransform = new ScaleTransform(-1, 1, 0, 0);
                }

                if (playerCounter >= run.Count)
                {
                    playerCounter = 0;
                }
                Player_Canvas.Fill = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri(run[playerCounter], UriKind.Absolute))
                };
                playerCounter++;
            }*/

        }
    }
}
