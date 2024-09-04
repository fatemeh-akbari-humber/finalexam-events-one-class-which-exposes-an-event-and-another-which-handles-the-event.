using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static finalexam1.Program;

namespace finalexam1
{
    internal class CheckVolume
    {
        public event volumeChangedEventHandler VolumeChanged;

        private int volume;

        public int Volume
        {
            get => volume;
            set
            {
                if (volume != value)
                {
                    volume = value;
                    OnVolumeChanged(new VolumeChangeEventArgs(volume));
                }
            }
        }

        protected virtual void OnVolumeChanged(VolumeChangeEventArgs e)
        {
            VolumeChanged?.Invoke(this, e);
        }
    }
}
