using System;
using System.Net;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using endpoint;

namespace ESDotNet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormInit();
        }

        private void FormInit()
        {
            var dt = DateTime.Now;
            tbIndexExists.Text = string.Format("{0:D4}{1:D2}{2:D2}", dt.Year, dt.Month, dt.Day);
            tbCreateIndex.Text = string.Format("{0:D4}{1:D2}{2:D2}", dt.Year, dt.Month, dt.Day);
            tbShards.Text = "5";
            tbReplicas.Text = "2";
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, string.Empty, 9200);
            var res = client.Get().Result;
            tbOutput.Text = tbOutput.Text + res + Environment.NewLine;
        }

        private void btnIndexExists_Click(object sender, EventArgs e)
        {
            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, tbIndexExists.Text, 9200);
            var res = client.HeadAsync().Result;
            tbOutput.Text = tbOutput.Text + string.Format("HEAD {0} Result = {1}", client.FullURL, res) + Environment.NewLine;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var shards = Convert.ToInt32(tbShards.Text);
            var replicas = Convert.ToInt32(tbReplicas.Text);
            var json = string.Format("{{\"settings\":{{\"index\":{{\"number_of_shards\":{1},\"number_of_replicas\":{1}}}}}}}", shards, replicas);
            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, tbCreateIndex.Text, 9200);
            var res = client.PutAsync(json).Result;
            tbOutput.Text = tbOutput.Text + string.Format("PUT {0} at {1} Result = {2}",json,  client.FullURL, res) + Environment.NewLine;
        }
    }
}
