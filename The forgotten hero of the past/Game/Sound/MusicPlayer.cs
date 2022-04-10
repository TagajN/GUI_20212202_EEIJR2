using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Sound
{
    public class MusicPlayer
    {
        System.Windows.Media.MediaPlayer Menu;
        System.Windows.Media.MediaPlayer Click;
        string root;

        public MusicPlayer()
        {
            root = System.IO.Directory.GetCurrentDirectory();
            Menu = new System.Windows.Media.MediaPlayer();
            Click = new System.Windows.Media.MediaPlayer();
        }
        public void MenuMusic()
        {
            
            Menu.Open(new System.Uri(root + "/Sound/ShortMenuMusic.wav"));
            Menu.Volume = 0.05;
            Menu.Play();
        }
        public  void ClickSound()
        {
            Click.Open(new System.Uri(root + "/Sound/ClickSound.wav"));
            Click.Volume = 0.1;
            Click.Play();
        }

        public void PauseResume(string sound)
        {
            switch (sound)
            {
                case "Menu":
                    if (Menu.IsMuted)
                    {
                        Menu.Play();
                        Menu.IsMuted = false;
                    }
                    else
                    {
                        Menu.Pause();
                        Menu.IsMuted = true;
                    }
                        break;
                default:
                    break;
            }
        }

    }
}
