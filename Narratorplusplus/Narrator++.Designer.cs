namespace Narratorplusplus
{
    partial class Narratorplusplus
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_InstalledVoices = new System.Windows.Forms.ComboBox();
            this.num_Rate = new System.Windows.Forms.NumericUpDown();
            this.num_Volume = new System.Windows.Forms.NumericUpDown();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_ShortcutKeys = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Volume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_ShortcutKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cb_InstalledVoices
            // 
            this.cb_InstalledVoices.FormattingEnabled = true;
            this.cb_InstalledVoices.Location = new System.Drawing.Point(33, 48);
            this.cb_InstalledVoices.Name = "cb_InstalledVoices";
            this.cb_InstalledVoices.Size = new System.Drawing.Size(286, 21);
            this.cb_InstalledVoices.TabIndex = 0;
            this.cb_InstalledVoices.SelectedIndexChanged += new System.EventHandler(this.cb_InstalledVoices_SelectedIndexChanged);
            // 
            // num_Rate
            // 
            this.num_Rate.Location = new System.Drawing.Point(232, 92);
            this.num_Rate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.num_Rate.Name = "num_Rate";
            this.num_Rate.Size = new System.Drawing.Size(87, 20);
            this.num_Rate.TabIndex = 1;
            this.num_Rate.ValueChanged += new System.EventHandler(this.num_Rate_ValueChanged);
            // 
            // num_Volume
            // 
            this.num_Volume.Location = new System.Drawing.Point(87, 90);
            this.num_Volume.Name = "num_Volume";
            this.num_Volume.Size = new System.Drawing.Size(87, 20);
            this.num_Volume.TabIndex = 2;
            this.num_Volume.ValueChanged += new System.EventHandler(this.num_Volume_ValueChanged);
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(48, 366);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(283, 20);
            this.tb_test.TabIndex = 3;
            this.tb_test.Text = "Testing Current voice... to use the app, copy a string from any location using th" +
    "e clipboard (ctrl+c) and then press (ctrl+shift+s)";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(112, 392);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(132, 23);
            this.btn_read.TabIndex = 5;
            this.btn_read.Text = "Read Test Voice";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voice: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volume: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rate: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_InstalledVoices);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_Rate);
            this.groupBox1.Controls.Add(this.num_Volume);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voice Settings";
            // 
            // gb_ShortcutKeys
            // 
            this.gb_ShortcutKeys.Controls.Add(this.label4);
            this.gb_ShortcutKeys.Location = new System.Drawing.Point(13, 175);
            this.gb_ShortcutKeys.Name = "gb_ShortcutKeys";
            this.gb_ShortcutKeys.Size = new System.Drawing.Size(165, 115);
            this.gb_ShortcutKeys.TabIndex = 10;
            this.gb_ShortcutKeys.TabStop = false;
            this.gb_ShortcutKeys.Text = "Shortcut Keys";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 84);
            this.label4.TabIndex = 9;
            this.label4.Text = "step 1:\r\nCopy to text to clipboard (ctrl+c)\r\nstep 2:\r\npress ctrl+shift+s\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(202, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 115);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Settings";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 50);
            this.label5.TabIndex = 12;
            this.label5.Text = "How to use:\r\n to use the app, copy a string from any location using the clipboard" +
    " (ctrl+c) and then press (ctrl+alt+F12)";
            // 
            // Narratorplusplus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_ShortcutKeys);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.tb_test);
            this.Name = "Narratorplusplus";
            this.Text = "Narrator++ (Alpha)";
            this.Load += new System.EventHandler(this.Narratorplusplus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Volume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ShortcutKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_InstalledVoices;
        private System.Windows.Forms.NumericUpDown num_Rate;
        private System.Windows.Forms.NumericUpDown num_Volume;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_ShortcutKeys;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}

