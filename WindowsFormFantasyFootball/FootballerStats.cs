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
                    labels[i].Text = root.fixtures[i].event_name + Environment.NewLine + root.fixtures[i].opponent_name;

                    switch (root.fixtures[i].difficulty)
                    {
                        case 1:
                            labels[i].BackColor = Color.Green;
                            break;
                        case 2:
                            labels[i].BackColor = Color.DarkSeaGreen;
                            break;
                        case 3:
                            labels[i].BackColor = Color.LightYellow;
                            break;
                        case 4:
                            labels[i].BackColor = Color.Orange;
                            break;
                        case 5:
                            labels[i].BackColor = Color.DarkRed;
                            break;
                        default:
                            break;
                    }
                }
                //lblFixture0.Text = root.fixtures[0].event_name + Environment.NewLine + root.fixtures[0].opponent_name;
                //switch (root.fixtures[0].difficulty)
                //{
                //    case 1:
                //        lblFixture0.BackColor = Color.Green;
                //            break;
                //    case 2:
                //        lblFixture0.BackColor = Color.DarkSeaGreen;
                //        break;
                //    case 3:
                //        lblFixture0.BackColor = Color.LightYellow;
                //        break;
                //    case 4:
                //        lblFixture0.BackColor = Color.Orange;
                //        break;
                //    case 5:
                //        lblFixture0.BackColor = Color.DarkRed;
                //        break;
                //    default:
                //        break;
                //}
                //lblFixture1.Text = root.fixtures[1].event_name + Environment.NewLine + root.fixtures[1].opponent_name;
                //lblFixture2.Text = root.fixtures[2].event_name + Environment.NewLine + root.fixtures[2].opponent_name;
                //lblFixture3.Text = root.fixtures[3].event_name + Environment.NewLine + root.fixtures[3].opponent_name;
                //lblFixture4.Text = root.fixtures[4].event_name + Environment.NewLine + root.fixtures[4].opponent_name;
            }
        }
    }
}
