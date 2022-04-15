using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.ChEnInterfaces
{
    public interface IGameItem
    {
        /// <summary>
        /// Gets or Sets the x axis position of the game item.
        /// </summary>
        double XPosition { get; set; }

        /// <summary>
        /// Gets or Sets the y axis position of the game item.
        /// </summary>
        double YPosition { get; set; }

        /// <summary>
        /// Gets or Sets the y axis position of the game item.
        /// </summary>
        double GitemValue { get; set; }

        /// <summary>
        /// Decides whether the item collided with another item.
        /// </summary>
        /// <param name="other">The other item that this item could've collided with.</param>
        /// <returns>Whether they collided or not.</returns>
        bool IsCollision();
    }
}
