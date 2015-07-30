namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private readonly List<Footballer> _footballers = new List<Footballer>();

        public Form1()
        {
            // Initialise the form and set up our stream from constructor
            InitializeComponent();

            var webRequest = WebRequest.Create(@"http://fantasyoverlord.com/FPL/Data");

            var proxy = webRequest.Proxy;
            if (proxy != null)
            {
                var proxyUri = proxy.GetProxy(webRequest.RequestUri).ToString();
                webRequest.UseDefaultCredentials = true;
                webRequest.Proxy = new WebProxy(proxyUri, false);
                webRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
            }

            using (var response = webRequest.GetResponse())
            {
                var responseStream = response.GetResponseStream();
                var streamReader = new StreamReader(responseStream);
                Footballer.LoadFromCSV(streamReader, _footballers);
            }

            var teams = _footballers.Select(player => player.Team).Distinct();
            var positions = _footballers.Select(player => player.Position).Distinct();

            // Initialising the Team Combo Box
            cboTeams.Items.Clear();
            cboTeams.Items.Add("ALL");
            cboTeams.Items.AddRange(teams.ToArray());
            cboTeams.SelectedIndex = 0;

            // Initialising the Positions Combo Box
            cboPositions.Items.Clear();
            cboPositions.Items.Add("ALL");
            cboPositions.Items.AddRange(positions.ToArray());
            cboPositions.SelectedIndex = 0;

            lblLoadedSuccessMessage.Text = "Footballer Info Loaded Successfully from website";
        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataOutput();
        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataOutput();
        }

        private void DataOutput()
        {
            // This method analyses the contents of the drop down boxes and generates
            // LINQ statements to filter depending on what the user input

            var players = _footballers.Where(player => player.Team != "");

            if ((string) cboPositions.SelectedItem == "ALL" &&
                (string) cboTeams.SelectedItem == "ALL") { }
            else if ((string) cboPositions.SelectedItem == "ALL")
            {
                players = _footballers.Where(player => player.Team == (string) cboTeams.SelectedItem);
            }
            else if ((string) cboTeams.SelectedItem == "ALL")
            {
                players = _footballers.Where(player => player.Position == (string) cboPositions.SelectedItem);
            }
            else
            {
                players = _footballers.Where(player => player.Position == (string) cboPositions.SelectedItem &&
                                                       player.Team == (string) cboTeams.SelectedItem);
            }

            dbgPlayers.DataSource = players.ToList();

            dbgPlayers.DataSource = players.ToList();

            //Make columns sortable

            foreach (DataGridViewColumn column in dbgPlayers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
    }
}