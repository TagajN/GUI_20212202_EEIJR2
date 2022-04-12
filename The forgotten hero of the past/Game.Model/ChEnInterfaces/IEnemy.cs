using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.ChEnInterfaces
{
    public interface IEnemy
    {
        /// <summary>
        /// Gets or Sets the Character Hp.
        /// </summary>
        int Hp { get; set; }

        /// <summary>
        /// Gets or Sets the Damage.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// Gets or Sets the x axis position that the player travelled on the map.
        /// </summary>
        double XCordinate { get; set; }

        /// <summary>
        /// Gets or Sets the y axis position that the player travelled on the map.
        /// </summary>
        double YCordinate { get; set; }

        /// <summary>
        /// The width of the character.
        /// </summary>
        int CharacterWidth { get; set; }

        /// <summary>
        /// the height of the character.
        /// </summary>
        int CharacterHeight { get; set; }

        /// <summary>
        /// The horizontal degree of the character.
        /// </summary>
        double HorizDegree { get; set; }
    }
}
