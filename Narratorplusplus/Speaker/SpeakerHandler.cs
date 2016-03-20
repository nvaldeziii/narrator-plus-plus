using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;

namespace Narratorplusplus.Speaker
{
    class SpeakerHandler
    {
        Speaker speaker;

        public SpeakerHandler()
        {
            speaker = new Speaker()
                .SetRate(0)
                .SetVoice((new SpeechSynthesizer()).GetInstalledVoices()[0].VoiceInfo.Name)
                .SetVolume(100);
        }

        public Speaker Talker { get { return speaker; } }

    }
}
