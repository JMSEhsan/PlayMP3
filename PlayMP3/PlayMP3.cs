using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PlayMP3
{

    public partial class PlayMP3 : Form
    {
         WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        //private SoundPlayer Player = new SoundPlayer();
     
        public PlayMP3()
        {   
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Note: You may need to change the location specified based on
            //    // the sounds loaded on your computer.
            //    this.Player.SoundLocation = @"C:\Users\se_ja\OneDrive\Documents\Projects\PlayMp3CS\PartyingInRussia.mp3";
            //    this.Player.PlayLooping();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error playing sound");
            //}

            player.URL = /* @"C:\Windows\Media\chimes.wav"; */ @"C:\Users\se_ja\OneDrive\Documents\Projects\PlayMp3CS\PartyingInRussia.mp3";
                                                         // player.settings.setMode("loop", true);
            
            player.controls.play();
         //   player.settings.setMode("loop", false);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
           player.controls.stop();
        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            // player.URL = @"C:\Users\se_ja\OneDrive\Documents\Projects\PlayMp3CS\PartyingInRussia.mp3";
            if (checkBox1.Checked)
            {
                player.settings.setMode("loop", true);
            }
            else
            {
                player.settings.setMode("loop", false);
            }
                
           // player.controls.play();

        }
     
    }
}
