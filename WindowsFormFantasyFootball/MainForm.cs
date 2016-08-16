namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private readonly FootballersDataSet.FootballersDataTable _footballersDataTable;

        double totGK, totDEF, totMID, totFWD, totPlayers;

        public MainForm(FootballersDataSet.FootballersDataTable footballersDataTable, List<Event> events)
        {
            // Initialise the form and set up our stream from constructor
            InitializeComponent();

            _footballersDataTable = footballersDataTable;

            //Setup a list of Teams,Positions and Price
            var teams = new HashSet<string>();
            var positions = new HashSet<string>();
            var price = new HashSet<decimal>();

            foreach (var row in _footballersDataTable.AsEnumerable())
            {
                teams.Add(row.Team);
                positions.Add(row.Position);
                price.Add(row.Cost);
            }

            //Work out some high level stats to display
            foreach (var f in footballersDataTable)
            {
                switch (f.Position)
                {
                    case "Goalkeeper":
                        totGK += f.TotalPoints;
                        break;
                    case "Defender":
                        totDEF += f.TotalPoints;
                        break;
                    case "Midfielder":
                        totMID += f.TotalPoints;
                        break;
                    case "Forward":
                        totFWD += f.TotalPoints;
                        break;
                    default:
                        break;
                }

                totPlayers += 1;
            }

            //Display the stats
            lblTotGK.Text = totGK.ToString();
            lblTotDef.Text = totDEF.ToString();
            lblTotMids.Text = totMID.ToString();
            lblTotFwds.Text = totFWD.ToString();
            lblTotPlayers.Text = totPlayers.ToString();

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

            //Freezing the Surname column so it stays when scrolling the data Horizontally
            dbgPlayers.Columns["surname"].Frozen = true;

            //Setting the News Column so we can see all the contents
            dbgPlayers.Columns["news"].Width = 250;

            //Hiding some fields from the end user
            dbgPlayers.Columns["status"].Visible = false;
            dbgPlayers.Columns["InDreamteam"].Visible = false;
            dbgPlayers.Columns["MyTeam"].Visible = false;
            dbgPlayers.Columns["Photo"].Visible = false;
            dbgPlayers.Columns["ID"].Visible = false;

            //Setting the All view to checked by default so we display all the data
            rdoAll.Checked = true;

            //Using my helper method to set the Datagrid View to Double buffered for performance improvements
            dbgPlayers.DoubleBuffered(true);

            // Put each of the columns into programmatic sort mode so we can implement our own custom sort
            foreach (DataGridViewColumn column in dbgPlayers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            //Utilise our column selector class
            DataGridViewColumnSelector cs = new DataGridViewColumnSelector(dbgPlayers);

            rdoTeam.Enabled = false;

            // Find out what event we are at
            int index = 0;
            while (true)
            {
                if (!events[index].finished)
                {
                    break;
                }
                index++;
            }

            lblCurrentRound.Text = events[index].id.ToString();
            lblDeadline.Text = events[index].deadline_time_formatted;

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

        //Output our data based on the filters and reset other filters
        private void DataOutput()
        {
            if (!rdoAll.Checked == true)
            {
                rdoAll.Checked = true;
            }

            var teamFilter = cboTeams.Text == "ALL" ? "%" : cboTeams.Text;
            var positionFilter = cboPositions.Text == "ALL" ? "%" : cboPositions.Text;
            var costFilter = decimal.Parse(cboPrice.Text == "ALL" ? "15000000" : cboPrice.Text);

            var filter = string.Format("Team LIKE '{0}' AND Position LIKE '{1}' AND Cost <= '{2}'", teamFilter, positionFilter, costFilter);

            _footballersDataTable.DefaultView.RowFilter = filter;

            UpdateInjuries();
        }

        private void UpdateInjuries()
        {
            foreach (DataGridViewRow row in dbgPlayers.Rows)
            {
                string RowType = row.Cells[43].Value.ToString();

                if (RowType == "i" || RowType == "s" || RowType == "u" || RowType == "n")
                {
                    row.DefaultCellStyle.BackColor = Color.Tomato;
                }
                else if (RowType == "d")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        //Resetting all our filter indexes
        private void btnReset_Click(object sender, EventArgs e)
        {
            cboPositions.SelectedIndex = 0;
            cboTeams.SelectedIndex = 0;
            cboPrice.SelectedIndex = 0;
            tbSearch.Text = "";
            rdoAll.Checked = true;
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked == true)
            {
                DataOutput();
            }
        }

        private void rdoDream_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDream.Checked == true)
            {
                (dbgPlayers.DataSource as DataTable).DefaultView.RowFilter = "InDreamteam = true";
                dbgPlayers.Refresh();
                UpdateInjuries();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateInjuries();
        }

        private void dbgPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string photo = dbgPlayers.Rows[e.RowIndex].Cells[44].Value.ToString();
            int id = Convert.ToInt32(dbgPlayers.Rows[e.RowIndex].Cells[45].Value);

            FootballerStats frm = new FootballerStats(photo,id);
            frm.Show();
        }

        private void rdoTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTeam.Checked == true)
            {
                (dbgPlayers.DataSource as DataTable).DefaultView.RowFilter = "MyTeam = true";
                dbgPlayers.Refresh();
                UpdateInjuries();
            }
        }

        //Custom sort so we can sort Descending first and then Ascending
        private void dbgPlayers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                DataGridViewColumn newColumn = dbgPlayers.Columns[e.ColumnIndex];
                DataGridViewColumn oldColumn = dbgPlayers.SortedColumn;
                ListSortDirection direction;

                // If oldColumn is null, then the DataGridView is not sorted. 
                if (oldColumn != null)
                {
                    // Sort the same column again, reversing the SortOrder. 
                    if (oldColumn == newColumn &&
                        dbgPlayers.SortOrder == SortOrder.Descending)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        // Sort a new column and remove the old SortGlyph.
                        direction = ListSortDirection.Descending;
                        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                    }
                }
                else
                {
                    direction = ListSortDirection.Descending;
                }

                // Sort the selected column.
                dbgPlayers.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;

                UpdateInjuries();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                DataOutput();
            }
            else
            {
                (dbgPlayers.DataSource as DataTable).DefaultView.RowFilter = "FirstName LIKE '" + tbSearch.Text + "%' OR Surname LIKE '" + tbSearch.Text + "%'" ;
                dbgPlayers.Refresh();
                UpdateInjuries();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the program
            Close();
        }
    }
}