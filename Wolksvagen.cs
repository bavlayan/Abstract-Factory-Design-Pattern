﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Wolksvagen : Car
    {
        public override void CreateEngine()
        {
            Console.WriteLine("Engine has been attached to Wolkswagen Car..");
        }

        public override void CreateHeadLight()
        {
            Console.WriteLine("Headlight has been attached to Wolkswagen Car..");
        }

        public override void CreateWheel()
        {
            Console.WriteLine("Wheel has been attached to Wolkswagen Car..");
        }
    }
}
