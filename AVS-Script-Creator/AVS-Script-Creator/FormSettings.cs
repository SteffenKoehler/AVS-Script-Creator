﻿using System;
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

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

       


        public FormSettings()
        {
            InitializeComponent();
            initSettingsResizeComboBox();
            textBoxVideoDefaultPath.Text = Properties.Settings.Default.VideoDefaultPath.ToString();
            textBoxAVSOutput.Text = Properties.Settings.Default.AVSOutput.ToString();


            // Set the help text description for the FolderBrowserDialog.
            folderBrowserDialog.Description ="Select the directory that you want to use as the default.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            folderBrowserDialog.ShowNewFolderButton = false;
            // Default to the Desktop folder.
            folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.Desktop;
        }

       
        private void initSettingsResizeComboBox()
        {
            comboBoxSettingsResize.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var resizeItem in Properties.Settings.Default.ResizeValues)
            {
                comboBoxSettingsResize.Items.Add(resizeItem);
            }

            comboBoxSettingsResize.Text = Properties.Settings.Default.DefaultResizeValue;
            checkBoxSettingsResize.Checked = Properties.Settings.Default.DefaultResizeBoolean;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VideoDefaultPath = textBoxVideoDefaultPath.Text;
            Properties.Settings.Default.AVSOutput = textBoxAVSOutput.Text;

            checkForDefaultResizeSettings();

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void checkForDefaultResizeSettings()
        {
            if (checkBoxSettingsResize.Checked)
            {
                Properties.Settings.Default.DefaultResizeBoolean = true;
                Properties.Settings.Default.DefaultResizeValue = comboBoxSettingsResize.Text;
            } else
            {
                Properties.Settings.Default.DefaultResizeBoolean = false;
                Properties.Settings.Default.DefaultResizeValue = "No";
            }
        }



        private void buttonDefaultVideoDirection_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxVideoDefaultPath.Text = folderBrowserDialog.SelectedPath.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read folder from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonAVSOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxAVSOutput.Text = folderBrowserDialog.SelectedPath.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read folder from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
