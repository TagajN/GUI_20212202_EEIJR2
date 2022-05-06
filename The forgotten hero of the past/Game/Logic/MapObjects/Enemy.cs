using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Logic.MapObjects
{
    public class Enemy : MapObject
    {
        public int count;
        public static bool followPlayer;
        private int health;
        private int damage;
        public string Name;
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                NotifyPropertyChanged();
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                damage = value;
                NotifyPropertyChanged();
            }
        }

        public Enemy(double x, double y, int width, int height,string name, int health, int damage) : base(x, y, width, height) { this.Name = name; this.Health = health; this.damage = damage; }

        protected string[] RunSkeleton =
        {
             "/Art/Game/Enemy/Skeleton/Run/run1.png","/Art/Game/Enemy/Skeleton/Run/run2.png",
             "/Art/Game/Enemy/Skeleton/Run/run3.png","/Art/Game/Enemy/Skeleton/Run/run4.png",
             "/Art/Game/Enemy/Skeleton/Run/run5.png","/Art/Game/Enemy/Skeleton/Run/run6.png",
             "/Art/Game/Enemy/Skeleton/Run/run7.png","/Art/Game/Enemy/Skeleton/Run/run8.png",
             "/Art/Game/Enemy/Skeleton/Run/run9.png","/Art/Game/Enemy/Skeleton/Run/run10.png",
        };

        protected string[] IdleSkeleton =
        {
            "/Art/Game/Enemy/Skeleton/Idle/idle1.png","/Art/Game/Enemy/Skeleton/Idle/idle2.png",
            "/Art/Game/Enemy/Skeleton/Idle/idle3.png","/Art/Game/Enemy/Skeleton/Idle/idle4.png",
            "/Art/Game/Enemy/Skeleton/Idle/idle5.png","/Art/Game/Enemy/Skeleton/Idle/idle6.png",
            "/Art/Game/Enemy/Skeleton/Idle/idle7.png",
        };

        protected string[] DeathSkeleton =
        {
            "/Art/Game/Enemy/Skeleton/Death/death1.png","/Art/Game/Enemy/Skeleton/Death/death2.png",
            "/Art/Game/Enemy/Skeleton/Death/death3.png","/Art/Game/Enemy/Skeleton/Death/death4.png",
            "/Art/Game/Enemy/Skeleton/Death/death5.png","/Art/Game/Enemy/Skeleton/Death/death6.png",
            "/Art/Game/Enemy/Skeleton/Death/death7.png","/Art/Game/Enemy/Skeleton/Death/death8.png",
            "/Art/Game/Enemy/Skeleton/Death/death9.png","/Art/Game/Enemy/Skeleton/Death/death10.png",
            "/Art/Game/Enemy/Skeleton/Death/death11.png","/Art/Game/Enemy/Skeleton/Death/death12.png",
        };

        protected string[] AttackSkeleton =
       {
            "/Art/Game/Enemy/Skeleton/Attack/attack5.png","/Art/Game/Enemy/Skeleton/Attack/attack6.png",
            "/Art/Game/Enemy/Skeleton/Attack/attack7.png","/Art/Game/Enemy/Skeleton/Attack/attack8.png",
            "/Art/Game/Enemy/Skeleton/Attack/attack9.png","/Art/Game/Enemy/Skeleton/Attack/attack10.png",
            "/Art/Game/Enemy/Skeleton/Attack/attack11.png","/Art/Game/Enemy/Skeleton/Attack/attack12.png"
        };

        protected string[] StunnedSkeleton =
        {
            "/Art/Game/Enemy/Skeleton/Death/death2.png"
        };
        private void AnimateRuntoRightSkeleton()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > RunSkeleton.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(RunSkeleton[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateRuntoLeftSkeleton()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > RunSkeleton.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(RunSkeleton[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateIdleSkeleton()
        {
            if (count > IdleSkeleton.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(IdleSkeleton[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        public void AnimateDeathSkeleton()
        {
            while(count != 11)
            {
                if (count > DeathSkeleton.Length - 1)
                    count = 0;
                Image = new BitmapImage(new Uri(DeathSkeleton[count], UriKind.RelativeOrAbsolute));
                count++;
            }
        }

        private void AnimateAttacktoRightSkeleton()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > AttackSkeleton.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(AttackSkeleton[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 4)
            {
                Attacking = true;
            }

        }

        private void AnimateAttacktoLeftSkeleton()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > AttackSkeleton.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(AttackSkeleton[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 4)
            {
                Attacking = true;
            }
        }

        public void AnimateStunnSkeleton()
        {
                if (count > StunnedSkeleton.Length - 1)
                    count = 0;
                Image = new BitmapImage(new Uri(StunnedSkeleton[count], UriKind.RelativeOrAbsolute));
                count++;
        }

        protected string[] RunMushroom =
        {
             "/Art/Game/Enemy/Mushroom/Run/run1.png","/Art/Game/Enemy/Mushroom/Run/run2.png",
             "/Art/Game/Enemy/Mushroom/Run/run3.png","/Art/Game/Enemy/Mushroom/Run/run4.png",
             "/Art/Game/Enemy/Mushroom/Run/run5.png","/Art/Game/Enemy/Mushroom/Run/run6.png",
             "/Art/Game/Enemy/Mushroom/Run/run7.png","/Art/Game/Enemy/Mushroom/Run/run8.png",
             "/Art/Game/Enemy/Mushroom/Run/run9.png","/Art/Game/Enemy/Mushroom/Run/run10.png",
             "/Art/Game/Enemy/Mushroom/Run/run11.png",
        };

        protected string[] IdleMushroom =
        {
            "/Art/Game/Enemy/Mushroom/Idle/idle1.png","/Art/Game/Enemy/Mushroom/Idle/idle2.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle3.png","/Art/Game/Enemy/Mushroom/Idle/idle4.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle5.png","/Art/Game/Enemy/Mushroom/Idle/idle6.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle7.png","/Art/Game/Enemy/Mushroom/Idle/idle8.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle9.png","/Art/Game/Enemy/Mushroom/Idle/idle10.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle11.png","/Art/Game/Enemy/Mushroom/Idle/idle12.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle13.png","/Art/Game/Enemy/Mushroom/Idle/idle14.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle15.png","/Art/Game/Enemy/Mushroom/Idle/idle16.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle17.png","/Art/Game/Enemy/Mushroom/Idle/idle18.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle19.png","/Art/Game/Enemy/Mushroom/Idle/idle20.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle21.png","/Art/Game/Enemy/Mushroom/Idle/idle22.png",
            "/Art/Game/Enemy/Mushroom/Idle/idle23.png",
        };

        protected string[] DeathMushroom =
        {
            "/Art/Game/Enemy/Mushroom/Death/death1.png","/Art/Game/Enemy/Mushroom/Death/death2.png",
            "/Art/Game/Enemy/Mushroom/Death/death3.png","/Art/Game/Enemy/Mushroom/Death/death4.png",
            "/Art/Game/Enemy/Mushroom/Death/death5.png","/Art/Game/Enemy/Mushroom/Death/death6.png",
            "/Art/Game/Enemy/Mushroom/Death/death7.png","/Art/Game/Enemy/Mushroom/Death/death8.png",
            "/Art/Game/Enemy/Mushroom/Death/death9.png","/Art/Game/Enemy/Mushroom/Death/death10.png",
            "/Art/Game/Enemy/Mushroom/Death/death11.png","/Art/Game/Enemy/Mushroom/Death/death12.png",
            "/Art/Game/Enemy/Mushroom/Death/death13.png","/Art/Game/Enemy/Mushroom/Death/death14.png",
        };

        protected string[] AttackMushroom =
       {
            "/Art/Game/Enemy/Mushroom/Attack/attack1.png","/Art/Game/Enemy/Mushroom/Attack/attack2.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack3.png","/Art/Game/Enemy/Mushroom/Attack/attack4.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack5.png","/Art/Game/Enemy/Mushroom/Attack/attack6.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack7.png","/Art/Game/Enemy/Mushroom/Attack/attack8.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack9.png","/Art/Game/Enemy/Mushroom/Attack/attack10.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack11.png","/Art/Game/Enemy/Mushroom/Attack/attack12.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack13.png","/Art/Game/Enemy/Mushroom/Attack/attack14.png",
            "/Art/Game/Enemy/Mushroom/Attack/attack15.png","/Art/Game/Enemy/Mushroom/Attack/attack16.png",

        };

        protected string[] StunnedMushroom =
        {
            "/Art/Game/Enemy/Mushroom/Death/death2.png"
        };
        private void AnimateRuntoRightMushroom()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > RunMushroom.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(RunMushroom[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateRuntoLeftMushroom()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > RunMushroom.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(RunMushroom[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateIdleMushroom()
        {
            if (count > IdleMushroom.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(IdleMushroom[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        public void AnimateDeathMushroom()
        {
            while(count != 13)
            {
                if (count > DeathMushroom.Length - 1)
                    count = 0;
                Image = new BitmapImage(new Uri(DeathMushroom[count], UriKind.RelativeOrAbsolute));
                count++;
            }
        }

        private void AnimateAttacktoRightMushroom()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > AttackMushroom.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(AttackMushroom[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 6)
            {
                Attacking = true;
            }
        }

        private void AnimateAttacktoLeftMushroom()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > AttackMushroom.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(AttackMushroom[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 6)
            {
                Attacking = true;
            }
        }

        public void AnimateStunnMushroom()
        {
            if (count > StunnedMushroom.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(StunnedMushroom[count], UriKind.RelativeOrAbsolute));
            count++;
        }
        
        protected string[] RunGriffin =
        {
             "/Art/Game/Enemy/Griffin/Run/run1.png","/Art/Game/Enemy/Griffin/Run/run2.png",
             "/Art/Game/Enemy/Griffin/Run/run3.png","/Art/Game/Enemy/Griffin/Run/run4.png",
             "/Art/Game/Enemy/Griffin/Run/run5.png","/Art/Game/Enemy/Griffin/Run/run6.png",
             "/Art/Game/Enemy/Griffin/Run/run7.png","/Art/Game/Enemy/Griffin/Run/run8.png",
        };

        protected string[] IdleGriffin =
        {
            "/Art/Game/Enemy/Griffin/Idle/idle1.png","/Art/Game/Enemy/Griffin/Idle/idle2.png",
            "/Art/Game/Enemy/Griffin/Idle/idle3.png","/Art/Game/Enemy/Griffin/Idle/idle4.png",
            "/Art/Game/Enemy/Griffin/Idle/idle5.png","/Art/Game/Enemy/Griffin/Idle/idle6.png",
            "/Art/Game/Enemy/Griffin/Idle/idle7.png","/Art/Game/Enemy/Griffin/Idle/idle8.png",
            "/Art/Game/Enemy/Griffin/Idle/idle9.png","/Art/Game/Enemy/Griffin/Idle/idle10.png",
            "/Art/Game/Enemy/Griffin/Idle/idle11.png","/Art/Game/Enemy/Griffin/Idle/idle12.png",
            "/Art/Game/Enemy/Griffin/Idle/idle13.png","/Art/Game/Enemy/Griffin/Idle/idle14.png",
            "/Art/Game/Enemy/Griffin/Idle/idle15.png","/Art/Game/Enemy/Griffin/Idle/idle16.png",
            "/Art/Game/Enemy/Griffin/Idle/idle17.png","/Art/Game/Enemy/Griffin/Idle/idle18.png",
            "/Art/Game/Enemy/Griffin/Idle/idle19.png","/Art/Game/Enemy/Griffin/Idle/idle20.png",
            "/Art/Game/Enemy/Griffin/Idle/idle21.png","/Art/Game/Enemy/Griffin/Idle/idle22.png",
            "/Art/Game/Enemy/Griffin/Idle/idle23.png","/Art/Game/Enemy/Griffin/Idle/idle24.png",
        };

        protected string[] DeathGriffin =
        {
            "/Art/Game/Enemy/Griffin/Death/death1.png","/Art/Game/Enemy/Griffin/Death/death2.png",
            "/Art/Game/Enemy/Griffin/Death/death3.png","/Art/Game/Enemy/Griffin/Death/death4.png",
            "/Art/Game/Enemy/Griffin/Death/death5.png","/Art/Game/Enemy/Griffin/Death/death6.png",
            "/Art/Game/Enemy/Griffin/Death/death7.png","/Art/Game/Enemy/Griffin/Death/death8.png",
            "/Art/Game/Enemy/Griffin/Death/death9.png","/Art/Game/Enemy/Griffin/Death/death10.png",
            "/Art/Game/Enemy/Griffin/Death/death11.png","/Art/Game/Enemy/Griffin/Death/death12.png",
            "/Art/Game/Enemy/Griffin/Death/death13.png","/Art/Game/Enemy/Griffin/Death/death14.png",
        };

        protected string[] AttackGriffin =
       {
            "/Art/Game/Enemy/Griffin/Attack/attack1.png","/Art/Game/Enemy/Griffin/Attack/attack2.png",
            "/Art/Game/Enemy/Griffin/Attack/attack3.png","/Art/Game/Enemy/Griffin/Attack/attack4.png",
            "/Art/Game/Enemy/Griffin/Attack/attack5.png","/Art/Game/Enemy/Griffin/Attack/attack6.png",
            "/Art/Game/Enemy/Griffin/Attack/attack7.png","/Art/Game/Enemy/Griffin/Attack/attack8.png",
            "/Art/Game/Enemy/Griffin/Attack/attack9.png","/Art/Game/Enemy/Griffin/Attack/attack10.png",
            "/Art/Game/Enemy/Griffin/Attack/attack11.png","/Art/Game/Enemy/Griffin/Attack/attack12.png",
            "/Art/Game/Enemy/Griffin/Attack/attack13.png","/Art/Game/Enemy/Griffin/Attack/attack14.png",

        };

        protected string[] StunnedGriffin =
        {
            "/Art/Game/Enemy/Griffin/Death/death2.png"
        };
        private void AnimateRuntoRightGriffin()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > RunGriffin.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(RunGriffin[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateRuntoLeftGriffin()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > RunGriffin.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(RunGriffin[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateIdleGriffin()
        {
            if (count > IdleGriffin.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(IdleGriffin[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        public void AnimateDeathGriffin()
        {
            while(count != 13)
            {
                if (count > DeathGriffin.Length - 1)
                    count = 0;
                Image = new BitmapImage(new Uri(DeathGriffin[count], UriKind.RelativeOrAbsolute));
                count++;
            }
        }

        private void AnimateAttacktoRightGriffin()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > AttackGriffin.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(AttackGriffin[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 6)
            {
                Attacking = true;
            }
        }

        private void AnimateAttacktoLeftGriffin()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > AttackGriffin.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(AttackGriffin[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 6)
            {
                Attacking = true;
            }
        }

        public void AnimateStunnGriffin()
        {
            if (count > StunnedGriffin.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(StunnedGriffin[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        public static void PlayEnemyAnimation(Player player, ObservableCollection<Enemy> Enemies)
        {
                foreach (Enemy enemy in Enemies)
                {
                    if (enemy.X >= player.X - 500 && enemy.X <= player.X + 1300 && !enemy.IsDead)
                    {

                        if (enemy.Name == "skeleton")
                        {
                            if (enemy.Health <= 0 && !enemy.IsDead)
                            {
                                enemy.AnimateDeathSkeleton();
                                enemy.IsDead = true;
                                player.KillCounter += 1;
                            }
                            else if ((enemy.X - player.X) < 55 && enemy.IsLeft && player.Y == 490 && !player.IsDead)
                            {
                                enemy.AnimateAttacktoLeftSkeleton();
                                if(enemy.Attacking)
                                {
                                    player.Health -= enemy.Damage;
                                    enemy.Attacking = false;
                                }
                            }
                            else if ((player.X - enemy.X) < 60 && enemy.IsRight && player.Y == 490 && !player.IsDead)
                            {
                                enemy.AnimateAttacktoRightSkeleton();
                                if (enemy.Attacking)
                                {
                                    player.Health -= enemy.Damage;
                                    enemy.Attacking = false;
                                }
                            }
                            else
                            {
                                enemy.AnimateIdleSkeleton();
                            }
                        }
                        else if (enemy.Name == "mushroom")
                        {
                            if (enemy.Health <= 0 && !enemy.IsDead)
                            {
                                enemy.AnimateDeathMushroom();
                                enemy.IsDead = true;
                                player.KillCounter += 1;
                            }
                            else if ((enemy.X - player.X) < 105 && enemy.IsLeft && player.Y == 490 && !player.IsDead)
                            {
                                enemy.AnimateAttacktoLeftMushroom();
                                if (enemy.Attacking)
                                {
                                    player.Health -= enemy.Damage;
                                    enemy.Attacking = false;
                                }
                            }
                            else if ((player.X - enemy.X) < 85 && enemy.IsRight && player.Y == 490 && !player.IsDead)
                            {
                                enemy.AnimateAttacktoRightMushroom();
                                if (enemy.Attacking)
                                {
                                    player.Health -= enemy.Damage;
                                    enemy.Attacking = false;
                                }
                            }
                            else
                            {
                                enemy.AnimateIdleMushroom();
                            }

                        }
                        else if (enemy.Name == "griffin")
                        {
                            if (enemy.Health <= 0 && !enemy.IsDead)
                            {
                                enemy.AnimateDeathGriffin();
                                enemy.IsDead = true;
                                player.KillCounter += 1;
                            }
                            else if ((enemy.X - player.X) < 105 && enemy.IsLeft && player.Y == 490 && !player.IsDead )
                            {
                                enemy.AnimateAttacktoLeftGriffin();
                                if (enemy.Attacking)
                                {
                                    player.Health -= enemy.Damage;
                                    enemy.Attacking = false;
                                }
                            }
                            else if ((player.X - enemy.X) < 165 && enemy.IsRight && player.Y == 490 && !player.IsDead)
                            {
                                enemy.AnimateAttacktoRightGriffin();
                                if ((player.X - enemy.X) < 160)
                                {
                                    player.Health -= enemy.Damage; //todo ellenállás számítás
                                }
                            }
                            else
                            {
                                enemy.AnimateIdleGriffin();
                            }
                        }
                    }
                }
        }

        public bool PlayerSpotted(Player player)
        {
            if (player.X >= this.X + 400)
                return followPlayer == true;
            else if (player.X <= this.X - 400)
                return followPlayer == true;
            else return followPlayer == false;
        }

        public static void Follow(Player player, ObservableCollection<Enemy> Enemies)
        {
            foreach (Enemy enemy in Enemies)
            {
                if (player.X < enemy.X && enemy.PlayerSpotted(player) && !enemy.IsDead && !player.IsDead )
                {
                    if (enemy.Name == "skeleton" && player.X + 50 < enemy.X)
                    {
                        enemy.X -= 3;
                        enemy.AnimateRuntoLeftSkeleton();
                        enemy.IsLeft = true;
                        enemy.IsRight = false;
                    }
                    else if (enemy.Name == "mushroom" && player.X + 105 < enemy.X)
                    {
                        enemy.X -= 6;
                        enemy.AnimateRuntoLeftMushroom();
                        enemy.IsLeft = true;
                        enemy.IsRight = false;
                    }
                    else if (enemy.Name == "griffin" && player.X + 100 < enemy.X)
                    {
                        enemy.X -= 6;
                        enemy.AnimateRuntoLeftGriffin();
                        enemy.IsLeft = true;
                        enemy.IsRight = false;
                    }
                }
                else if (player.X > enemy.X && enemy.PlayerSpotted(player) && !enemy.IsDead && !player.IsDead )
                {
                    if (enemy.Name == "skeleton" && player.X- 50 > enemy.X)
                    {
                        enemy.X += 3;
                        enemy.AnimateRuntoRightSkeleton();
                        enemy.IsLeft = false;
                        enemy.IsRight = true;
                    }
                    else if (enemy.Name == "mushroom" && player.X-40 > enemy.X)
                    {
                        enemy.X += 6;
                        enemy.AnimateRuntoRightMushroom();
                        enemy.IsLeft = false;
                        enemy.IsRight = true;
                    }
                    else if (enemy.Name == "griffin" && player.X - 145 > enemy.X)
                    {
                        enemy.X += 6;
                        enemy.AnimateRuntoRightGriffin();
                        enemy.IsLeft = false;
                        enemy.IsRight = true;
                    }
                }
            }
        }

    }
}
