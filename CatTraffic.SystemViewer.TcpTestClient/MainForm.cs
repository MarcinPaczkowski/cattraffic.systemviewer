using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatTraffic.SystemViewer.TcpTestClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void uxTest_Click(object sender, EventArgs e)
        {
            var port = Convert.ToInt32(uxPort.Text);
            var host = uxIpAddress.Text;
            var client = new System.Net.Sockets.TcpClient(host, port);
            var data = new byte[] { 0x02, 0x68, 0x2b };
            var stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            stream.Flush();
            stream.Close();
            client.Close();
        }
    }
}
