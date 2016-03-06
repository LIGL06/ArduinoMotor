using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDatos
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();
        }
        String RxString;

        private void RXWINDOW_TextChanged(object sender, EventArgs e)
        {

        }

        private void offline_Click(object sender, EventArgs e)
        {
            if (enlaceBT.IsOpen)
                enlaceBT.Close();
            connect.Enabled = true;
            MessageBox.Show("Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void connect_Click(object sender, EventArgs e)
        {
            enlaceBT.PortName = "COM4";
            enlaceBT.BaudRate = 9600;
            enlaceBT.Open();

            if (!enlaceBT.IsOpen) return;
            connect.Enabled = false;

            MessageBox.Show("Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void send_Click(object sender, EventArgs e)
        {
            string tx = TXWINDOW.Text;
            enlaceBT.Write(tx);
            TXWINDOW.Clear();
        }

        private void mainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enlaceBT.IsOpen) enlaceBT.Close();
        }
        private void enlaceBT_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = enlaceBT.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));

        }
        private void DisplayText(object sender, EventArgs e)
        {
            RXWINDOW.AppendText(RxString);

        }
    }
}
