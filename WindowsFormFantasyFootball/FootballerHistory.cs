using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormFantasyFootball
{

    public class HistoryPast
    {
        public int id { get; set; }
        public string season_name { get; set; }
        public int element_code { get; set; }
        public int start_cost { get; set; }
        public int end_cost { get; set; }
        public int total_points { get; set; }
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
        public int bps { get; set; }
        public string influence { get; set; }
        public string creativity { get; set; }
        public string threat { get; set; }
        public string ict_index { get; set; }
        public int ea_index { get; set; }
        public int season { get; set; }
    }

    public class FixturesSummary
    {
        public int id { get; set; }
        public string kickoff_time_formatted { get; set; }
        public string event_name { get; set; }
        public string opponent_name { get; set; }
        public string opponent_short_name { get; set; }
        public bool is_home { get; set; }
        public int difficulty { get; set; }
        public int code { get; set; }
        public string kickoff_time { get; set; }
        public object team_h_score { get; set; }
        public object team_a_score { get; set; }
        public bool finished { get; set; }
        public int minutes { get; set; }
        public bool provisional_start_time { get; set; }
        public bool finished_provisional { get; set; }
        public int @event { get; set; }
        public int team_a { get; set; }
        public int team_h { get; set; }
    }

    public class Fixture
    {
        public int id { get; set; }
        public string kickoff_time_formatted { get; set; }
        public string event_name { get; set; }
        public string opponent_name { get; set; }
        public string opponent_short_name { get; set; }
        public bool is_home { get; set; }
        public int difficulty { get; set; }
        public int code { get; set; }
        public string kickoff_time { get; set; }
        public object team_h_score { get; set; }
        public object team_a_score { get; set; }
        public bool finished { get; set; }
        public int minutes { get; set; }
        public bool provisional_start_time { get; set; }
        public bool finished_provisional { get; set; }
        public int @event { get; set; }
        public int team_a { get; set; }
        public int team_h { get; set; }
    }

    public class FootballerHistory
    {
        public List<HistoryPast> history_past { get; set; }
        public List<FixturesSummary> fixtures_summary { get; set; }
        public List<object> explain { get; set; }
        public List<object> history_summary { get; set; }
        public List<Fixture> fixtures { get; set; }
        public List<object> history { get; set; }
    }

}
