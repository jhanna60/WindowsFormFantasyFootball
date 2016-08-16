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

        public FootballerStats(string photo, int ID)
        {
            InitializeComponent();


            string photourl = "https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/110x140/p" + photo + ".png" ;

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

            Stream stream = client.OpenRead("https://fantasy.premierleague.com/drf/element-summary/"+ID);

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
                    labels[i].Text = root.fixtures[i].event_name + Environment.NewLine + Environment.NewLine + root.fixtures[i].opponent_name + fixture;

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
        }
    }
}
