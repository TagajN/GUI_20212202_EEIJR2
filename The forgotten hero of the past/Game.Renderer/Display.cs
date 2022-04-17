using Game.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Renderer
{
    public class Display : FrameworkElement
    {
        Size area;
        IGameModel model;
        public void SetupSizes(Size area)
        {
            this.area = area;
            this.InvalidateVisual();
        }

        public void SetupModel(IGameModel model)
        {
            this.model = model;
        }
        public Brush SpaceBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "map.png"), UriKind.RelativeOrAbsolute)));
            }
        }
        /*
        public Brush ShipBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "falcon_rotated.png"), UriKind.RelativeOrAbsolute)));
            }
        }

        public Brush AsteroidBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "asteroid.png"), UriKind.RelativeOrAbsolute)));
            }
        }*/
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (area.Width > 0 && area.Height > 0 && model != null)
            {
                drawingContext.DrawRectangle(SpaceBrush, null, new Rect(0, 0, area.Width, area.Height));

                /*drawingContext.PushTransform(new RotateTransform(model.Angle, area.Width / 2, area.Height / 2));
                drawingContext.DrawRectangle(ShipBrush, null, new Rect(area.Width / 2 - 25, area.Height / 2 - 25, 50, 50));
                drawingContext.Pop();

                foreach (var item in model.Lasers)
                {
                    drawingContext.DrawEllipse(Brushes.Red, null, new Point(item.Center.X, item.Center.Y), 5, 5);
                }

                foreach (var item in model.Asteroids)
                {
                    drawingContext.DrawEllipse(AsteroidBrush, null, new Point(item.Center.X, item.Center.Y), 25, 25);
                }*/
            }

        }
    }
}
