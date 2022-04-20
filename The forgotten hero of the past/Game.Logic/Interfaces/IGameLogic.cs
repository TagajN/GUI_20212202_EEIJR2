﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Game.Logic.Interfaces
{
    public interface IGameLogic
    {
        void Render(DrawingContext drawingContext);
        void Refresh();
    }
}
