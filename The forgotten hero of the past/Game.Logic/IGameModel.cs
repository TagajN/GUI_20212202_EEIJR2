using System;

namespace Game.Logic
{
    public interface IGameModel
    {
        int xCordinate { get; set; }
        int yCordinate { get; set; }

        int Direction { get; set; }

        event EventHandler Changed;
    }
}