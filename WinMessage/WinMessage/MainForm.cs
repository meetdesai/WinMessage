/*

 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.Web;

namespace WinMessage
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
            ConnectToServer();
		}

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ConnectToServer();
            }
        }
        void ConnectToServer()
        {
            try
            {
                string targetAddr = (checkBox1.Checked ? "https://" : "http://") + textBox1.Text + ":" + textBox2.Text;
                WebRequest request = WebRequest.Create(targetAddr);
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => { return true; };
                string username = textBox3.Text;
                string password = textBox4.Text;
                request.Credentials = new NetworkCredential(username, password);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Could not connect to the server. ({0})", response.StatusCode.ToString());
                    return;
                }
                this.Hide();
                WinMessage wm = new WinMessage(targetAddr, username, password);
                wm.Show();
                wm.FormClosed += (s, e) => { /*this.Show();*/ };
            }
            catch (Exception e)
            {
                //MessageBox.Show("Could not connect to the server.\n"+e.ToString());
                MessageBox.Show("Could not connect to the server. An error occurred.");
                return;
            }
        }
    }
}
