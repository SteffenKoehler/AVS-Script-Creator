﻿namespace AVS_Script_Creator
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVideoDefaultPath = new System.Windows.Forms.TextBox();
            this.buttonDefaultVideoDirection = new System.Windows.Forms.Button();
            this.buttonAVSOutput = new System.Windows.Forms.Button();
            this.textBoxAVSOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSettingsResize = new System.Windows.Forms.CheckBox();
            this.comboBoxSettingsResize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(15, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(391, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set default video path:\r\n";
            // 
            // textBoxVideoDefaultPath
            // 
            this.textBoxVideoDefaultPath.Location = new System.Drawing.Point(132, 13);
            this.textBoxVideoDefaultPath.Name = "textBoxVideoDefaultPath";
            this.textBoxVideoDefaultPath.Size = new System.Drawing.Size(303, 20);
            this.textBoxVideoDefaultPath.TabIndex = 3;
            // 
            // buttonDefaultVideoDirection
            // 
            this.buttonDefaultVideoDirection.Location = new System.Drawing.Point(441, 12);
            this.buttonDefaultVideoDirection.Name = "buttonDefaultVideoDirection";
            this.buttonDefaultVideoDirection.Size = new System.Drawing.Size(25, 23);
            this.buttonDefaultVideoDirection.TabIndex = 4;
            this.buttonDefaultVideoDirection.Text = "...";
            this.buttonDefaultVideoDirection.UseVisualStyleBackColor = true;
            this.buttonDefaultVideoDirection.Click += new System.EventHandler(this.buttonDefaultVideoDirection_Click);
            // 
            // buttonAVSOutput
            // 
            this.buttonAVSOutput.Location = new System.Drawing.Point(441, 50);
            this.buttonAVSOutput.Name = "buttonAVSOutput";
            this.buttonAVSOutput.Size = new System.Drawing.Size(25, 23);
            this.buttonAVSOutput.TabIndex = 5;
            this.buttonAVSOutput.Text = "...";
            this.buttonAVSOutput.UseVisualStyleBackColor = true;
            this.buttonAVSOutput.Click += new System.EventHandler(this.buttonAVSOutput_Click);
            // 
            // textBoxAVSOutput
            // 
            this.textBoxAVSOutput.Location = new System.Drawing.Point(132, 52);
            this.textBoxAVSOutput.Name = "textBoxAVSOutput";
            this.textBoxAVSOutput.Size = new System.Drawing.Size(303, 20);
            this.textBoxAVSOutput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set default AVS output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set default resize:";
            // 
            // checkBoxSettingsResize
            // 
            this.checkBoxSettingsResize.AutoSize = true;
            this.checkBoxSettingsResize.Location = new System.Drawing.Point(132, 83);
            this.checkBoxSettingsResize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSettingsResize.Name = "checkBoxSettingsResize";
            this.checkBoxSettingsResize.Size = new System.Drawing.Size(89, 17);
            this.checkBoxSettingsResize.TabIndex = 9;
            this.checkBoxSettingsResize.Text = "Enable resize";
            this.checkBoxSettingsResize.UseVisualStyleBackColor = true;
            // 
            // comboBoxSettingsResize
            // 
            this.comboBoxSettingsResize.FormattingEnabled = true;
            this.comboBoxSettingsResize.Location = new System.Drawing.Point(243, 81);
            this.comboBoxSettingsResize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSettingsResize.Name = "comboBoxSettingsResize";
            this.comboBoxSettingsResize.Size = new System.Drawing.Size(192, 21);
            this.comboBoxSettingsResize.TabIndex = 10;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 261);
            this.Controls.Add(this.comboBoxSettingsResize);
            this.Controls.Add(this.checkBoxSettingsResize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAVSOutput);
            this.Controls.Add(this.buttonAVSOutput);
            this.Controls.Add(this.buttonDefaultVideoDirection);
            this.Controls.Add(this.textBoxVideoDefaultPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVideoDefaultPath;
        private System.Windows.Forms.Button buttonDefaultVideoDirection;
        private System.Windows.Forms.Button buttonAVSOutput;
        private System.Windows.Forms.TextBox textBoxAVSOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSettingsResize;
        private System.Windows.Forms.ComboBox comboBoxSettingsResize;
    }
}