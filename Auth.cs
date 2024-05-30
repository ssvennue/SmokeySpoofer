using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokeySpoofer
{
    public partial class Auth : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Auth()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authenticate(textBox1.Text, this);
        }
        
        private static async void Authenticate(string AccessKey, Form currentForm)
        {
            try
            {
                string ActiveAccessKey;
                using (WebClient client = new WebClient())
                {
                    client.Proxy = new WebProxy("REDACTED", 0000);
                    ActiveAccessKey = client.DownloadString("REDACTED");
                    client.Dispose();
                }
                if (ActiveAccessKey == AccessKey)
                {
                    var mF = new Main();
                    currentForm.Hide();
                    mF.Show();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("REDACTED");
        }
    }
}
