﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Visitor
{
    public class WheelInventory : IWheelVisitor
    {
        private int _spokesCount;
        private int _bearingsCount;

        public WheelInventory()
        {
            _spokesCount = 29;
            _bearingsCount = 2;
        }

        public void Visit(IWheel wheel)
        {
            Console.WriteLine("The has: " + _spokesCount + " spokes and " +
                _bearingsCount + " bearings.");
        }

        public void Visit(Spokes spokes)
        {
            _spokesCount++;
        }

        public void Visit(Bearings bearings)
        {
            _bearingsCount++;
        }
    }
}
