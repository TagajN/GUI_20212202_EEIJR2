using Game.Model.ChEnInterfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.MapItems
{
    public class WarlockItemModel : ObservableObject, IGameItem
    {
        private double xPosition;
        private double yPosition;
        private double gitemValue;

        public WarlockItemModel(double xPosition, double yPosition, double damage)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.gitemValue = damage;
        }

        public double GitemValue
        {
            get { return gitemValue; }
            set { SetProperty(ref gitemValue, value); }
        }
        public double XPosition
        {
            get { return xPosition; }
            set { SetProperty(ref xPosition, value); }
        }
        public double YPosition
        {
            get { return yPosition; }
            set { SetProperty(ref yPosition, value); }
        }

        public bool IsCollision()
        {
            throw new NotImplementedException();
        }
    }
}
