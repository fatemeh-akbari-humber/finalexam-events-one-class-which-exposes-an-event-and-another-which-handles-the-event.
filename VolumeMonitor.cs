using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam1
{
    public class VolumeMonitor
    {

        public void OnVolumeChanged(object sender, VolumeChangeEventArgs e)
        {
            Console.WriteLine($"Volume changed to: {e.NewVolume} Volume.");
        }
    }
}
