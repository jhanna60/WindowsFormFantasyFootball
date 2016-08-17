using Newtonsoft.Json;
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
    public partial class FootballerStats : Form
    {
        WebClient client = new WebClient();

        FootballerHistory root = new FootballerHistory();

        public FootballerStats(Footballer fb)
        {
            InitializeComponent();


            string photourl = "https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/110x140/p" + fb.photo + ".png" ;

            try
            {
                pbPlayer.Load(photourl);
            }
            catch (Exception)
            {
            }

            var proxy = client.Proxy;
            client.UseDefaultCredentials = true;
            client.Proxy.Credentials = CredentialCache.DefaultCredentials;

            ServicePointManager.DefaultConnectionLimit = 300;

            // I need to Deserialise the JSON API object into RootObject, then I need to pick
            // out the Footballers and return them, also I can return the Events list

            Stream stream = client.OpenRead("https://fantasy.premierleague.com/drf/element-summary/"+fb.id);

            using (StreamReader reader = new StreamReader(stream))
            {
                root = (FootballerHistory)JsonConvert.DeserializeObject(reader.ReadLine(), typeof(FootballerHistory));
            }

            if (root !=null)
            {
                Label[] labels = { lblFixture0, lblFixture1, lblFixture2, lblFixture3, lblFixture4 };

                for (int i = 0; i < 5; i++)
                {
                    string fixture = root.fixtures[i].is_home ? " (H)" : " (A)";
                    labels[i].Text = root.fixtures[i].event_name + Environment.NewLine + Environment.NewLine + root.fixtures[i].opponent_name 
                        + fixture + Environment.NewLine + Environment.NewLine + root.fixtures[i].kickoff_time_formatted ;

                    switch (root.fixtures[i].difficulty)
                    {
                        case 1:
                            labels[i].BackColor = Color.Green;
                            break;
                        case 2:
                            labels[i].BackColor = Color.DarkSeaGreen;
                            break;
                        case 3:
                            labels[i].BackColor = Color.LightGoldenrodYellow;
                            break;
                        case 4:
                            labels[i].BackColor = Color.Orange;
                            break;
                        case 5:
                            labels[i].BackColor = Color.Firebrick;
                            break;
                        default:
                            break;
                    }
                }

                var history = new HashSet<string>();

                foreach (var year in root.history_past)
                {
                    history.Add(year.season_name);
                }

                var histArr = history.ToArray();
                Array.Sort(histArr);
                Array.Reverse(histArr);

                cboHistory.Items.AddRange(histArr);
                if (cboHistory.Items.Count > 0) {
                    cboHistory.SelectedIndex = 0;
                }
                
            }

            lblFirstName.Text = fb.first_name;
            lblSurname.Text = fb.second_name;
        }

        private void cboHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalPoints.Text = root.history_past[(cboHistory.Items.Count -1) - cboHistory.SelectedIndex].total_points.ToString();
            lblGoals.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].goals_scored.ToString();
            lblAssists.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].assists.ToString();
            lblStartCost.Text = ((decimal)root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].start_cost / 10).ToString();
            lblEndCost.Text = (((decimal)root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].end_cost) / 10).ToString();
            lblMinutes.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].minutes.ToString();
            lblCleanSheets.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].clean_sheets.ToString();
            lblGoalsConceded.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].goals_conceded.ToString();
            lblOwnGoals.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].own_goals.ToString();
            lblPenSaved.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].penalties_saved.ToString();
            lblPenMissed.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].penalties_missed.ToString();
            lblYellowCards.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].yellow_cards.ToString();
            lblRedCards.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].red_cards.ToString();
            lblSaves.Text = root.history_past[(cboHistory.Items.Count - 1) - cboHistory.SelectedIndex].saves.ToString();
        }
    }
}
