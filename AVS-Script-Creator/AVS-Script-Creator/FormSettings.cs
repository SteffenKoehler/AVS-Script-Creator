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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            textBoxVideoDefaultPath.Text = Properties.Settings.Default.VideoDefaultPath.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VideoDefaultPath = textBoxVideoDefaultPath.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonDefaultVideoDirection_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // Set the help text description for the FolderBrowserDialog.
            folderBrowserDialog1.Description =
                "Select the directory that you want to use as the default.";

            // Do not allow the user to create new files via the FolderBrowserDialog.
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Default to the Desktop folder.
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowDialog();

            textBoxVideoDefaultPath.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
    }
}
