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
                
                // Working out our History drop down list and setting it
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

                //Working out our current game week hist and setting it
                var gwHistory = new HashSet<string>();

                foreach (var week in root.history)
                {
                    gwHistory.Add(week.round.ToString());
                }

                var gwHistArr = gwHistory.ToArray();
                Array.Sort(gwHistArr);
                Array.Reverse(gwHistArr);

                cboGameHist.Items.AddRange(gwHistArr);
                if (cboGameHist.Items.Count > 0)
                {
                    cboGameHist.SelectedIndex = 0;
                }


            }

            lblFirstName.Text = fb.first_name;
            lblSurname.Text = fb.second_name;
            lblPosition.Text = fb.web_name;
            lblTeam.Text = fb.squad_number;
            lblCost.Text = fb.selected_by_percent;
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

        private void cboGameHist_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGPoints.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].total_points.ToString();
            lblGGoals.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].goals_scored.ToString();
            lblGAssists.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].assists.ToString();
            lblGMinutes.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].minutes.ToString();
            lblGBonusPoints.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].bonus.ToString();
            lblGGoalsConceded.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].goals_conceded.ToString();
            lblGOwnGoals.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].own_goals.ToString();
            lblGYellowCard.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].yellow_cards.ToString();
            lblGRedCard.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].red_cards.ToString();
            lblGSaves.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].saves.ToString();
            lblGPenSaved.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].penalties_saved.ToString();
            lblGPenMissed.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].penalties_missed.ToString();
            lblGOPC.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].open_play_crosses.ToString();
            lblGBCC.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].big_chances_created.ToString();
            lblGCBI.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].clearances_blocks_interceptions.ToString();
            lblGRecoveries.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].recoveries.ToString();
            lblGKeyPasses.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].key_passes.ToString();
            lblGTackles.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].tackles.ToString();
            lblGWG.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].winning_goals.ToString();
            lblGAP.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].attempted_passes.ToString();
            lblGCP.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].completed_passes.ToString();
            lblGPC.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].penalties_conceded.ToString();
            lblGBCM.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].big_chances_missed.ToString();
            lblGELG.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].errors_leading_to_goal.ToString();
            lblGELGA.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].errors_leading_to_goal_attempt.ToString();
            lblGTackled.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].tackled.ToString();
            lblGOffside.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].offside.ToString();
            lblGTM.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].target_missed.ToString();
            lblGFouls.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].fouls.ToString();
            lblGDribbles.Text = root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].dribbles.ToString();
            lblGCost.Text = (((decimal)root.history[(cboGameHist.Items.Count - 1) - cboGameHist.SelectedIndex].value / 10).ToString());
        }
    }
}
