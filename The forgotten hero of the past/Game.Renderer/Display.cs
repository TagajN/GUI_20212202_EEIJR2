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
        public Brush BackgroundBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("MapImage", "map.png"), UriKind.RelativeOrAbsolute)));
            }
        }
        
        public Brush KnightBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("MapImage", "knight.png"), UriKind.RelativeOrAbsolute)));
            }
        }
        
        public Brush BossBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("MapImage", "boss.png"), UriKind.RelativeOrAbsolute)));
            }
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (area.Width > 0 && area.Height > 0)
            {
                drawingContext.DrawRectangle(BackgroundBrush, null, new Rect(0, 0, area.Width, area.Height));

                /*drawingContext.PushTransform(new RotateTransform(model.Angle, area.Width / 2, area.Height / 2));*/
                drawingContext.DrawRectangle(KnightBrush, null, new Rect(0, 700, 300, 300));
                drawingContext.DrawRectangle(BossBrush, null, new Rect(500, 550, 450, 450));
                //drawingContext.Pop();

                /*foreach (var item in model.Lasers)
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
