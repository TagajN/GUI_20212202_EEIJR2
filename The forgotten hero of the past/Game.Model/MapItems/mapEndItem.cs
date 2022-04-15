using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.MapItems
{
    public class mapEndItem : ObservableObject
    {
        private double xPosition;
        private double yPosition;
        public mapEndItem(double xPosition, double yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
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
