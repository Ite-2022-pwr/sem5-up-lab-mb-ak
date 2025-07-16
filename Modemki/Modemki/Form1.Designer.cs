using System.Drawing;
using System.Windows.Forms;

namespace Modemki
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
        /// Metoda wymagana do obsługi projektanta — nie modyfikuj
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            cboPorts = new ComboBox();
            cboBaudRate = new ComboBox();
            cboDataBits = new ComboBox();
            cboStopBits = new ComboBox();
            cboParity = new ComboBox();
            cboHandShaking = new ComboBox();
            btnPortState = new Button();
            lblStatus = new Label();
            txtDialNumber = new TextBox();
            btnDial = new Button();
            btnReceive = new Button();
            btnHangUp = new Button();
            txtMessage = new TextBox();
            btnSendMsg = new Button();
            rtbLog = new RichTextBox();
            txtFullOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // cboPorts
            // 
            cboPorts.FormattingEnabled = true;
            cboPorts.Location = new Point(12, 35);
            cboPorts.Name = "cboPorts";
            cboPorts.Size = new Size(169, 23);
            cboPorts.TabIndex = 0;
            // 
            // cboBaudRate
            // 
            cboBaudRate.FormattingEnabled = true;
            cboBaudRate.Location = new Point(12, 83);
            cboBaudRate.Name = "cboBaudRate";
            cboBaudRate.Size = new Size(169, 23);
            cboBaudRate.TabIndex = 1;
            // 
            // cboDataBits
            // 
            cboDataBits.FormattingEnabled = true;
            cboDataBits.Location = new Point(12, 131);
            cboDataBits.Name = "cboDataBits";
            cboDataBits.Size = new Size(169, 23);
            cboDataBits.TabIndex = 2;
            // 
            // cboStopBits
            // 
            cboStopBits.FormattingEnabled = true;
            cboStopBits.Location = new Point(12, 183);
            cboStopBits.Name = "cboStopBits";
            cboStopBits.Size = new Size(169, 23);
            cboStopBits.TabIndex = 3;
            // 
            // cboParity
            // 
            cboParity.FormattingEnabled = true;
            cboParity.Location = new Point(12, 231);
            cboParity.Name = "cboParity";
            cboParity.Size = new Size(169, 23);
            cboParity.TabIndex = 4;
            // 
            // cboHandShaking
            // 
            cboHandShaking.FormattingEnabled = true;
            cboHandShaking.Location = new Point(12, 279);
            cboHandShaking.Name = "cboHandShaking";
            cboHandShaking.Size = new Size(169, 23);
            cboHandShaking.TabIndex = 5;
            // 
            // btnPortState
            // 
            btnPortState.Location = new Point(12, 350);
            btnPortState.Name = "btnPortState";
            btnPortState.Size = new Size(169, 23);
            btnPortState.TabIndex = 6;
            btnPortState.Text = "Closed";
            btnPortState.Click += btnPortState_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(12, 324);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(169, 23);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Rozłączono";
            // 
            // txtDialNumber
            // 
            txtDialNumber.Location = new Point(187, 35);
            txtDialNumber.Name = "txtDialNumber";
            txtDialNumber.Size = new Size(169, 23);
            txtDialNumber.TabIndex = 8;
            // 
            // btnDial
            // 
            btnDial.Location = new Point(187, 64);
            btnDial.Name = "btnDial";
            btnDial.Size = new Size(169, 23);
            btnDial.TabIndex = 9;
            btnDial.Text = "Zadzwoń";
            btnDial.Click += btnDial_Click;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(187, 93);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(169, 23);
            btnReceive.TabIndex = 10;
            btnReceive.Text = "Odbierz";
            btnReceive.Click += btnReceive_Click;
            // 
            // btnHangUp
            // 
            btnHangUp.Location = new Point(187, 122);
            btnHangUp.Name = "btnHangUp";
            btnHangUp.Size = new Size(169, 23);
            btnHangUp.TabIndex = 11;
            btnHangUp.Text = "Zerwij";
            btnHangUp.Click += btnHangUp_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(362, 35);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(344, 23);
            txtMessage.TabIndex = 12;
            // 
            // btnSendMsg
            // 
            btnSendMsg.Location = new Point(362, 64);
            btnSendMsg.Name = "btnSendMsg";
            btnSendMsg.Size = new Size(344, 23);
            btnSendMsg.TabIndex = 13;
            btnSendMsg.Text = "Wyślij";
            btnSendMsg.Click += btnSendMsg_Click;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(362, 122);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(344, 96);
            rtbLog.TabIndex = 14;
            rtbLog.Text = "";
            // 
            // txtFullOutput
            // 
            txtFullOutput.Location = new Point(362, 257);
            txtFullOutput.Multiline = true;
            txtFullOutput.Name = "txtFullOutput";
            txtFullOutput.ScrollBars = ScrollBars.Vertical;
            txtFullOutput.Size = new Size(344, 116);
            txtFullOutput.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 16;
            label1.Text = "Porty COM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 17;
            label2.Text = "Prędkość Transmisji";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 18;
            label3.Text = "Bity Danych";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 19;
            label4.Text = "Bity Stopu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 213);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 20;
            label5.Text = "Bity Parzystości";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 261);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 21;
            label6.Text = "Kontrola Przepływu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(187, 17);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 22;
            label7.Text = "Numer Modemu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(362, 17);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 23;
            label8.Text = "Wiadomość";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 104);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 24;
            label9.Text = "Wymiana Wiadomości";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(362, 239);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 25;
            label10.Text = "Pełny Log";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 309);
            label11.Name = "label11";
            label11.Size = new Size(122, 15);
            label11.TabIndex = 26;
            label11.Text = "Połącz z Portem COM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboPorts);
            Controls.Add(cboBaudRate);
            Controls.Add(cboDataBits);
            Controls.Add(cboStopBits);
            Controls.Add(cboParity);
            Controls.Add(cboHandShaking);
            Controls.Add(btnPortState);
            Controls.Add(lblStatus);
            Controls.Add(txtDialNumber);
            Controls.Add(btnDial);
            Controls.Add(btnReceive);
            Controls.Add(btnHangUp);
            Controls.Add(txtMessage);
            Controls.Add(btnSendMsg);
            Controls.Add(rtbLog);
            Controls.Add(txtFullOutput);
            Name = "Form1";
            Text = "Komunikacja z Modemem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboHandShaking;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDialNumber;
        private System.Windows.Forms.Button btnDial;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnHangUp;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox txtFullOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}

