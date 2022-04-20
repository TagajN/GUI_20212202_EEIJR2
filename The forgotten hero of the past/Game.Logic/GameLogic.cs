using Game.Logic.Interfaces;
using Game.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Game.Logic
{
    public class GameLogic : IGameLogic
    {
        public Model Background { get; set; }
        public Player Player { get; set; }

        public Ground Ground { get; set; }

        public void InitGame()
        {
            
            Background = new Background(new Vector2(0, 0));
            Player = new Player(new Vector2(20, 430));
            Ground = new Ground(new Vector2(0, 585));
        }

        public void Render(DrawingContext drawingContext)
        {
            Background.Render(drawingContext);
            Player.Render(drawingContext);
            Ground.Render(drawingContext);

        }
        public GameLogic()
        {
            InitGame();
        }

        public void Refresh()
        {
            //Player.Gravitation();
            Player.Update(5);
        }
    }
}
