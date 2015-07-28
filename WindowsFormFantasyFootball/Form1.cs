using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFantasyFootball
{
    public partial class Form1 : Form
    {
        private List<Footballer> listA = new List<Footballer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var players = listA.Where(player => player.Team == (string)comboBox1.SelectedItem);

            dataGridView1.DataSource = players.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var webRequest = WebRequest.Create(@"http://fantasyoverlord.com/FPL/Data");

            IWebProxy proxy = webRequest.Proxy;
            if (proxy != null)
            {
                string proxyuri = proxy.GetProxy(webRequest.RequestUri).ToString();
                webRequest.UseDefaultCredentials = true;
                webRequest.Proxy = new WebProxy(proxyuri, false);
                webRequest.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            }


            using (var response = webRequest.GetResponse())
            {
                var responseStream = response.GetResponseStream();

                var streamReader = new StreamReader(responseStream);
                Footballer.LoadFromCSV(streamReader, listA);
           
            }

            var teams = listA.Select(player => player.Team).Distinct();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(teams.ToArray());
            comboBox1.SelectedIndex = 0;

            label1.Text = "Footballer Info Loaded Successfully from website";
        }
    }
}
