﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.src
{
    public class EnemyBase : IEnemy
    {
        private float _x, _y;
        private Bitmap _type;
        private float _speed;

        public EnemyBase(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Move()
        {
            this.X -= this.Speed;
        }

        public virtual void Draw()
        {
            SwinGame.DrawBitmap(this.Type, this.X, this.Y);
            Move();
        }

        public Bitmap Type { get => _type; set => _type = value; }
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public float Speed { get => _speed; set => _speed = value; }
    }
}