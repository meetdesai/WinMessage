/*

 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Awesomium.Core;
using System.IO;
using System.Diagnostics;
using System.Web;
using System.Net;

namespace WinMessage
{
	/// <summary>
	/// Description of WinMessage.
	/// </summary>
	public partial class WinMessage : MetroForm
	{
		private string ServerURL;
        private string Username;
        private string Password;
		public WinMessage(string serverUrl, string un, string pw)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ServerURL = serverUrl;
            Username = un;
            Password = pw;
            this.KeyPreview = true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        void webControl1_CertificateError(object sender, CertificateErrorEventArgs e)
        {
            e.Handled = EventHandling.Modal;
            e.Ignore = true;
        }
        void WinMessageLoad(object sender, EventArgs e)
		{
            webControl1.Source = new Uri(ServerURL);
            webControl1.CertificateError += new CertificateErrorEventHandler(webControl1_CertificateError);
            webControl1.LoginRequest += WebControl1_LoginRequest;
        }

        private void WebControl1_LoginRequest(object sender, LoginRequestEventArgs e)
        {
            e.Username = Username;
            e.Password = Password;
            e.Handled = EventHandling.Modal;
            e.Cancel = false;
        }

        private void WinMessage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void WinMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
        	WebCore.Shutdown();
        	DeleteCache();
        	Application.Exit();
        }
        private void DeleteCache()
		{
		  ProcessStartInfo info = new ProcessStartInfo();
		  // get the full path to the Awesomium cache directory
		  string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cache");
		  string command = String.Format("RMDIR /S /Q \"{0}\"", path);
		
		  // get the path to cmd.exe
		  info.FileName = System.Environment.GetEnvironmentVariable("COMSPEC") ?? "cmd.exe";
		
		  // append the cmd.exe flags to disable auto-run scripts (/D) and to exit at completion (/C)
		  info.Arguments = String.Concat("/D /C ", command);
		  info.WindowStyle = ProcessWindowStyle.Hidden;
		
		  // start the process without waiting for completion
		  Process.Start(info);
		}
    }
}
