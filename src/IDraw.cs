﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.src
{
    public interface IDraw
    {
        void Draw();
        Bitmap Type { get; set; }
    }
}
