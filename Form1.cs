using System.Media;

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
    }
}
