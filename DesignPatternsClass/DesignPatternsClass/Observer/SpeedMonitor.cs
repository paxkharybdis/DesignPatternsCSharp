using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Observer
{
    class SpeedMonitor
    {
        public const int SpeedToAlert = 30;

        public SpeedMonitor(Speedometer speed)
        {
            speed.ValueChanged += valueHasChanged;
        }

        private void valueHasChanged(object sender, EventArgs e)
        {
            Speedometer mySpeed = (Speedometer)sender;
            if(mySpeed.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine("** Riding TOO FAST!! (" + mySpeed.CurrentSpeed + ")");
            }
            else
            {
                Console.WriteLine("... nice and steady ...(" + mySpeed.CurrentSpeed + ")");
            }
        }
    }
}
