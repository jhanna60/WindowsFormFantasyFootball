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

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var players = listA.Where(player => player.Team != "");

            if ((string)TeamComboBox.SelectedItem == "ALL")
            {
                dataGridView1.DataSource = players.ToList();
            }
            else
            {
                players = listA.Where(player => player.Team == (string)TeamComboBox.SelectedItem);

                dataGridView1.DataSource = players.ToList();
            }
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
            var positions = listA.Select(player => player.Position).Distinct();

            // Initialising the Team Combo Box
            TeamComboBox.Items.Clear();
            TeamComboBox.Items.Add("ALL");
            TeamComboBox.Items.AddRange(teams.ToArray());
            TeamComboBox.SelectedIndex = 0;

            // Initialising the Positions Combo Box
            PositionComboBox.Items.Clear();
            PositionComboBox.Items.Add("ALL");
            PositionComboBox.Items.AddRange(positions.ToArray());
            PositionComboBox.SelectedIndex = 0;


            label1.Text = "Footballer Info Loaded Successfully from website";
        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var players = dataGridView1.DataSource;

            var players = listA.Where(player => player.Position == (string)PositionComboBox.SelectedItem);

            dataGridView1.DataSource = players.ToList();

        }
    }
}
