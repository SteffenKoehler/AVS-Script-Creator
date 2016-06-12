namespace AVS_Script_Creator
{
    partial class formMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.labelVideo = new System.Windows.Forms.Label();
            this.openFileDialogVideo = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTrim = new System.Windows.Forms.CheckBox();
            this.numericUpDownTrimEnd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrimStart = new System.Windows.Forms.NumericUpDown();
            this.comboBoxResize = new System.Windows.Forms.ComboBox();
            this.labelResize = new System.Windows.Forms.Label();
            this.checkBoxResize = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimStart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.queueToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.menüToolStripMenuItem.Text = "Settings";
            this.menüToolStripMenuItem.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // queueToolStripMenuItem
            // 
            this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            this.queueToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.queueToolStripMenuItem.Text = "Queue";
            this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click);
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(63, 74);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(305, 20);
            this.textBoxVideo.TabIndex = 3;
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(12, 77);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(37, 13);
            this.labelVideo.TabIndex = 4;
            this.labelVideo.Text = "Video:";
            // 
            // openFileDialogVideo
            // 
            this.openFileDialogVideo.FileName = "openFileDialogVideo";
            // 
            // buttonOpenVideo
            // 
            this.buttonOpenVideo.Location = new System.Drawing.Point(374, 72);
            this.buttonOpenVideo.Name = "buttonOpenVideo";
            this.buttonOpenVideo.Size = new System.Drawing.Size(26, 23);
            this.buttonOpenVideo.TabIndex = 5;
            this.buttonOpenVideo.Text = "...";
            this.buttonOpenVideo.UseVisualStyleBackColor = true;
            this.buttonOpenVideo.Click += new System.EventHandler(this.buttonOpenVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trim:";
            // 
            // checkBoxTrim
            // 
            this.checkBoxTrim.AutoSize = true;
            this.checkBoxTrim.Location = new System.Drawing.Point(63, 114);
            this.checkBoxTrim.Name = "checkBoxTrim";
            this.checkBoxTrim.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTrim.TabIndex = 7;
            this.checkBoxTrim.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTrimEnd
            // 
            this.numericUpDownTrimEnd.Location = new System.Drawing.Point(248, 112);
            this.numericUpDownTrimEnd.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDownTrimEnd.Name = "numericUpDownTrimEnd";
            this.numericUpDownTrimEnd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTrimEnd.TabIndex = 8;
            // 
            // numericUpDownTrimStart
            // 
            this.numericUpDownTrimStart.Location = new System.Drawing.Point(101, 112);
            this.numericUpDownTrimStart.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDownTrimStart.Name = "numericUpDownTrimStart";
            this.numericUpDownTrimStart.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTrimStart.TabIndex = 9;
            // 
            // comboBoxResize
            // 
            this.comboBoxResize.Location = new System.Drawing.Point(101, 141);
            this.comboBoxResize.Name = "comboBoxResize";
            this.comboBoxResize.Size = new System.Drawing.Size(158, 21);
            this.comboBoxResize.TabIndex = 10;
            // 
            // labelResize
            // 
            this.labelResize.AutoSize = true;
            this.labelResize.Location = new System.Drawing.Point(12, 144);
            this.labelResize.Name = "labelResize";
            this.labelResize.Size = new System.Drawing.Size(42, 13);
            this.labelResize.TabIndex = 11;
            this.labelResize.Text = "Resize:";
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(63, 144);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(15, 14);
            this.checkBoxResize.TabIndex = 12;
            this.checkBoxResize.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 509);
            this.Controls.Add(this.checkBoxResize);
            this.Controls.Add(this.labelResize);
            this.Controls.Add(this.comboBoxResize);
            this.Controls.Add(this.numericUpDownTrimStart);
            this.Controls.Add(this.numericUpDownTrimEnd);
            this.Controls.Add(this.checkBoxTrim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenVideo);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.textBoxVideo);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "formMain";
            this.Text = "AVS Script Creator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.OpenFileDialog openFileDialogVideo;
        private System.Windows.Forms.Button buttonOpenVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTrim;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimStart;
        private System.Windows.Forms.ComboBox comboBoxResize;
        private System.Windows.Forms.Label labelResize;
        private System.Windows.Forms.CheckBox checkBoxResize;
    }
}

