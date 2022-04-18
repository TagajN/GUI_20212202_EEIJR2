using Game.Model.ChEnInterfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Characters
{
    public class StormMageModel : ObservableObject, ICharacter
    {
        private int hp;
        private int chlevel;
        private int experience;
        private int damage;
        private string name;
        private int xCordinate;
        private int yCordinate;
        private int characterWidth;
        private int characterHeight;
        private int horizDegree;

        public StormMageModel()
        {

        }
        public StormMageModel(int hp, int chlevel, int experience, int damage, string name, int xCordinate, int yCordinate, int characterWidth, int characterHeight, int horizDegree)
        {
            this.hp = hp;
            this.chlevel = chlevel;
            this.experience = experience;
            this.damage = damage;
            this.name = name;
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
        public int Experience
        {
            get { return experience; }
            set { SetProperty(ref experience, value); }
        }
        public int Chlevel
        {
            get { return chlevel; }
            set { SetProperty(ref chlevel, value); }
        }
        public int Damage
        {
            get { return damage; }
            set { SetProperty(ref damage, value); }
        }
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        public int XCordinate
        {
            get { return xCordinate; }
            set { SetProperty(ref xCordinate, value); }
        }
        public int YCordinate
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
        public int HorizDegree
        {
            get { return horizDegree; }
            set { SetProperty(ref horizDegree, value); }
        }
    }
}
