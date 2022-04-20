using Game.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Game.Logic.Models
{
    public abstract class Model : IRenderable
    {
        public Vector2 Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Brush Brush { get; set; }

        protected Model(Vector2 Position, int Width, int Height)
        {
            this.Position = Position;
            this.Width = Width;
            this.Height = Height;
        }

        public abstract void Render(DrawingContext drawingContext);

        public virtual void Update(int ms)
        {
            Position += new Vector2(0, ms);
        }
    }
}
