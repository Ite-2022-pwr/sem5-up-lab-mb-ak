using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using NAudio.Wave;


namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {

        private string ReadWavHeader(string filename)
        {

            string headerString = "Wav header \n";

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(fileStream);

            string riffChunkId = Encoding.ASCII.GetString(reader.ReadBytes(4));
            headerString += "riffchunkid: " + Convert.ToString(riffChunkId) + "\n";

            int riffChunkSize = reader.ReadInt32();
            headerString += "riffchunksize: " + Convert.ToString(riffChunkSize) + "\n";


            string waveFormat = Encoding.ASCII.GetString(reader.ReadBytes(4));
            headerString += "format: " + Convert.ToString(waveFormat) + "\n";

            string fmt = Encoding.ASCII.GetString(reader.ReadBytes(4));

            int fmtChunkSize = reader.ReadInt32();

            headerString += "fmtchunksize: " + Convert.ToString(fmtChunkSize) + "\n";

            // PCM = 1, If it is other than 1 it means that the file is compressed.
            short audioFormat = reader.ReadInt16();

            Console.WriteLine(audioFormat);

            // Mono = 1; Stereo = 2
            short numberOfChannels = reader.ReadInt16();

            Console.WriteLine(numberOfChannels);

            // 8000, 44100, etc.
            int samplesPerSecond = reader.ReadInt32();
            Console.WriteLine(samplesPerSecond);

            // Byte Rate = SampleRate * NumChannels * BitsPerSample/8
            int avgBytePerSecond = reader.ReadInt32();
            Console.WriteLine(avgBytePerSecond);

            // Block Align = NumChannels * BitsPerSample / 8
            short blockAlign = reader.ReadInt16();
            Console.WriteLine(blockAlign);

            // 8 bits = 8, 16 bits = 16, etc.
            short bitsPerSample = reader.ReadInt16();
            Console.WriteLine(bitsPerSample);

            if (fmtChunkSize == 18)
            {
                // size of the extension: 0
                short extensionSize = reader.ReadInt16();
            }
            else if (fmtChunkSize == 40)
            {
                // size of the extension: 22
                short extensionSize = reader.ReadInt16();

                // Should be lower or equal to bitsPerSample
                short validBitsPerSample = reader.ReadInt16();

                // Speaker position mask
                int channelMask = reader.ReadInt32();

                // GUID(first two bytes are the data format code)
                byte[] subFormat = reader.ReadBytes(16);
            }
            else if (fmtChunkSize != 16)
            {
                throw new Exception("Invalid .wav format!");
            }

            string nextSection = Encoding.ASCII.GetString(reader.ReadBytes(4));
            if (nextSection == "fact")
            {
                // Chunk size: 4
                int factChunkSize = reader.ReadInt32();

                // length of the sample
                int sampleLength = reader.ReadInt32();
                Console.WriteLine(sampleLength);

                // Check what is the next section
                nextSection = Encoding.ASCII.GetString(reader.ReadBytes(4));
            }
            else if (nextSection != "data")
            {
                throw new NotImplementedException();
            }

            // Contains the letters "data"
            string dataChunkId = nextSection;

            // This is the number of bytes in the data.
            int dataChunkSize = reader.ReadInt32();

            return headerString;
        }

        private string ReadMp3Header(string filename)
        {
            using (FileStream fs = File.OpenRead(filename))
            {
                if (fs.Length >= 128)
                {
                    MusicID3Tag tag = new MusicID3Tag();
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(tag.TAGID, 0, tag.TAGID.Length);
                    fs.Read(tag.Title, 0, tag.Title.Length);
                    fs.Read(tag.Artist, 0, tag.Artist.Length);
                    fs.Read(tag.Album, 0, tag.Album.Length);
                    fs.Read(tag.Year, 0, tag.Year.Length);
                    fs.Read(tag.Comment, 0, tag.Comment.Length);
                    fs.Read(tag.Genre, 0, tag.Genre.Length);
                    string theTAGID = Encoding.Default.GetString(tag.TAGID);

                    if (theTAGID.Equals("TAG"))
                    {
                        string Title = Encoding.Default.GetString(tag.Title);
                        string Artist = Encoding.Default.GetString(tag.Artist);
                        string Album = Encoding.Default.GetString(tag.Album);
                        string Year = Encoding.Default.GetString(tag.Year);
                        string Comment = Encoding.Default.GetString(tag.Comment);
                        string Genre = Encoding.Default.GetString(tag.Genre);

                        return "title: " + Title + "\nArtist: " + Artist + "\n Album: " + Album + "\nYear: " + Year + "\n Comment: " + Comment + "\nGenre: " + Genre;

                    } else
                    {
                        throw new Exception("error");
                    }
                } else
                {
                    throw new Exception("Error");
                }
            }
        }

        private void ModifyAudio(string filePath)
        {

            var audio = new NAudio.Wave.AudioFileReader(filePath);
            var fade = new NAudio.Wave.SampleProviders.FadeInOutSampleProvider(audio, true);
            fade.BeginFadeIn(2000);
            fade.BeginFadeOut(2000);

            NAudio.Wave.WaveFileWriter.CreateWaveFile(filePath + "_fade.wav", new NAudio.Wave.SampleProviders.SampleToWaveProvider(fade));

        }





        private string filePath = "";
        private string fileRecordPath = "";
        private string mp3FilePath = "";
        private bool played = false;
        private System.Media.SoundPlayer sPlayer = new System.Media.SoundPlayer();
        WaveIn sourceStream = null;
        DirectSoundOut soundOut = null;
        WaveFileWriter waveFileWriter = null;

        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFileWriter == null)
                return;

            waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveFileWriter.Flush();
        }

        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        [System.Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        public Form1()
        {
            InitializeComponent();
            playSoundBtn.Click += playSoundBtn_Click;
        }

        private void playSoundBtn_Click(object sender, EventArgs args)
        {
            if (played)
            {
                sPlayer.Stop();
                played = !played;
                return;
            }

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Audio files (.wav)|*.wav";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                filePathLabel.Text = $"Wybrany plik: {filePath}";
                sPlayer.SoundLocation = filePath;
                sPlayer.Load();
                sPlayer.Play();
                played = !played;

                string headerText = ReadWavHeader(filePath);
                label1.Text = headerText;



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findMicBTN_Click(object sender, EventArgs e)
        {
            micList.Items.Clear();

            List<WaveInCapabilities> sources = new List<WaveInCapabilities>();

            for (int i = 0; i < WaveIn.DeviceCount; i++)
                sources.Add(WaveIn.GetCapabilities(i));

            int counter = 0;
            foreach (var source in sources)
            {
                string item = source.ProductName;
                micList.Items.Add(item);
                counter++;
            }
        }

        private void selectWriteLocationBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;
            else
                fileRecordPath = save.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileRecordPath = recordFileNameTXT.Text;
            if (button1.Text == "Nagraj dzwiek")
            {
                if (micList.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Nie wybrano urzadzenia nagrywania");
                    return;
                }

                if (fileRecordPath == string.Empty)
                {
                    MessageBox.Show("Podaj nazwe pliku do zapisu");
                    return;
                }
                else
                {
                    int deviceNumber = micList.SelectedIndex;

                    sourceStream = new WaveIn();
                    sourceStream.DeviceNumber = deviceNumber;
                    sourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);
                    sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
                    waveFileWriter = new WaveFileWriter(fileRecordPath, sourceStream.WaveFormat);

                    sourceStream.StartRecording();

                    button1.Text = "Stop recording";
                }

                button1.Text = "Zatrzymaj nagrywanie";
            }
            else if (button1.Text == "Zatrzymaj nagrywanie")
            {
                if (soundOut != null)
                {
                    soundOut.Stop();
                    soundOut.Dispose();
                    soundOut = null;
                    button1.Text = "Nagraj dzwiek";
                }
                if (sourceStream != null)
                {
                    sourceStream.StopRecording();
                    sourceStream.Dispose();
                    sourceStream = null;
                    button1.Text = "Nagraj dzwiek";
                }
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                    waveFileWriter = null;
                    button1.Text = "Nagraj dzwiek";
                }
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mp3headerReadBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Audio files (.mp3)|*.mp3";
            if (file.ShowDialog() == DialogResult.OK)
            {
                mp3FilePath = file.FileName;


                string mp3HeaderText = ReadMp3Header(mp3FilePath);

                mp3HeaderLBL.Text = mp3HeaderText;



            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    class MusicID3Tag

    {

        public byte[] TAGID = new byte[3];      //  3
        public byte[] Title = new byte[30];     //  30
        public byte[] Artist = new byte[30];    //  30 
        public byte[] Album = new byte[30];     //  30 
        public byte[] Year = new byte[4];       //  4 
        public byte[] Comment = new byte[30];   //  30 
        public byte[] Genre = new byte[1];      //  1

    }

}
