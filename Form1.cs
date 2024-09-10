using System.Media;
using NAudio;
using NAudio.Wasapi;
using NAudio.Wave;

namespace TheAudioVisualiser

{
    
    public partial class Form1 : Form
    {
        //string filePath = Application.StartupPath.;

        public Form1()
        {
            InitializeComponent();
        }

        //Plays a specific .wav file from within the project: Pr0xima - Carrier Phreakuency.wav.
        //Next step is to listen for Audio coming from the desktop 
        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"SoundFiles\Pr0xima - Carrier Phreakuency.wav");
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
