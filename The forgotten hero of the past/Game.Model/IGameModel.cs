using Game.Model.ChEnInterfaces;
using Game.Model.MapItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    internal interface IGameModel
    {
        /// <summary>
        /// Gets the Game width.
        /// </summary>
        double GameWidth { get; }

        /// <summary>
        /// Gets the Game height.
        /// </summary>
        double GameHeight { get; }

        /// <summary>
        /// Gets or Sets the level.
        /// </summary>
        int Level { get; set; }

        /// <summary>
        ///  Gets or Sets the player.
        /// </summary>
        ICharacter character { get; set; }

        /// <summary>
        /// Gets the potions.
        /// </summary>
        PotionModel Potion { get; set; }

        /// <summary>
        /// Gets or Sets the Coin.
        /// </summary>
        CoinModel Coin { get; set; }

        /// <summary>
        /// Gets the portal.
        /// </summary>
        mapEndItem EndItem { get; }

        /// <summary>
        /// Gets a list of enemy which should be deleted.
        /// </summary>
        List<IEnemy> DeletableEnemy { get; }


        /// <summary>
        /// Gets or Sets the enemy ships.
        /// </summary>
        List<IEnemy> Enemies { get; set; }
    }
}
}
