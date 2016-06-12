using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVS_Script_Creator
{
    public partial class formMain : Form
    {

        private int windowsPlayerStatus;
        

        public formMain()
        {
            InitializeComponent();
            initResizeComboBox();

            tabPage1.Text = "Create AVS";
            tabPage2.Text = "Queue";


            // Add a delegate for the PlayStateChange event.
            windowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(windowsMediaPlayer_PlayStateChange);
            windowsMediaPlayer.settings.autoStart = false;
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            formSettings.TopMost = true;
        }

        private void initResizeComboBox()
        {
            comboBoxResize.DropDownStyle = ComboBoxStyle.DropDownList;
            
            foreach(var resizeItem in Properties.Settings.Default.ResizeValues)
            {
                comboBoxResize.Items.Add(resizeItem);
            }

            comboBoxResize.Text = "1080p: 1.920 x 1.080";
        }

        private void buttonOpenVideo_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Properties.Settings.Default.VideoDefaultPath;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            this.textBoxVideo.Text = openFileDialog1.FileName.ToString();
                            windowsMediaPlayer.URL = openFileDialog1.FileName;
                            buttonTrimAddStartFrame.Enabled = true;
                            buttonTrimAddEndFrame.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
      
        private void windowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                case 0:    // Undefined
                    windowsPlayerStatus = e.newState;
                    break;

                case 1:    // Stopped
                    windowsPlayerStatus = e.newState;
                    break;

                case 2:    // Paused
                    windowsPlayerStatus = e.newState;
                    break;

                case 3:    // Playing
                    windowsPlayerStatus = e.newState;
                    break;

                case 4:    // ScanForward
                    windowsPlayerStatus = e.newState;
                    break;

                case 5:    // ScanReverse
                    windowsPlayerStatus = e.newState;
                    break;

                case 6:    // Buffering
                    windowsPlayerStatus = e.newState;
                    break;

                case 7:    // Waiting
                    windowsPlayerStatus = e.newState;
                    break;

                case 8:    // MediaEnded
                    windowsPlayerStatus = e.newState;
                    break;

                case 9:    // Transitioning
                    windowsPlayerStatus = e.newState;
                    break;

                case 10:   // Ready
                    windowsPlayerStatus = e.newState;
                    break;

                case 11:   // Reconnecting
                    windowsPlayerStatus = e.newState;
                    break;

                case 12:   // Last
                    windowsPlayerStatus = e.newState;
                    break;

                default:
                    windowsPlayerStatus = e.newState;
                    break;
            }
        }

        private void buttonTrimAddStartFrame_Click(object sender, EventArgs e)
        {
            int frameRate = (Convert.ToInt32(windowsMediaPlayer.currentMedia.getItemInfoByAtom(398)) / 1000);          
            numericUpDownTrimStart.Value = Convert.ToDecimal(windowsMediaPlayer.Ctlcontrols.currentPosition) * frameRate ;
        }

        private void buttonTrimAddEndFrame_Click(object sender, EventArgs e)
        {
            int frameRate = (Convert.ToInt32(windowsMediaPlayer.currentMedia.getItemInfoByAtom(398)) / 1000);
            numericUpDownTrimEnd.Value = Convert.ToDecimal(windowsMediaPlayer.Ctlcontrols.currentPosition) * frameRate;
        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {
            string strTrim = "No";
            string strResize = "No";
            string strFade = "No";
            string strOutput = Properties.Settings.Default.AVSOutput;

            if (checkBoxTrim.Checked)
            {
                strTrim = numericUpDownTrimStart.Value.ToString() + ", " + numericUpDownTrimEnd.Value.ToString();
            }

            if (checkBoxResize.Checked)
            {
                strResize = comboBoxResize.Text;
            }

            if (checkBoxFadeIn.Checked)
            {
                strFade = "FadeIn";
            } else if (checkBoxFadeOut.Checked)
            {
                strFade = "FadeOut";
            } else if (checkBoxFadeInOut.Checked)
            {
                strFade = "FadeInOut";
            }

            ListViewItem lvi = new ListViewItem(textBoxVideo.Text);
            lvi.SubItems.Add(strTrim);
            lvi.SubItems.Add(strResize);
            lvi.SubItems.Add(strFade);
            lvi.SubItems.Add(strOutput);

            listViewQueue.Items.Add(lvi);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            string output = Properties.Settings.Default.AVSOutput.ToString() + "\\";
            string path = @output + "test.avs";


            








            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("#Created with AVS-Script-Creator by Steffen Köhler");
                    sw.WriteLine("LoadPlugin('E:\\Software\\AviSynth 2.5\\plugins\\TransAll.dll')");
                    sw.WriteLine("LoadPlugin('E:\\Software\\SagaraS Scriptmaker\\Plugins\\SplineResize.dll')");
                    sw.WriteLine("clip = AVISource('A:\\Watch Dogs 3.avi', audio = false).AssumeFPS(30, 1).ConvertToYV12()");
                    sw.WriteLine("clip = AudioDub(clip1, WAVSource('A:\\Watch Dogs 3.wav'))");
                    sw.WriteLine("clip = Trim(clip1, 0, 50167)");
                    sw.WriteLine("clip.Spline100Resize(2080, 1170)");
                    sw.WriteLine("clip.FadeIO2(30, fps = 30)");
                   
                }
            }
        }
    }
}
