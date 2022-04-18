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
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/idle/idle8.png",

        };


        List<string> run = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run8.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run9.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/run/run10.png",
        };

        List<string> attack = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack8.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack9.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack10.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack11.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack12.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack13.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack14.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack15.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack16.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack17.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack18.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack19.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/attack/attack20.png",
        };

        List<string> death = new List<string>
        {
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death1.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death2.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death3.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death4.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death5.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death6.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death7.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death8.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death9.png",
            "pack://application:,,,/Game;component/Windows/AnimationKnight/death/death10.png",
        };

        int playerCounter = 0;

        public void PlayPlayerAnimationIdle(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(idle[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= idle.Count - 1)
            {
                playerCounter = 0;
            }
        }
        public void PlayPlayerAnimationDeath(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(death[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= death.Count - 1)
            {
                playerCounter = 0;
            }
        }
        public void PlayPlayerAnimationRun(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(run[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= run.Count - 1)
            {
                playerCounter = 0;
            }
        }
        public void PlayPlayerAnimationAttack(Rectangle Player_Canvas, ICharacter playerobj)
        {
            Player_Canvas.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(attack[playerCounter], UriKind.Absolute))
            };
            playerCounter++;
            if (playerCounter >= attack.Count - 1)
            {
                playerCounter = 0;
            }
        }
    }
}
