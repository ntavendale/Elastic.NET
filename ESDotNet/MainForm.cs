using System;
using System.Text;
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
            var json = new StringBuilder();
            json.Append(("{                                                      ").Trim());
            json.Append(("\"settings\":{                                         ").Trim());
            json.Append(("                \"index\":{                            ").Trim());
            json.Append(string.Format("                       \"number_of_shards\":{0}, ", shards).Trim());
            json.Append(string.Format("                       \"number_of_replicas\":{0}", replicas).Trim());
            json.Append(("                          }                            ").Trim());
            json.Append(("             }                                         ").Trim());
            json.Append(("}                                                      ").Trim());
            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, tbCreateIndex.Text, 9200);
            var res = client.PutAsync(json.ToString()).Result;
            tbOutput.Text = tbOutput.Text + string.Format("PUT {0} at {1} Result = {2}",json,  client.FullURL, res) + Environment.NewLine;
        }

        private void btnAddWithID_Click(object sender, EventArgs e)
        {
            var json = new StringBuilder();
            json.Append(("{                                                 ").Trim());
            json.Append(("  \"type\":\"BSD\",                               ").Trim());
            json.Append(("  \"facility\":\"UserLevel\",                     ").Trim());
            json.Append(("  \"severity\":\"Debug\",                         ").Trim());
            json.Append(("  \"timeStamp\":\"2018-07-01T18:24:02.662Z\",     ").Trim());
            json.Append(("  \"host\":\"localhost\",                         ").Trim());
            json.Append(("  \"process\":\"MyProcess\",                      ").Trim());
            json.Append(("  \"processId\":99,                               ").Trim());
            json.Append(("  \"text\":\"This is a test message with an ID!\" ").Trim());
            json.Append(("}                                                 ").Trim());

            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, "20180701/message/DocID01", 9200);
            var res = client.PutAsync(json.ToString()).Result; //Put when we have ID
            tbOutput.Text = tbOutput.Text + string.Format("PUT {0} at {1} Result = {2}", json, client.FullURL, res) + Environment.NewLine;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var json = new StringBuilder();
            json.Append(("{                                                 ").Trim());
            json.Append(("  \"type\":\"BSD\",                               ").Trim());
            json.Append(("  \"facility\":\"UserLevel\",                     ").Trim());
            json.Append(("  \"severity\":\"Debug\",                         ").Trim());
            json.Append(("  \"timeStamp\":\"2018-07-01T18:24:02.662Z\",     ").Trim());
            json.Append(("  \"host\":\"localhost\",                         ").Trim());
            json.Append(("  \"process\":\"MyProcess\",                      ").Trim());
            json.Append(("  \"processId\":99,                               ").Trim());
            json.Append(("  \"text\":\"This is an updated test message !!!!!!!\" ").Trim());
            //json.Append(("  \"text2\":\"And I am an extra field!!!!!!!\" ").Trim());
            json.Append(("}                                                 ").Trim());

            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, "20180701/message/DocID01", 9200);
            var res = client.PutAsync(json.ToString()).Result; //Put when we have ID
            tbOutput.Text = tbOutput.Text + string.Format("PUT {0} at {1} Result = {2}", json, client.FullURL, res) + Environment.NewLine;
        }

        private void btnAddWithNoID_Click(object sender, EventArgs e)
        {
            var json = new StringBuilder();
            json.Append(("{                                                 ").Trim());
            json.Append(("  \"type\":\"BSD\",                               ").Trim());
            json.Append(("  \"facility\":\"UserLevel\",                     ").Trim());
            json.Append(("  \"severity\":\"Debug\",                         ").Trim());
            json.Append(("  \"timeStamp\":\"2018-07-01T18:24:02.662Z\",     ").Trim());
            json.Append(("  \"host\":\"localhost\",                         ").Trim());
            json.Append(("  \"process\":\"MyProcess\",                      ").Trim());
            json.Append(("  \"processId\":99,                               ").Trim());
            json.Append(("  \"text\":\"This is a test message witnh no ID\" ").Trim());
            json.Append(("}                                                 ").Trim());

            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, "20180701/message", 9200);
            var res = client.PostAsync(json.ToString()).Result; //Post when we have no ID and want ES to auto assign one
            tbOutput.Text = tbOutput.Text + string.Format("POST {0} at {1} Result = {2}", json, client.FullURL, res) + Environment.NewLine;
        }

        private void btnSingleIndex_Click(object sender, EventArgs e)
        {
            var json = new StringBuilder();
            json.Append("{\"index\":{}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"MailSystem\",\"severity\":\"Critical\",\"timeStamp\":\"2017-06-14T06:00:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0018 Reconnaissance activity detected 111.148.118.9:40083 -> 161.200.1.9:443 TCP\"}" + Environment.NewLine);
            json.Append("{\"index\":{}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"SysLogInternal\",\"severity\":\"Error\",\"timeStamp\":\"2017-06-14T06:05:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0043 Host: 172.10.1.14 has a vulnerability on port: 80 protocol: http\"}" + Environment.NewLine);
            json.Append("{\"index\":{}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"SysLogInternal\",\"severity\":\"Critical\",\"timeStamp\":\"2017-06-14T06:10:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0042 120.213.104.204 accessed url: http:\\/\\/Website001.com at UserPC5\"}" + Environment.NewLine);
            json.Append("{\"index\":{}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"SystemDaemon\",\"severity\":\"Emergency\",\"timeStamp\":\"2017-06-14T06:15:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0024 Accepted packet 66.2.30.3:40076 -> WebServer2.acme.com:1352 TCP\"}" + Environment.NewLine);
            json.Append("{\"index\":{}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"Kernel\",\"severity\":\"Emergency\",\"timeStamp\":\"2017-06-14T06:20:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0000 Server2: miscellaneous log message\"}" + Environment.NewLine);

            //Index not part of the update above so it must be in the URL
            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, "20180614/message/_bulk", 9200);
            var res = client.PostAsync(json.ToString()).Result; 
            tbOutput.Text = tbOutput.Text + string.Format("POST {0} at {1} Result = {2}", json, client.FullURL, res) + Environment.NewLine;
        }

        private void btnMultiIndex_Click(object sender, EventArgs e)
        {
            var json = new StringBuilder();
            json.Append("{\"index\":{\"_index\" : \"20170615\", \"_type\" : \"message\"}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"MailSystem\",\"severity\":\"Critical\",\"timeStamp\":\"2017-06-15T06:00:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0018 Reconnaissance activity detected 111.148.118.9:40083 -> 161.200.1.9:443 TCP\"}" + Environment.NewLine);
            json.Append("{\"index\":{\"_index\" : \"20170615\", \"_type\" : \"message\"}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"SysLogInternal\",\"severity\":\"Error\",\"timeStamp\":\"2017-06-15T06:05:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0043 Host: 172.10.1.14 has a vulnerability on port: 80 protocol: http\"}" + Environment.NewLine);
            json.Append("{\"index\":{\"_index\" : \"20170615\", \"_type\" : \"message\"}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"SysLogInternal\",\"severity\":\"Critical\",\"timeStamp\":\"2017-06-16T06:10:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0042 120.213.104.204 accessed url: http:\\/\\/Website001.com at UserPC5\"}" + Environment.NewLine);
            json.Append("{\"index\":{\"_index\" : \"20170616\", \"_type\" : \"message\"}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"SystemDaemon\",\"severity\":\"Emergency\",\"timeStamp\":\"2017-06-16T06:15:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0024 Accepted packet 66.2.30.3:40076 -> WebServer2.acme.com:1352 TCP\"}" + Environment.NewLine);
            json.Append("{\"index\":{\"_index\" : \"20170616\", \"_type\" : \"message\"}}" + Environment.NewLine);
            json.Append("{ \"type\":\"BSD\",\"facility\":\"Kernel\",\"severity\":\"Emergency\",\"timeStamp\":\"2017-06-16T06:20:00.000Z\",\"host\":\"192.168.8.1\",\"process\":\"SysLogSimSvc\",\"processId\":2559,\"text\":\"EVID:0000 Server2: miscellaneous log message\"}" + Environment.NewLine);
            //Index not part of the update above so it must be in the URL
            var client = new EndpointClient("http://127.0.0.1", string.Empty, string.Empty, "_bulk", 9200);
            var res = client.PostAsync(json.ToString()).Result;
            tbOutput.Text = tbOutput.Text + string.Format("POST {0} at {1} Result = {2}", json, client.FullURL, res) + Environment.NewLine;
        }
    }
}
