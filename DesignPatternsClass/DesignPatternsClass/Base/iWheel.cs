﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;
using Visitor;

namespace DesignPatternsClass
{
    public interface IWheel : IVisitAble
    {
        int Size { get; }
        bool Wide { get; }

    }
}
