﻿using SantaFactory01.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaFactory01.Entities
{
   public class CarFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
