using System;

namespace Game.Logic
{
    public interface IGameModel
    {
        int xCordinate { get; set; }
        int yCordinate { get; set; }

        event EventHandler Changed;
    }
}