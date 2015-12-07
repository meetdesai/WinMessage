using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MK.MobileDevice;
using System.Diagnostics;

namespace USBTool
{
    public partial class MainForm : MetroForm
    {
        internal iPhone iph;
        string deviceUdid;
        string portNum;
        Process iproxy;
        internal bool usbPaired = false;
        public MainForm()
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            try
            {
                iph = new iPhone();
            }
            catch
            {
                MessageBox.Show("Could not register for iPhone connection.\nPlease ensure that iTunes is installed.");
                Application.Exit();
            }
            iph.Connect += Iph_Connect;
            iph.Disconnect += Iph_Disconnect;
        }

        private void Iph_Disconnect(object sender, ConnectEventArgs args)
        {
            label2.Text = "No Device Detected.";
            button1.Enabled = false;
            button2.Enabled = false;
            usbPaired = false;
            button3.Enabled = false;
        }

        private void Iph_Connect(object sender, ConnectEventArgs args)
        {
            label2.Text = "Connected to Device.";
            button2.Enabled = true;
            usbPaired = false;
            button3.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            usbPaired = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usbPaired = iph.IsConnected ? true : false;
            button1.Enabled = usbPaired;
            if (usbPaired)
                label2.Text = "Device Paired Successfully.";
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                portNum = textBox2.Text;
                deviceUdid = iph.DeviceId;
                MessageBox.Show("ALERT: Windows Firewall may ask you whether\nyou want to allow iProxy to communicate on the network.\nMake sure you check the private and public boxes, or\niProxy will not function.");
                iproxy = Process.Start("iproxy.exe", String.Format("{0} {0} {1}", portNum, deviceUdid));
                button3.Enabled = true;
            }
            catch
            {
                MessageBox.Show("An error occurred launching iProxy.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {   
                button3.Enabled = false;
                button1.Enabled = true;
                iproxy.Kill();
            }
            catch
            {
                MessageBox.Show("An error occurred closing iProxy.");
            }
        }
    }
}
