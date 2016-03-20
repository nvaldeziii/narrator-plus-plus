using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace TestProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize a new instance of the SpeechSynthesizer.
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {

                // Output information about all of the installed voices. 
                Console.WriteLine("Installed voices -");
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    string AudioFormats = "";
                    foreach (SpeechAudioFormatInfo fmt in info.SupportedAudioFormats)
                    {
                        AudioFormats += String.Format("{0}\n",
                        fmt.EncodingFormat.ToString());
                    }
                
                    textBox1.Text += " Name:          " + info.Name + "\n\r";
                    textBox1.Text += " Culture:       " + info.Culture + '\n';
                    textBox1.Text += " Age:           " + info.Age + '\n';
                    textBox1.Text += " Gender:        " + info.Gender + '\n';
                    textBox1.Text += " Description:   " + info.Description + '\n';
                    textBox1.Text += " ID:            " + info.Id + '\n';
                    textBox1.Text += " Enabled:       " + voice.Enabled + '\n';
                    if (info.SupportedAudioFormats.Count != 0)
                    {
                        textBox1.Text += " Audio formats: " + AudioFormats + '\n';
                    }
                    else
                    {
                        textBox1.Text += " No supported audio formats found" + '\n';
                    }

                    string AdditionalInfo = "";
                    foreach (string key in info.AdditionalInfo.Keys)
                    {
                        AdditionalInfo += String.Format("  {0}: {1}\n", key, info.AdditionalInfo[key]);
                    }

                    textBox1.Text += " Additional Info - " + AdditionalInfo + '\n';
                   
                }
            }
            Console.WriteLine("Press any key to exit...");
         
        }
    }
}
