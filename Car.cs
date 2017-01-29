﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class Car
    {
        public abstract void CreateEngine();
        public abstract void CreateWheel();
        public abstract void CreateHeadLight();
    }
}