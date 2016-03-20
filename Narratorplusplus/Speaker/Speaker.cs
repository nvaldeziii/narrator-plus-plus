using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace Narratorplusplus.Speaker
{
    class Speaker
    {

        SpeechSynthesizer synth = new SpeechSynthesizer();

        public Speaker SetVoice(string voice) { this.Voice = voice; return this; }
        public Speaker SetRate(int rate) { this.Rate = rate; return this; }
        public Speaker SetVolume(int volume) { this.Volume = volume; return this; }

        public void Update()
        {
            synth.SelectVoice(Voice);
            synth.Rate = Rate;
            synth.Volume = Volume;
        }

        public void Read(string text)
        {
            synth.SpeakAsyncCancelAll();
            synth.SpeakAsync(text);
        }

        public string Voice { get; set; }
        public int Rate { get; set; }
        public int Volume { get; set; }
    }
}
