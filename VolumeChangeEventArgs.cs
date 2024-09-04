using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam1
{
    public class VolumeChangeEventArgs : EventArgs
    {
        public double NewVolume { get; set; }

        public VolumeChangeEventArgs(double newVolume)
        {
            NewVolume = newVolume;
        }
    }
}


