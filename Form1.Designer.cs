namespace TheAudioVisualiser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new Button();
            comboBox1 = new ComboBox();
            btnGetDevices = new Button();
            splitContainer1 = new SplitContainer();
            sourceList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnExit = new Button();
            btnStop = new Button();
            btnStart = new Button();
            btnSources = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(40, 36);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(124, 68);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play Sound";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(355, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 2;
            // 
            // btnGetDevices
            // 
            btnGetDevices.Location = new Point(253, 59);
            btnGetDevices.Name = "btnGetDevices";
            btnGetDevices.Size = new Size(75, 23);
            btnGetDevices.TabIndex = 3;
            btnGetDevices.Text = "Get Devices";
            btnGetDevices.UseVisualStyleBackColor = true;
            btnGetDevices.Click += btnGetDevices_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(40, 134);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(sourceList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnExit);
            splitContainer1.Panel2.Controls.Add(btnStop);
            splitContainer1.Panel2.Controls.Add(btnStart);
            splitContainer1.Panel2.Controls.Add(btnSources);
            splitContainer1.Size = new Size(716, 287);
            splitContainer1.SplitterDistance = 491;
            splitContainer1.TabIndex = 4;
            // 
            // sourceList
            // 
            sourceList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            sourceList.Location = new Point(0, 0);
            sourceList.MultiSelect = false;
            sourceList.Name = "sourceList";
            sourceList.Size = new Size(491, 287);
            sourceList.TabIndex = 0;
            sourceList.UseCompatibleStateImageBehavior = false;
            sourceList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Device";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Channels";
            columnHeader2.Width = 160;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(8, 250);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(204, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(8, 132);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(204, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(8, 103);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(204, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSources
            // 
            btnSources.Location = new Point(8, 15);
            btnSources.Name = "btnSources";
            btnSources.Size = new Size(204, 23);
            btnSources.TabIndex = 0;
            btnSources.Text = "Refresh Sources";
            btnSources.UseVisualStyleBackColor = true;
            btnSources.Click += btnSources_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(btnGetDevices);
            Controls.Add(comboBox1);
            Controls.Add(btnPlay);
            Name = "Form1";
            Text = "Audio Visualiser";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private ComboBox comboBox1;
        private Button btnGetDevices;
        private SplitContainer splitContainer1;
        private ListView sourceList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnExit;
        private Button btnStop;
        private Button btnStart;
        private Button btnSources;
    }
}
