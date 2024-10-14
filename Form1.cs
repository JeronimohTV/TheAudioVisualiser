using System.Media;
using NAudio;
using NAudio.Wasapi;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace TheAudioVisualiser

{

    public partial class Form1 : Form
    {
        //string filePath = Application.StartupPath.;

        public Form1()
        {
            InitializeComponent();
            sourceList.Items.Clear();
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboDevices.Items.AddRange(devices.ToArray());

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

        private void btnSources_Click(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            //

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                sourceList.Items.Add(item);
            }
        }

        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(48000, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(waveIn);

            sourceStream.StartRecording();
            waveOut.Play();


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }

            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            this.Close();
        }

       
        private void timer_Tick(object sender, EventArgs e)
        {
            if (comboDevices.SelectedItem != null)
            { 
                var device = (MMDevice)comboDevices.SelectedItem;
                progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));

            }
        }
    }
}
