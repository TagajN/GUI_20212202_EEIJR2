﻿using Game.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Game.Renderer
{
    public class Display : FrameworkElement
    {
        IGameLogic logic;

        public void Setup(IGameLogic logic)
        {
            this.logic = logic;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            logic?.Render(drawingContext);
        }

    }
}
