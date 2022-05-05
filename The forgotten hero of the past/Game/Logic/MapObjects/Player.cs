using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Logic.MapObjects
{
    public class Player : MapObject
    {
        private int count;
        private static int Ground = 490;
        private int health = 350;
        private int damage = 25;
        private bool direction = false;
        private int killcounter = 0;
        private static int maxHP = 100;

        public static int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public int KillCounter
        {
            get { return killcounter; }
            set { killcounter = value; NotifyPropertyChanged(); }
        }
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

        private int gold = 0;

        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                NotifyPropertyChanged();
            }
        }

        private int screenwidth = 30000;

        public Player(double x, double y, int width, int height) : base(x, y, width, height) {}
        public Player() : this(10, Ground, 200, 200) {}

        public void KeyDown(object sender, KeyEventArgs e)
        {
                switch (e.Key)
                {
                    case Key.A: IsLeft = true; direction = true; break;
                    case Key.D: IsRight = true; direction = false; break;
                    case Key.W: Jumping = true; break;
                    case Key.Space: IsAttack = true; break;
                }      
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A: IsLeft = false; break;
                case Key.D: IsRight = false; break;
                case Key.W: Jumping = false; break;
                case Key.Space: IsAttack = false; break;
                case Key.H: HP(); break;
                case Key.M: MS(); break;
                case Key.P: DM(); break;
            }
        }

        private void DM()
        {
            if (Gold >= 5)
            {
                Gold -= 5;
                Damage += 10;
            }
        }

        public void Jump(object sender, KeyEventArgs e)
        {
            if (Y == Ground || CollisionDetection.CollisionDetection.OnPlatform)
            {
                JumpStrength = -50;
                Jumping = false;
            }
        }

        public void JumpDown(object sender, KeyEventArgs e)
        {
            if (JumpStrength < -12.5)
            {
                JumpStrength = -12.5;
            }
            
        }

        public void InitializeMovement(ObservableCollection<Rect> platform)
        {
            if (!IsDead)
            {
                if (IsRight && X + Width < screenwidth && !CollisionDetection.CollisionDetection.PlayerRightCollision(this, platform))
                    MoveRight();
                if (IsLeft && X > 0 && !CollisionDetection.CollisionDetection.PlayerLeftCollision(this, platform))
                    MoveLeft();
                if (Jumping && Y > 30)
                    Jump();
            } 
        }


        public void UpdateGravity()
        {
            if (Y > Ground)
            {
                Gravity = 0;
                Y = Ground;
            }

            if (Y < Ground)
            {
                JumpStrength += Gravity;
                Y += Gravity;
            }

            if (Gravity > 25f)
                Gravity = 25f;

            Gravity = 10f;
        }

        protected string[] JumpUp =
        {
            "/Art/Game/Character/Knight/Idle/idle1.png"
        };

        protected string[] Run =
        {
             "/Art/Game/Character/Knight/Run/run1.png","/Art/Game/Character/Knight/Run/run2.png",
             "/Art/Game/Character/Knight/Run/run3.png","/Art/Game/Character/Knight/Run/run4.png",
             "/Art/Game/Character/Knight/Run/run5.png","/Art/Game/Character/Knight/Run/run6.png",
             "/Art/Game/Character/Knight/Run/run7.png","/Art/Game/Character/Knight/Run/run8.png",
             "/Art/Game/Character/Knight/Run/run9.png","/Art/Game/Character/Knight/Run/run10.png",
        };

        protected string[] Idle =
        {
            "/Art/Game/Character/Knight/Idle/idle1.png","/Art/Game/Character/Knight/Idle/idle2.png",
            "/Art/Game/Character/Knight/Idle/idle3.png","/Art/Game/Character/Knight/Idle/idle4.png",
            "/Art/Game/Character/Knight/Idle/idle5.png","/Art/Game/Character/Knight/Idle/idle6.png",
            "/Art/Game/Character/Knight/Idle/idle7.png","/Art/Game/Character/Knight/Idle/idle8.png",
        };

        protected string[] Death =
        {
            "/Art/Game/Character/Knight/Death/death1.png","/Art/Game/Character/Knight/Death/death2.png",
            "/Art/Game/Character/Knight/Death/death3.png","/Art/Game/Character/Knight/Death/death4.png",
            "/Art/Game/Character/Knight/Death/death5.png","/Art/Game/Character/Knight/Death/death6.png",
            "/Art/Game/Character/Knight/Death/death7.png","/Art/Game/Character/Knight/Death/death8.png",
            "/Art/Game/Character/Knight/Death/death9.png","/Art/Game/Character/Knight/Death/death10.png",
        };
        protected string[] Attack =
       {
            "/Art/Game/Character/Knight/Attack/attack1.png","/Art/Game/Character/Knight/Attack/attack2.png",
            "/Art/Game/Character/Knight/Attack/attack3.png","/Art/Game/Character/Knight/Attack/attack4.png",
            "/Art/Game/Character/Knight/Attack/attack5.png"
        };

        protected string[] Stunned =
        {
            "/Art/Game/Character/Knight/Death/death1.png"
        };

        private void AnimateJumpUp()
        {
            if (count > JumpUp.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(JumpUp[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateJumpFall()
        {
            if (count > JumpUp.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(JumpUp[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateRuntoRight()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > Run.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(Run[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        private void AnimateRuntoLeft()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > Run.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(Run[count], UriKind.RelativeOrAbsolute));
            count++;
        }
        private void AnimateAttacktoRight()
        {
            Mirrored = new ScaleTransform() { ScaleX = +1 };
            if (count > Attack.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(Attack[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 3)
            {
                Attacking = true;
            }
        }

        private void AnimateAttacktoLeft()
        {
            Mirrored = new ScaleTransform() { ScaleX = -1 };
            if (count > Attack.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(Attack[count], UriKind.RelativeOrAbsolute));
            count++;
            if (count == 3)
            {
                Attacking = true;
            }
        }

        private void AnimateIdle()
        {
            if (count > Idle.Length - 1)
                count = 0;
            Image = new BitmapImage(new Uri(Idle[count], UriKind.RelativeOrAbsolute));
            count++;
        }

        public void AnimateDeath()
        {
            while(count != 9)
            {
                if (count > Death.Length - 1)
                    count = 0;
                Image = new BitmapImage(new Uri(Death[count], UriKind.RelativeOrAbsolute));
                count++;
            }
        }

        public void AnimatePlayer(ObservableCollection<Rect> Platforms, ObservableCollection<Enemy> Enemies)
        {

            if (IsRight && !Jumping && !IsDead)
                AnimateRuntoRight();

            if (IsLeft && !Jumping && !IsDead)
                AnimateRuntoLeft();

            if (!IsRight && !IsLeft && !Jumping && !IsAttack && !IsDead)
                AnimateIdle();

            if (!Jumping && IsAttack && direction && !IsLeft && !IsRight && !IsDead)
            {
                AnimateAttacktoLeft();
                foreach (Enemy enemy in Enemies)
                {
                    if (enemy.Name == "skeleton" && !enemy.IsDead)
                        {
                            if ((X - enemy.X) < 85 && enemy.IsRight)
                            {
                                    if (Attacking)
                                    {
                                        enemy.Health -= Damage; //todo ellenállás számítás
                                        Attacking = false;
                                    }
                            }
                    }
                        else if (enemy.Name == "mushroom" && !enemy.IsDead)
                        {
                            if ((X - enemy.X) < 140 && enemy.IsRight)
                            {
                                if (Attacking)
                                {
                                    enemy.Health -= Damage; //todo ellenállás számítás
                                    Attacking = false;
                                }
                            }
                        }
                        else if (enemy.Name == "griffin" && !enemy.IsDead)
                        {
                            if ((X - enemy.X) < 175 && enemy.IsRight)
                            {
                                if (Attacking)
                                {
                                    enemy.Health -= Damage; //todo ellenállás számítás
                                    Attacking = false;
                                }
                            }
                        }
                }
            }

            if (!Jumping && IsAttack && !direction && !IsLeft && !IsRight && !IsDead)
            {
                AnimateAttacktoRight();
                foreach (Enemy enemy in Enemies)
                {
                    if (enemy.X >= X - 500 && enemy.X <= X + 1300)
                    {
                        if (enemy.Name == "skeleton" && !enemy.IsDead)
                        {
                            if ((enemy.X - X) <= 85 && enemy.IsLeft)
                            {
                                 if (Attacking)
                                 {
                                    enemy.Health -= Damage; //todo ellenállás számítás
                                    Attacking = false;
                                 }
                            }
                        }
                        else if (enemy.Name == "mushroom" && !enemy.IsDead)
                        {
                            if ((enemy.X - X) <= 140 && enemy.IsLeft)
                            {
                                if (Attacking)
                                {
                                    enemy.Health -= Damage; //todo ellenállás számítás
                                    Attacking = false;
                                }
                            }
                        }
                        else if (enemy.Name == "griffin" && !enemy.IsDead) 
                        {
                            if ((enemy.X - X) <= 120 && enemy.IsLeft)
                            {
                                if (Attacking)
                                {
                                    enemy.Health -= Damage; //todo ellenállás számítás
                                     Attacking = false;
                                }
                            }
                        }
                    }

                }
            }

            if (Health <= 0 && !IsDead)
            {
                AnimateDeath();
                IsDead = true;
            }

            if (Y < Ground && Jumping )
            {
                AnimateJumpUp();

                if (Gravity < JumpStrength)
                {
                    AnimateJumpFall();
                }
            }
        }

        public void HP()
        {
            if (Gold >= 5)
            {
                if (Health < 100)
                {
                    Gold -= 5;
                    Health = 100;
                }
                else
                {
                    MaxHP += 10;
                    Gold -= 5;
                    Health = MaxHP;
                }
            }
        }

        public void MS()
        {
            if (Gold >= 5)
            {
                Gold -= 5;
                Speed += 10;
            }
        }
    }
}
