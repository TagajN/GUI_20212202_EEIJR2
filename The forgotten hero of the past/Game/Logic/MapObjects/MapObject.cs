using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Game.Logic.MapObjects
{
    public abstract class MapObject : INotifyPropertyChanged
    {
        private int height;
        private int width;
        private double x;
        private double y;

        private ImageSource image;
        private ScaleTransform mirrored;

        public float Gravity { get; set; }
        public bool Jumping { get; set; }
        public bool IsAttack { get; set; }
        public bool IsLeft { get; set; }
        public bool IsRight { get; set; }
        public bool IsDead { get; set; }
        public double Speed { get; set; }
        public double JumpStrength { get; set; }
        public bool Attacking { get; set; }

        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public ObservableCollection<MapObject> MapObjects { get; set; }

        public MapObject(double x, double y, int width, int height, string name)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Name = name;

            MapObjects = new ObservableCollection<MapObject>();
        }

        public ScaleTransform Mirrored
        {
            get { return mirrored; }
            set
            {
                mirrored = value;
                NotifyPropertyChanged();
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                NotifyPropertyChanged();
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                NotifyPropertyChanged();
            }
        }

        public double X
        {
            get { return x; }
            set
            {
                x = value;
                NotifyPropertyChanged();
                OnMoved();
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                NotifyPropertyChanged();
            }
        }

        public ImageSource Image
        {
            get { return image; }
            set
            {
                image = value;
                NotifyPropertyChanged();
            }
        }

        public void MoveLeft()
        {
            X -= Speed;
        }

        public void MoveRight()
        {
            X += Speed;
        }

        public void Jump()
        {
            Y += JumpStrength;
        }
        public delegate void MovedxEventHandler(object sender, double x);

        public event MovedxEventHandler Moved;

        protected virtual void OnMoved()
        {
            Moved?.Invoke(this, X);
        }
    }
}
