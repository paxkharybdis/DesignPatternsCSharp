using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public class UltraWheel
    {
        private int _size;

        public UltraWheel(int _size)
        {
            this._size = _size;
        }

        public virtual int WheelSize
        {
            get { return _size; }
        }

        public override string ToString()
        {
            return "ULTRA wHEEL " + _size;
        }
    }
}
