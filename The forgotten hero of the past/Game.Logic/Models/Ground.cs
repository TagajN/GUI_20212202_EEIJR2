using Game.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Game.Logic.Models
{
    public class Ground : Model
    {
        public Ground(Vector2 Position) :base(Position,0,0)
        {
            Brush = new SolidColorBrush(Color.FromRgb(139, 69, 19));
        }

        public Rect Rect
        {
            get { return new Rect(0, 585, 1200, 10); }
        }

        public override void Render(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(Brush, null, Rect);
        }
    }
}
