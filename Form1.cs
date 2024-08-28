using System.Media;
using NAudio;
using NAudio.Wasapi;
using NAudio.Wave;

namespace TheAudioVisualiser

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Plays a specific .wav file. Next step is to listen for auido coming from the PC
        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"D:\04 Music Collection\Pr0xima - Carrier Phreakuency.wav");
            splayer.Play();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {

        }

        //Adds current audio device names to the combo box.
        private void btnGetDevices_Click(object sender, EventArgs e)
        {
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");
                comboBox1.Items.Add(caps.ProductName);
            }
        }
    }
}
