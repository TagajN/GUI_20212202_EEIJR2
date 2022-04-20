using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Logic.Models
{
    public class Background : Model 
    {
        const int Width = 1200;
        const int Height = 630;

        public Background(Vector2 Position) : base(Position,Width,Height)
        {
           Brush = new ImageBrush(new BitmapImage(new Uri(Path.Combine("Contents", "map.png"), UriKind.RelativeOrAbsolute)));
        }

        public override void Render(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(Brush, null, new Rect(Position.X, Position.Y, Width, Height));
        }
    }
}
