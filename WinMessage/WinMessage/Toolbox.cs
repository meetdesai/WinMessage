using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPFramework.Forms;
using MetroFramework.Forms;

namespace WinMessage
{
    public partial class Toolbox : MetroForm
    {
        public Toolbox()
        {
            InitializeComponent();
        }

        private void Toolbox_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("USBTool.exe");
            }
            catch
            {
                MessageBox.Show("A fatal error occurred launching USBTool.");
            }
        }
    }
}
