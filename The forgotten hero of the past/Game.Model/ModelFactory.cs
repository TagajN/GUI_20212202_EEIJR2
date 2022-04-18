using Game.Model.Characters;
using Game.Model.ChEnInterfaces;
using Game.Model.Enemies;
using Game.Model.MapItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    public class ModelFactory
    {
        public static CoinModel CreateCoin(double cx, double cy, double coinValue)
        {
            return new CoinModel(cx, cy, coinValue);
        }

        public static PotionModel CreatePotion(double cx, double cy, double hpValue)
        {
            return new PotionModel(cx, cy, hpValue);
        }
        public static WarlockItemModel CreateWarlockItem(double cx, double cy, double damageValue)
        {
            return new WarlockItemModel(cx, cy, damageValue);
        }

        public static PoisonMushroomModel CreatePoisonMushroom(double xCordinate, double yCordinate, int sizew, int sizeh, double horizdegree, int health=150, int damage=20)
        {
            return new PoisonMushroomModel(health, damage, xCordinate, yCordinate, sizew,sizeh, horizdegree);
        }
        public static BossModel CreateBoss(double xCordinate, double yCordinate, int sizew, int sizeh, int health, int damage, double horizdegree)
        {
            return new BossModel(health, damage, xCordinate, yCordinate, sizew, sizeh, horizdegree);
        }
        public static GriffinModel CreateGriffin(double xCordinate, double yCordinate, int sizew, int sizeh, int health, int damage, double horizdegree)
        {
            return new GriffinModel(health, damage, xCordinate, yCordinate, sizew, sizeh, horizdegree);
        }
        public static SkeletonWarriorModel CreateSkeletonWarrior(double xCordinate, double yCordinate, int sizew, int sizeh, int health, int damage, double horizdegree)
        {
            return new SkeletonWarriorModel(health, damage, xCordinate, yCordinate, sizew, sizeh, horizdegree);
        }

        public static KnightModel CreateKnight(double xCordinate, double yCordinate, int characterWidth, int characterHeight, int hp = 200, int chlevel = 0, int experience = 0, int damage = 35, string name = "Knight")
        {
            return new KnightModel(hp, chlevel, experience, damage, name, xCordinate, yCordinate, characterWidth, characterHeight);
        }
        public static StormMageModel CreateStormMage(double xCordinate, double yCordinate, int characterWidth, int characterHeight, double horizDegree, int hp = 150, int chlevel = 0, int experience = 0, int damage = 50, string name = "StormMage")
        {
            return new StormMageModel(hp, chlevel, experience, damage, name, xCordinate, yCordinate, characterWidth, characterHeight, horizDegree);
        }
        public static WarlockModel CreateWarlock(double xCordinate, double yCordinate, int characterWidth, int characterHeight, double horizDegree, int hp = 130, int chlevel = 0, int experience = 0, int damage = 65, string name = "Warlock")
        {
            return new WarlockModel(hp, chlevel, experience, damage, name, xCordinate, yCordinate, characterWidth, characterHeight, horizDegree);
        }
    }
}
