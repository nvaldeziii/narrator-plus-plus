using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace Narratorplusplus.Settings
{
    class SettingsHandler
    {
        public SettingsHandler()
        {
            
        }

        public string[] InstalledVoices(Func<int,string> condition)
        {
            using(SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                string[] voices = new string[synth.GetInstalledVoices().Count];
                for(int i = 0; i<voices.Length;i++)
                {
                    voices[i] = condition(i);   
                }

                return voices;
            }    
        }

    }
}
