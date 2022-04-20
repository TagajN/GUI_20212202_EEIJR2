using Game.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Logic.Models
{
    public class Player : Model
    {
        public Rect Rect { get; private set; }

        public Player(Vector2 Position) : base(Position, 0, 0)
        {
            BitmapImage image = new BitmapImage(new Uri(Path.Combine("Contents", "knight_0.png"), UriKind.RelativeOrAbsolute));
            Brush = new ImageBrush(image);
            Width = (int) image.Width / 2;
            Height = (int) image.Height / 2;
        }

        public override void Render(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(Brush, null, new Rect(Position.X, Position.Y, Width, Height));
        }

        public void Left()
        {
            Position += new Vector2(-5f, 0);
        }

        public void Right()
        {
            Position += new Vector2(5f, 0);
        }
        public void Crouch()
        {
            Position += new Vector2(0, 5f);
        }
        public void Jump()
        {
            Position += new Vector2(0, -5f);
        }
        public void Attack()
        {

        }

        public override void Update(int ms)
        {
            if (Keyboard.IsKeyDown(Key.Right))
            {
                Right();
            }
            if (Keyboard.IsKeyDown(Key.Left))
            {
                Left();
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                Crouch();
            }
            if (Keyboard.IsKeyDown(Key.Up))
            {
                Jump();
            }
            if (Keyboard.IsKeyDown(Key.Space))
            {
                Attack();
            }
        }

        public void Gravitation()
        {
            Position += new Vector2(0, 5f);
        }
    }
}
