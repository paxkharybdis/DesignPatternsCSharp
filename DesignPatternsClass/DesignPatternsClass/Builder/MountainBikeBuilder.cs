﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Builder
{
    class MountainBikeBuilder : BikeBuilder
    {
        private AbstractMountainBike mountainBikeInProgress;

        public override IBicycle Bicycle
        {
            get { return mountainBikeInProgress; }
        }

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this.mountainBikeInProgress = mountainBike;
        }

        public override void BuildHandlebars()
        {
            Console.WriteLine("Building Mountainbike Handlebars.");
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("Building Mountainbike Street Tires.");
        }

    }
}
