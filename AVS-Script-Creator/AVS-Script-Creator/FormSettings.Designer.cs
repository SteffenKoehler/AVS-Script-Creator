namespace AVS_Script_Creator
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
            this.buttonCancel.Location = new System.Drawing.Point(22, 348);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(586, 348);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 35);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set default video path:\r\n";
            // 
            // textBoxVideoDefaultPath
            // 
            this.textBoxVideoDefaultPath.Location = new System.Drawing.Point(198, 20);
            this.textBoxVideoDefaultPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVideoDefaultPath.Name = "textBoxVideoDefaultPath";
            this.textBoxVideoDefaultPath.Size = new System.Drawing.Size(452, 26);
            this.textBoxVideoDefaultPath.TabIndex = 3;
            // 
            // buttonDefaultVideoDirection
            // 
            this.buttonDefaultVideoDirection.Location = new System.Drawing.Point(662, 18);
            this.buttonDefaultVideoDirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDefaultVideoDirection.Name = "buttonDefaultVideoDirection";
            this.buttonDefaultVideoDirection.Size = new System.Drawing.Size(38, 35);
            this.buttonDefaultVideoDirection.TabIndex = 4;
            this.buttonDefaultVideoDirection.Text = "...";
            this.buttonDefaultVideoDirection.UseVisualStyleBackColor = true;
            this.buttonDefaultVideoDirection.Click += new System.EventHandler(this.buttonDefaultVideoDirection_Click);
            // 
            // buttonAVSOutput
            // 
            this.buttonAVSOutput.Location = new System.Drawing.Point(662, 77);
            this.buttonAVSOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAVSOutput.Name = "buttonAVSOutput";
            this.buttonAVSOutput.Size = new System.Drawing.Size(38, 35);
            this.buttonAVSOutput.TabIndex = 5;
            this.buttonAVSOutput.Text = "...";
            this.buttonAVSOutput.UseVisualStyleBackColor = true;
            this.buttonAVSOutput.Click += new System.EventHandler(this.buttonAVSOutput_Click);
            // 
            // textBoxAVSOutput
            // 
            this.textBoxAVSOutput.Location = new System.Drawing.Point(198, 80);
            this.textBoxAVSOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAVSOutput.Name = "textBoxAVSOutput";
            this.textBoxAVSOutput.Size = new System.Drawing.Size(452, 26);
            this.textBoxAVSOutput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set default AVS output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set default resize:";
            // 
            // checkBoxSettingsResize
            // 
            this.checkBoxSettingsResize.AutoSize = true;
            this.checkBoxSettingsResize.Location = new System.Drawing.Point(198, 127);
            this.checkBoxSettingsResize.Name = "checkBoxSettingsResize";
            this.checkBoxSettingsResize.Size = new System.Drawing.Size(131, 24);
            this.checkBoxSettingsResize.TabIndex = 9;
            this.checkBoxSettingsResize.Text = "Enalbe resize";
            this.checkBoxSettingsResize.UseVisualStyleBackColor = true;
            // 
            // comboBoxSettingsResize
            // 
            this.comboBoxSettingsResize.FormattingEnabled = true;
            this.comboBoxSettingsResize.Location = new System.Drawing.Point(364, 124);
            this.comboBoxSettingsResize.Name = "comboBoxSettingsResize";
            this.comboBoxSettingsResize.Size = new System.Drawing.Size(286, 28);
            this.comboBoxSettingsResize.TabIndex = 10;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 402);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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