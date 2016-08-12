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

            lblPhoto.Text = ID.ToString();

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
                lblPhoto.Text = root.fixtures[0].opponent_name;
            }
        }
    }
}
