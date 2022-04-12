using Game.Model.ChEnInterfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.MapItems
{
    public class PotionModel : ObservableObject, IGameItem
    {
        private double xPosition;
        private double yPosition;
        private double hpValue;

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

        public double HpValue
        {
            get { return hpValue; }
            set { SetProperty(ref hpValue, value); }
        }

        public bool IsCollision()
        {
            throw new NotImplementedException();
        }
    }
}
