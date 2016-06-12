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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonTrimAddStartFrame = new System.Windows.Forms.Button();
            this.buttonTrimAddEndFrame = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddToQueue = new System.Windows.Forms.Button();
            this.checkBoxFadeInOut = new System.Windows.Forms.CheckBox();
            this.labelFadeINOUT = new System.Windows.Forms.Label();
            this.checkBoxFadeOut = new System.Windows.Forms.CheckBox();
            this.labelFadeOUT = new System.Windows.Forms.Label();
            this.checkBoxFadeIn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewQueue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(947, 24);
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
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(60, 14);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(305, 20);
            this.textBoxVideo.TabIndex = 3;
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(9, 17);
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
            this.buttonOpenVideo.Location = new System.Drawing.Point(371, 12);
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
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trim:";
            // 
            // checkBoxTrim
            // 
            this.checkBoxTrim.AutoSize = true;
            this.checkBoxTrim.Location = new System.Drawing.Point(60, 59);
            this.checkBoxTrim.Name = "checkBoxTrim";
            this.checkBoxTrim.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTrim.TabIndex = 7;
            this.checkBoxTrim.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTrimEnd
            // 
            this.numericUpDownTrimEnd.Location = new System.Drawing.Point(245, 57);
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
            this.numericUpDownTrimStart.Location = new System.Drawing.Point(98, 57);
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
            this.comboBoxResize.Location = new System.Drawing.Point(98, 127);
            this.comboBoxResize.Name = "comboBoxResize";
            this.comboBoxResize.Size = new System.Drawing.Size(267, 21);
            this.comboBoxResize.TabIndex = 10;
            // 
            // labelResize
            // 
            this.labelResize.AutoSize = true;
            this.labelResize.Location = new System.Drawing.Point(9, 130);
            this.labelResize.Name = "labelResize";
            this.labelResize.Size = new System.Drawing.Size(42, 13);
            this.labelResize.TabIndex = 11;
            this.labelResize.Text = "Resize:";
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(60, 130);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(15, 14);
            this.checkBoxResize.TabIndex = 12;
            this.checkBoxResize.UseVisualStyleBackColor = true;
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(409, 7);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(503, 415);
            this.windowsMediaPlayer.TabIndex = 13;
            // 
            // buttonTrimAddStartFrame
            // 
            this.buttonTrimAddStartFrame.Enabled = false;
            this.buttonTrimAddStartFrame.Location = new System.Drawing.Point(98, 83);
            this.buttonTrimAddStartFrame.Name = "buttonTrimAddStartFrame";
            this.buttonTrimAddStartFrame.Size = new System.Drawing.Size(120, 23);
            this.buttonTrimAddStartFrame.TabIndex = 14;
            this.buttonTrimAddStartFrame.Text = "Add current frame";
            this.buttonTrimAddStartFrame.UseVisualStyleBackColor = true;
            this.buttonTrimAddStartFrame.Click += new System.EventHandler(this.buttonTrimAddStartFrame_Click);
            // 
            // buttonTrimAddEndFrame
            // 
            this.buttonTrimAddEndFrame.Enabled = false;
            this.buttonTrimAddEndFrame.Location = new System.Drawing.Point(245, 83);
            this.buttonTrimAddEndFrame.Name = "buttonTrimAddEndFrame";
            this.buttonTrimAddEndFrame.Size = new System.Drawing.Size(120, 23);
            this.buttonTrimAddEndFrame.TabIndex = 15;
            this.buttonTrimAddEndFrame.Text = "Add current frame";
            this.buttonTrimAddEndFrame.UseVisualStyleBackColor = true;
            this.buttonTrimAddEndFrame.Click += new System.EventHandler(this.buttonTrimAddEndFrame_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(923, 454);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonAddToQueue);
            this.tabPage1.Controls.Add(this.checkBoxFadeInOut);
            this.tabPage1.Controls.Add(this.labelFadeINOUT);
            this.tabPage1.Controls.Add(this.checkBoxFadeOut);
            this.tabPage1.Controls.Add(this.labelFadeOUT);
            this.tabPage1.Controls.Add(this.checkBoxFadeIn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonTrimAddEndFrame);
            this.tabPage1.Controls.Add(this.windowsMediaPlayer);
            this.tabPage1.Controls.Add(this.buttonTrimAddStartFrame);
            this.tabPage1.Controls.Add(this.checkBoxResize);
            this.tabPage1.Controls.Add(this.textBoxVideo);
            this.tabPage1.Controls.Add(this.labelResize);
            this.tabPage1.Controls.Add(this.labelVideo);
            this.tabPage1.Controls.Add(this.comboBoxResize);
            this.tabPage1.Controls.Add(this.buttonOpenVideo);
            this.tabPage1.Controls.Add(this.numericUpDownTrimStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDownTrimEnd);
            this.tabPage1.Controls.Add(this.checkBoxTrim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(60, 352);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(84, 23);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddToQueue
            // 
            this.buttonAddToQueue.Location = new System.Drawing.Point(281, 352);
            this.buttonAddToQueue.Name = "buttonAddToQueue";
            this.buttonAddToQueue.Size = new System.Drawing.Size(84, 23);
            this.buttonAddToQueue.TabIndex = 22;
            this.buttonAddToQueue.Text = "Add to queue";
            this.buttonAddToQueue.UseVisualStyleBackColor = true;
            this.buttonAddToQueue.Click += new System.EventHandler(this.buttonAddToQueue_Click);
            // 
            // checkBoxFadeInOut
            // 
            this.checkBoxFadeInOut.AutoSize = true;
            this.checkBoxFadeInOut.Location = new System.Drawing.Point(292, 169);
            this.checkBoxFadeInOut.Name = "checkBoxFadeInOut";
            this.checkBoxFadeInOut.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFadeInOut.TabIndex = 21;
            this.checkBoxFadeInOut.UseVisualStyleBackColor = true;
            // 
            // labelFadeINOUT
            // 
            this.labelFadeINOUT.AutoSize = true;
            this.labelFadeINOUT.Location = new System.Drawing.Point(213, 169);
            this.labelFadeINOUT.Name = "labelFadeINOUT";
            this.labelFadeINOUT.Size = new System.Drawing.Size(73, 13);
            this.labelFadeINOUT.TabIndex = 20;
            this.labelFadeINOUT.Text = "FadeIN/OUT:";
            // 
            // checkBoxFadeOut
            // 
            this.checkBoxFadeOut.AutoSize = true;
            this.checkBoxFadeOut.Location = new System.Drawing.Point(174, 169);
            this.checkBoxFadeOut.Name = "checkBoxFadeOut";
            this.checkBoxFadeOut.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFadeOut.TabIndex = 19;
            this.checkBoxFadeOut.UseVisualStyleBackColor = true;
            // 
            // labelFadeOUT
            // 
            this.labelFadeOUT.AutoSize = true;
            this.labelFadeOUT.Location = new System.Drawing.Point(111, 170);
            this.labelFadeOUT.Name = "labelFadeOUT";
            this.labelFadeOUT.Size = new System.Drawing.Size(57, 13);
            this.labelFadeOUT.TabIndex = 18;
            this.labelFadeOUT.Text = "FadeOUT:";
            // 
            // checkBoxFadeIn
            // 
            this.checkBoxFadeIn.AutoSize = true;
            this.checkBoxFadeIn.Location = new System.Drawing.Point(60, 170);
            this.checkBoxFadeIn.Name = "checkBoxFadeIn";
            this.checkBoxFadeIn.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFadeIn.TabIndex = 17;
            this.checkBoxFadeIn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "FadeIN";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewQueue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewQueue
            // 
            this.listViewQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewQueue.FullRowSelect = true;
            this.listViewQueue.GridLines = true;
            this.listViewQueue.Location = new System.Drawing.Point(6, 6);
            this.listViewQueue.MultiSelect = false;
            this.listViewQueue.Name = "listViewQueue";
            this.listViewQueue.Size = new System.Drawing.Size(903, 354);
            this.listViewQueue.TabIndex = 0;
            this.listViewQueue.UseCompatibleStateImageBehavior = false;
            this.listViewQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trim";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Resize";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fade";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Output";
            this.columnHeader5.Width = 286;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 493);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "formMain";
            this.Text = "AVS Script Creator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
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
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button buttonTrimAddStartFrame;
        private System.Windows.Forms.Button buttonTrimAddEndFrame;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewQueue;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddToQueue;
        private System.Windows.Forms.CheckBox checkBoxFadeInOut;
        private System.Windows.Forms.Label labelFadeINOUT;
        private System.Windows.Forms.CheckBox checkBoxFadeOut;
        private System.Windows.Forms.Label labelFadeOUT;
        private System.Windows.Forms.CheckBox checkBoxFadeIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

