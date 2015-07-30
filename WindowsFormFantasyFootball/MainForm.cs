namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private readonly IEnumerable<Footballer> _footballers;
        
        public MainForm(IEnumerable<Footballer> footballers)
        {
            _footballers = footballers;

            // Initialise the form and set up our stream from constructor
            InitializeComponent();

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

            //Make columns sortable

            foreach (DataGridViewColumn column in dbgPlayers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
    }
}