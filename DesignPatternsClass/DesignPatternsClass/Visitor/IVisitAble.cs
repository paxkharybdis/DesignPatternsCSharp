using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Visitor
{
    public interface IVisitAble
    {
        void AcceptVisitor(IWheelVisitor visitor);
    }
}
