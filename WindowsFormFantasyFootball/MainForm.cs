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
            var price = new HashSet<int>();

            foreach (var row in _footballersDataTable.AsEnumerable())
            {
                teams.Add(row.Team);
                positions.Add(row.Position);
                price.Add(row.Cost);
            }

            var teamArr = teams.ToArray();
            Array.Sort(teamArr);

            var priceArr = price.ToArray();
            Array.Sort(priceArr);
            Array.Reverse(priceArr);

            // Initialising the Team Combo Box
            cboTeams.Items.Add("ALL");
            cboTeams.Items.AddRange(teamArr.ToArray());

            // Initialising the Positions Combo Box
            cboPositions.Items.Add("ALL");
            cboPositions.Items.AddRange(positions.ToArray());

            // Initialising the Price Combo Box
            cboPrice.Items.Add("ALL");
            cboPrice.Items.AddRange(priceArr.Cast<object>().ToArray());

            //Setting the initial Combo Box indexes to 0
            cboPrice.SelectedIndex = 0;
            cboTeams.SelectedIndex = 0;
            cboPositions.SelectedIndex = 0;

            dbgPlayers.DataSource = _footballersDataTable;
            dbgPlayers.Columns["surname"].Frozen = true;
        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataOutput();
        }

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataOutput();
        }

        private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataOutput();
        }

        private void DataOutput()
        {
            var teamFilter = cboTeams.Text == "ALL" ? "%" : cboTeams.Text;
            var positionFilter = cboPositions.Text == "ALL" ? "%" : cboPositions.Text;
            var costFilter = int.Parse(cboPrice.Text == "ALL" ? "15000000" : cboPrice.Text);

            var filter = string.Format("Team LIKE '{0}' AND Position LIKE '{1}' AND Cost <= '{2}'", teamFilter, positionFilter, costFilter);

            _footballersDataTable.DefaultView.RowFilter = filter;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboPositions.SelectedIndex = 0;
            cboTeams.SelectedIndex = 0;
            cboPrice.SelectedIndex = 0;
        }
    }
}