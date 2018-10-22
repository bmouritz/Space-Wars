﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.src
{
    public class Player : GameObject, IDraw
    {
        private float _xShip, _yShip;
        private float _speed;
        private Bitmap _type;
        GameObject ship = new GameObject(new string[] { "ship" } );
        WeaponManager _weapon = new WeaponManager();

        public Player(string[] name) : base(new string[] { "Player" } )
        {
            _speed = 10;
            XShip = 100;
            YShip = 100;
        }

        /// <summary>
        /// This allows the player to move.
        /// </summary>
        public void MoveShip()
        {
            WrapObject();
            if (SwinGame.KeyDown(KeyCode.LeftKey))
            {
                XShip -= ship.ChangeX(Speed);
            }

            if (SwinGame.KeyDown(KeyCode.RightKey))
            {
                XShip += ship.ChangeX(Speed);
            }

            if (SwinGame.KeyDown(KeyCode.UpKey))
            {
                YShip -= ship.ChangeY(Speed);
            }

            if (SwinGame.KeyDown(KeyCode.DownKey))
            {
                YShip += ship.ChangeY(Speed);
            }
        }

        /// <summary>
        /// This wraps the object around the screen.
        /// </summary>
        public void WrapObject()
        {
            if (XShip < -((SwinGame.BitmapWidth(base.Type))))
            {
                XShip = SwinGame.ScreenWidth();
            }

            else if (this.XShip > SwinGame.ScreenWidth())
            {
                XShip = -SwinGame.BitmapWidth(base.Type);
            }

            if (this.YShip < (-(SwinGame.BitmapHeight(this.Type))))
            {
                this.YShip = (SwinGame.ScreenHeight());
            }

            else if (this.YShip > SwinGame.ScreenHeight())
            {
                this.YShip = -(SwinGame.BitmapHeight(this.Type));
            }
        }

        /// <summary>
        /// This allows the player to shoot itself weapon
        /// </summary>
        /// <param name="type">What type of laser will be created.</param>
        public void Shoot(Bitmap type)
        {
            Weapon.ShootWeapon(type, XShip, YShip);
        }

        public override void Draw()
        {
            SwinGame.DrawBitmap(this.Type , XShip, YShip);
        }

        public float Speed { get => _speed; set => _speed = value; }
        public float XShip { get => _xShip; set => _xShip = value; }
        public float YShip { get => _yShip; set => _yShip = value; }
        public WeaponManager Weapon { get => _weapon; set => _weapon = value; }
        public Bitmap Type { get => _type; set => _type = value; }
    }
}
