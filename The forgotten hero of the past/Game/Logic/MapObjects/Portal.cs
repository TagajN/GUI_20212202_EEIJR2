using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Game.Logic.MapObjects
{
    public class Portal : MapObject
    {
        public int count;
        public Portal(double x, double y, int width, int height) : base(x, y, width, height, "Portal") { }

        protected string[] PortalIdle =
        {
            "/Art/Game/Portal/portal1.png","/Art/Game/Portal/portal2.png",
            "/Art/Game/Portal/portal3.png","/Art/Game/Portal/portal4.png",
            "/Art/Game/Portal/portal5.png","/Art/Game/Portal/portal6.png",
            "/Art/Game/Portal/portal7.png","/Art/Game/Portal/portal8.png",
            "/Art/Game/Portal/portal9.png",
        };
        private void PortalIdleAnimation(Portal portal)
        {
            if (count > PortalIdle.Length - 1)
                count = 0;
            portal.Image = new BitmapImage((new Uri(PortalIdle[count], UriKind.RelativeOrAbsolute)));
            count++;
        }
        public static void PlayPortalAnimation(ObservableCollection<Portal> portals, Player player)
        {
            foreach (Portal portal in portals)
            {
                if (portal.X >= player.X - 300 && portal.X <= player.X + 1300)
                {
                    portal.PortalIdleAnimation(portal);
                }
            }
        }
    }
}
