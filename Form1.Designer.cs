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
            btnListen = new Button();
            comboBox1 = new ComboBox();
            btnGetDevices = new Button();
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
            // btnListen
            // 
            btnListen.Location = new Point(40, 280);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(124, 67);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetDevices);
            Controls.Add(comboBox1);
            Controls.Add(btnListen);
            Controls.Add(btnPlay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnListen;
        private ComboBox comboBox1;
        private Button btnGetDevices;
    }
}
