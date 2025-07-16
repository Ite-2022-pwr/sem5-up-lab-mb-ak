using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modemki
{
    public partial class Form1 : Form
    {
        SerialPort _comPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            // Ustawienie zdarzenia odbierania danych
            //_comPort.DataReceived += DataReceived;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wypełnianie combo boxów wartościami
            cboPorts.Items.AddRange(SerialPort.GetPortNames());

            cboBaudRate.Items.AddRange(new object[] { "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            cboBaudRate.SelectedIndex = 4; // Domyślnie ustawiamy 9600

            cboDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            cboDataBits.SelectedIndex = 3; // Domyślnie ustawiamy 8

            cboStopBits.Items.AddRange(new object[] { "One", "Two", "OnePointFive" });
            cboStopBits.SelectedIndex = 0; // Domyślnie ustawiamy One

            cboParity.Items.AddRange(new object[] { "None", "Even", "Odd", "Mark", "Space" });
            cboParity.SelectedIndex = 0; // Domyślnie ustawiamy None

            cboHandShaking.Items.AddRange(new object[] { "None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOff" });
            cboHandShaking.SelectedIndex = 0; // Domyślnie ustawiamy None
        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
            if (btnPortState.Text == "Closed")
            {
                btnPortState.Text = "Open";
                _comPort.PortName = Convert.ToString(cboPorts.Text);
                _comPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
                _comPort.DataBits = Convert.ToInt16(cboDataBits.Text);
                _comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                _comPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                _comPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                _comPort.RtsEnable = true;
                _comPort.DtrEnable = true;
                _comPort.DataReceived += DataReceived;

                try
                {
                    _comPort.Open();
                    lblStatus.Text = "Połączono";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Closed";
                _comPort.Close();
                lblStatus.Text = "Rozłączono";
            }
        }

        private void btnDial_Click(object sender, EventArgs e)
        {
            if (_comPort.IsOpen)
            {
                _comPort.Write("ATD" + txtDialNumber.Text + "\r\n");
                WriteComOut("Nawiązywanie połączenia z " + txtDialNumber.Text);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (_comPort.IsOpen)
            {
                _comPort.Write("ATA\r\n");
                WriteComOut("Odbieranie...");
            }
        }

        private void btnHangUp_Click(object sender, EventArgs e)
        {

            if (_comPort.IsOpen)
            {
                _comPort.Write("+++");
                Thread.Sleep(1000);
                _comPort.Write("ATH\r\n");
                Thread.Sleep(500);
                _comPort.Write("ATH\r\n");
                WriteComOut("Połączenie zakończone");
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (_comPort.IsOpen)
            {
                _comPort.Write(txtMessage.Text + "\r\n");
                WriteComOut("<-" + txtMessage.Text);
            }
        }

        // Funkcja wywoływana, gdy dane są odbierane przez port COM
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _comPort.ReadExisting();

            this.Invoke(new MethodInvoker(delegate
            {
                rtbLog.AppendText(data);
            }));
        }

        private void WriteComOut(string text)
        {
            rtbLog.AppendText(text + Environment.NewLine);
            txtFullOutput.AppendText(text + Environment.NewLine);
        }
    }
}
