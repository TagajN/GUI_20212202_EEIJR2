using Game.Model.ChEnInterfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Enemies
{
    public class SkeletonWarriorModel : ObservableObject, IEnemy
    {
        private int hp;
        private int damage;
        private double xCordinate;
        private double yCordinate;
        private int characterWidth;
        private int characterHeight;
        private double horizDegree;

        public SkeletonWarriorModel()
        {

        }
        public SkeletonWarriorModel(int hp, int damage, double xCordinate, double yCordinate, int characterWidth, int characterHeight, double horizDegree)
        {
            this.hp = hp;
            this.damage = damage;
            this.xCordinate = xCordinate;
            this.yCordinate = yCordinate;
            this.characterWidth = characterWidth;
            this.characterHeight = characterHeight;
            this.horizDegree = horizDegree;
        }

        public int Hp
        {
            get { return hp; }
            set { SetProperty(ref hp, value); }
        }
        public int Damage
        {
            get { return damage; }
            set { SetProperty(ref damage, value); }
        }
        public double XCordinate
        {
            get { return xCordinate; }
            set { SetProperty(ref xCordinate, value); }
        }
        public double YCordinate
        {
            get { return yCordinate; }
            set { SetProperty(ref yCordinate, value); }
        }
        public int CharacterWidth
        {
            get { return characterWidth; }
            set { SetProperty(ref characterWidth, value); }
        }
        public int CharacterHeight
        {
            get { return characterHeight; }
            set { SetProperty(ref characterHeight, value); }
        }
        public double HorizDegree
        {
            get { return horizDegree; }
            set { SetProperty(ref horizDegree, value); }
        }
    }
}
