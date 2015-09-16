using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace WindowsFormFantasyFootball
{
    public class FixtureHistory
    {
        public List<List<object>> all { get; set; }
        public List<List<object>> summary { get; set; }
    }

    public class Fixtures
    {
        public List<List<string>> all { get; set; }
        public List<List<object>> summary { get; set; }
    }

    public class footballer1
    {
        public int id { get; set; }
        public string photo { get; set; }
        public string web_name { get; set; }
        public List<List<object>> event_explain { get; set; }
        public FixtureHistory fixture_history { get; set; }
        public List<List<object>> season_history { get; set; }
        public Fixtures fixtures { get; set; }
        public int event_total { get; set; }
        public string type_name { get; set; }
        public string team_name { get; set; }
        public string selected_by { get; set; }
        public int total_points { get; set; }
        public string current_fixture { get; set; }
        public string next_fixture { get; set; }
        public int team_code { get; set; }
        public string news { get; set; }
        public int team_id { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public int now_cost { get; set; }
        public object chance_of_playing_this_round { get; set; }
        public object chance_of_playing_next_round { get; set; }
        public string value_form { get; set; }
        public string value_season { get; set; }
        public int cost_change_start { get; set; }
        public int cost_change_event { get; set; }
        public int cost_change_start_fall { get; set; }
        public int cost_change_event_fall { get; set; }
        public bool in_dreamteam { get; set; }
        public int dreamteam_count { get; set; }
        public string selected_by_percent { get; set; }
        public string form { get; set; }
        public int transfers_out { get; set; }
        public int transfers_in { get; set; }
        public int transfers_out_event { get; set; }
        public int transfers_in_event { get; set; }
        public int loans_in { get; set; }
        public int loans_out { get; set; }
        public int loaned_in { get; set; }
        public int loaned_out { get; set; }
        public int event_points { get; set; }
        public string points_per_game { get; set; }
        public string ep_this { get; set; }
        public string ep_next { get; set; }
        public bool special { get; set; }
        public int minutes { get; set; }
        public int goals_scored { get; set; }
        public int assists { get; set; }
        public int clean_sheets { get; set; }
        public int goals_conceded { get; set; }
        public int own_goals { get; set; }
        public int penalties_saved { get; set; }
        public int penalties_missed { get; set; }
        public int yellow_cards { get; set; }
        public int red_cards { get; set; }
        public int saves { get; set; }
        public int bonus { get; set; }
        public int ea_index { get; set; }
        public int bps { get; set; }
        public int element_type { get; set; }
        public int team { get; set; }
    }

    public class test
    {
        WebClient client = new WebClient();

        var proxy = client.Proxy;
        client.UseDefaultCredentials = true;
            client.Proxy.Credentials = CredentialCache.DefaultCredentials;

            Stream stream = client.OpenRead("http://fantasy.premierleague.com/web/api/elements/130/");
        StreamReader reader = new StreamReader(stream);

        footballer f = JsonConvert.DeserializeObject<footballer>(reader.ReadLine());

        Console.WriteLine("name : {0} {1} {2} ",f.first_name, f.second_name, f.news);

            foreach (var i in f.fixture_history.summary[2])
            {
                Console.WriteLine(i);
            }

    Console.ReadLine();
    }

}
