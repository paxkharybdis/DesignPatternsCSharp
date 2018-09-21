﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public abstract class AbstractBike : IBicycle
    {
        private IWheel _wheel;
        private BikeColor _color;

        public BikeColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public virtual IWheel Wheel
        {
            get
            {
                return _wheel;
            }
        }

        public abstract decimal Price { get; }

        public AbstractBike(IWheel wheel)
            : this(wheel, BikeColor.Chrome)
        {

        }

        public AbstractBike(IWheel wheel, BikeColor color)
            {
                this._wheel = wheel;
                this._color = color;
            }

        public virtual void Paint(BikeColor color)
            {
                this._color = color;
            }

        public virtual void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame...");
        }

        public virtual void AirTires()
        {
            Console.WriteLine("Filling Tires...");
        }

        public virtual void TestRide()
        {
            Console.WriteLine("Taking bike for test ride...");
        }


        public override string ToString()
            {
                return this.GetType().Name + " Bicycle Color has a "+_wheel+ " and the color is " + _color + "and it costs $"+Price;
            }



    }
}
