namespace WindowsFormsApp17
{
    partial class Form1
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
            this.playSoundBtn = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.findMicBTN = new System.Windows.Forms.Button();
            this.micList = new System.Windows.Forms.ListBox();
            this.recordFileNameTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mp3headerReadBTN = new System.Windows.Forms.Button();
            this.mp3HeaderLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playSoundBtn
            // 
            this.playSoundBtn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.playSoundBtn.Location = new System.Drawing.Point(44, 114);
            this.playSoundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.playSoundBtn.Name = "playSoundBtn";
            this.playSoundBtn.Size = new System.Drawing.Size(367, 63);
            this.playSoundBtn.TabIndex = 1;
            this.playSoundBtn.Text = "wybierz plik wav do odtworzenia";
            this.playSoundBtn.UseVisualStyleBackColor = true;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(40, 41);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(131, 20);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "Nie wybrano pliku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tu po odczytaniu pliku będzie header";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nagraj dzwiek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findMicBTN
            // 
            this.findMicBTN.Location = new System.Drawing.Point(464, 111);
            this.findMicBTN.Name = "findMicBTN";
            this.findMicBTN.Size = new System.Drawing.Size(367, 66);
            this.findMicBTN.TabIndex = 7;
            this.findMicBTN.Text = "znajdź mikrofony";
            this.findMicBTN.UseVisualStyleBackColor = true;
            this.findMicBTN.Click += new System.EventHandler(this.findMicBTN_Click);
            // 
            // micList
            // 
            this.micList.FormattingEnabled = true;
            this.micList.ItemHeight = 20;
            this.micList.Location = new System.Drawing.Point(464, 297);
            this.micList.Name = "micList";
            this.micList.Size = new System.Drawing.Size(409, 204);
            this.micList.TabIndex = 8;
            this.micList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // recordFileNameTXT
            // 
            this.recordFileNameTXT.Location = new System.Drawing.Point(464, 67);
            this.recordFileNameTXT.Name = "recordFileNameTXT";
            this.recordFileNameTXT.Size = new System.Drawing.Size(367, 26);
            this.recordFileNameTXT.TabIndex = 9;
            this.recordFileNameTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "tu daj nazwe do zapisu";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "wybierz mp3 do odczytania tagów";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mp3headerReadBTN
            // 
            this.mp3headerReadBTN.Location = new System.Drawing.Point(926, 114);
            this.mp3headerReadBTN.Name = "mp3headerReadBTN";
            this.mp3headerReadBTN.Size = new System.Drawing.Size(241, 63);
            this.mp3headerReadBTN.TabIndex = 12;
            this.mp3headerReadBTN.Text = "wtybierz mp3 do czytania headerów";
            this.mp3headerReadBTN.UseVisualStyleBackColor = true;
            this.mp3headerReadBTN.Click += new System.EventHandler(this.mp3headerReadBTN_Click);
            // 
            // mp3HeaderLBL
            // 
            this.mp3HeaderLBL.AutoSize = true;
            this.mp3HeaderLBL.Location = new System.Drawing.Point(922, 213);
            this.mp3HeaderLBL.Name = "mp3HeaderLBL";
            this.mp3HeaderLBL.Size = new System.Drawing.Size(173, 20);
            this.mp3HeaderLBL.TabIndex = 13;
            this.mp3HeaderLBL.Text = "miejsce na header mp3";
            this.mp3HeaderLBL.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 662);
            this.Controls.Add(this.mp3HeaderLBL);
            this.Controls.Add(this.mp3headerReadBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordFileNameTXT);
            this.Controls.Add(this.micList);
            this.Controls.Add(this.findMicBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.playSoundBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playSoundBtn;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button findMicBTN;
        private System.Windows.Forms.ListBox micList;
        private System.Windows.Forms.TextBox recordFileNameTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mp3headerReadBTN;
        private System.Windows.Forms.Label mp3HeaderLBL;
    }
}

