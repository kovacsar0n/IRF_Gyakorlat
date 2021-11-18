﻿using SantaFactory01.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaFactory01.Entities
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            var image = Image.FromFile("Images/car.png");
            g.DrawImage(image, 0, 0, Width, Height);
        }
    }
}
