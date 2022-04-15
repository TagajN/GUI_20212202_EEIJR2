using Game.Model.ChEnInterfaces;
using Game.Model.MapItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class GameModel : IGameModel
    {
        public double GameWidth => throw new NotImplementedException();

        public double GameHeight => throw new NotImplementedException();

        public int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICharacter character { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PotionModel Potion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CoinModel Coin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public mapEndItem EndItem => throw new NotImplementedException();

        public List<IEnemy> DeletableEnemy => throw new NotImplementedException();

        public List<IEnemy> Enemies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
