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
using System.Runtime.InteropServices;

namespace Narratorplusplus
{
    public partial class Narratorplusplus : Form
    {

        Settings.SettingsHandler setting = new Settings.SettingsHandler();
        Speaker.SpeakerHandler speakerHandler = new Speaker.SpeakerHandler();
        Speaker.Speaker speaker = new Speaker.Speaker();

        KeyboardHook hook = new KeyboardHook();
        
        public Narratorplusplus()
        {
            InitializeComponent();
            speaker = speakerHandler.Talker;


            // register the event that is fired after the key press.
            hook.KeyPressed +=new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(global::Narratorplusplus.ModifierKeys.Control|global::Narratorplusplus.ModifierKeys.Shift,
            Keys.S);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
                speaker.Read(Clipboard.GetText());
        }


        private void Narratorplusplus_Load(object sender, EventArgs e)
        {

            cb_InstalledVoices.Items.AddRange(setting.InstalledVoices((i) =>  (new SpeechSynthesizer()).GetInstalledVoices()[i].VoiceInfo.Name));
            cb_InstalledVoices.SelectedIndex = 0;
            num_Rate.Value = speaker.Rate;
            num_Volume.Value = speaker.Volume;
        
        }

        private void btn_applySetting_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            speaker.Read(tb_test.Text);
        }

        private void num_Rate_ValueChanged(object sender, EventArgs e)
        {
            speaker.Rate = Convert.ToInt32(num_Rate.Value);
            speaker.Update();
        }

        private void num_Volume_ValueChanged(object sender, EventArgs e)
        {
            speaker.Volume = Convert.ToInt32(num_Volume.Value);
            speaker.Update();
        }

        private void cb_InstalledVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            speaker.Voice = cb_InstalledVoices.SelectedItem.ToString();
            speaker.Update();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
