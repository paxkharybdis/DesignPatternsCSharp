using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Visitor
{
    public class Spokes : IVisitAble
    {
        public void AcceptVisitor(IWheelVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
