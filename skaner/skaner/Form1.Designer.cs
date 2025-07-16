namespace skaner {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.scanButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formatBox = new System.Windows.Forms.ComboBox();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.rotationBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deviceName = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpiBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(515, 502);
            this.scanButton.Margin = new System.Windows.Forms.Padding(2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(364, 46);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "SCAN";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(531, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 487);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // formatBox
            // 
            this.formatBox.FormattingEnabled = true;
            this.formatBox.Location = new System.Drawing.Point(127, 274);
            this.formatBox.Margin = new System.Windows.Forms.Padding(2);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(241, 28);
            this.formatBox.TabIndex = 4;
            this.formatBox.SelectedIndexChanged += new System.EventHandler(this.formatBox_SelectedIndexChanged);
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(127, 329);
            this.colorBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(241, 28);
            this.colorBox.TabIndex = 5;
            this.colorBox.SelectedIndexChanged += new System.EventHandler(this.colorBox_SelectedIndexChanged);
            // 
            // rotationBox
            // 
            this.rotationBox.FormattingEnabled = true;
            this.rotationBox.Location = new System.Drawing.Point(127, 384);
            this.rotationBox.Margin = new System.Windows.Forms.Padding(2);
            this.rotationBox.Name = "rotationBox";
            this.rotationBox.Size = new System.Drawing.Size(241, 28);
            this.rotationBox.TabIndex = 6;
            this.rotationBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "format";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "rotation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "size";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "device";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // deviceName
            // 
            this.deviceName.AutoSize = true;
            this.deviceName.Location = new System.Drawing.Point(95, 27);
            this.deviceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(0, 20);
            this.deviceName.TabIndex = 14;
            this.deviceName.Click += new System.EventHandler(this.label6_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(127, 133);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(241, 28);
            this.sizeBox.TabIndex = 15;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "dpi";
            // 
            // dpiBox
            // 
            this.dpiBox.FormattingEnabled = true;
            this.dpiBox.Location = new System.Drawing.Point(127, 198);
            this.dpiBox.Margin = new System.Windows.Forms.Padding(2);
            this.dpiBox.Name = "dpiBox";
            this.dpiBox.Size = new System.Drawing.Size(241, 28);
            this.dpiBox.TabIndex = 17;
            this.dpiBox.SelectedIndexChanged += new System.EventHandler(this.dpiBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 558);
            this.Controls.Add(this.dpiBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotationBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scanButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox formatBox;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.ComboBox rotationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deviceName;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dpiBox;
    }
}

