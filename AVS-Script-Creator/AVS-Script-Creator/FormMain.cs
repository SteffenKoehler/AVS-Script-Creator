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
            tabPage2.Text = "Queue (" + listViewQueue.Items.Count +")" ;


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
            }
            else if (checkBoxFadeOut.Checked)
            {
                strFade = "FadeOut";
            }
            else if (checkBoxFadeInOut.Checked)
            {
                strFade = "FadeIO";
            }



            ListViewItem lvi = new ListViewItem(textBoxVideo.Text);
            lvi.SubItems.Add(strTrim);
            lvi.SubItems.Add(strResize);
            lvi.SubItems.Add(strFade);
            lvi.SubItems.Add(strOutput);

            listViewQueue.Items.Add(lvi);

            tabPage2.Text = "Queue (" + listViewQueue.Items.Count + ")";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCreateFiles_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in listViewQueue.Items)
            {
                Filesave fileSave = new Filesave();
                fileSave.number = itemRow.Index + 1;
                fileSave.videoInput = itemRow.SubItems[0].Text.ToString();
                fileSave.trim = itemRow.SubItems[1].Text.ToString();
                fileSave.resize = itemRow.SubItems[2].Text.ToString();
                fileSave.fade = itemRow.SubItems[3].Text.ToString();
                
                fileSave.save(); 
            }
        }
    }
}
