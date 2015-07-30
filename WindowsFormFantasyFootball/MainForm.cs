namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private readonly FootballersDataSet.FootballersDataTable _footballersDataTable;

        public MainForm(FootballersDataSet.FootballersDataTable footballersDataTable)
        {
            // Initialise the form and set up our stream from constructor
            InitializeComponent();

            _footballersDataTable = footballersDataTable;

            var teams = new HashSet<string>();
            var positions = new HashSet<string>();

            foreach (var row in _footballersDataTable.AsEnumerable())
            {
                teams.Add(row.Team);
                positions.Add(row.Position);
            }

            // Initialising the Team Combo Box
            cboTeams.Items.Add("ALL");
            cboTeams.Items.AddRange(teams.ToArray());
            cboTeams.SelectedIndex = 0;

            // Initialising the Positions Combo Box
            cboPositions.Items.Add("ALL");
            cboPositions.Items.AddRange(positions.ToArray());
            cboPositions.SelectedIndex = 0;

            dbgPlayers.DataSource = _footballersDataTable;
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
            var teamFilter = cboTeams.Text == "ALL" ? "%" : cboTeams.Text;
            var positionFilter = cboPositions.Text == "ALL" ? "%" : cboPositions.Text;

            var filter = string.Format("Team LIKE '{0}' AND Position LIKE '{1}'", teamFilter, positionFilter);

            _footballersDataTable.DefaultView.RowFilter = filter;
        }
    }
}