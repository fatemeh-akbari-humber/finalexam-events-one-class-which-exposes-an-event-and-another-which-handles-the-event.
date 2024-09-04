namespace finalexam1
{
    internal class Program
    {
        public delegate void volumeChangedEventHandler(object sender, VolumeChangeEventArgs e);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CheckVolume checkVolume = new CheckVolume();
            VolumeMonitor monitor = new VolumeMonitor();

            checkVolume.VolumeChanged += monitor.OnVolumeChanged;

     
            checkVolume.Volume =20;
            checkVolume.Volume = 30;

        }
    }
}
