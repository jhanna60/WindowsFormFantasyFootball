using System.Collections.Generic;
using WindowsFormFantasyFootball;

namespace WindowsFormFantasyFootball
{
    using System.Collections.Generic;
    using System.IO;
    using System.Globalization;
    using Newtonsoft.Json;

    public class Phase
    {
        public int id { get; set; }
        public string name { get; set; }
        public int start_event { get; set; }
        public int stop_event { get; set; }
    }

    public class Element : Footballer
    {
        //public int id { get; set; }
        //public string photo { get; set; }
        //public string web_name { get; set; }
        //public string status { get; set; }
        //public int code { get; set; }
        //public string first_name { get; set; }
        //public string second_name { get; set; }
        //public int? squad_number { get; set; }
        //public string news { get; set; }
        //public int now_cost { get; set; }
        //public object chance_of_playing_this_round { get; set; }
        //public int? chance_of_playing_next_round { get; set; }
        //public string value_form { get; set; }
        //public string value_season { get; set; }
        //public int cost_change_start { get; set; }
        //public int cost_change_event { get; set; }
        //public int cost_change_start_fall { get; set; }
        //public int cost_change_event_fall { get; set; }
        //public bool in_dreamteam { get; set; }
        //public int dreamteam_count { get; set; }
        //public string selected_by_percent { get; set; }
        //public string form { get; set; }
        //public int transfers_out { get; set; }
        //public int transfers_in { get; set; }
        //public int transfers_out_event { get; set; }
        //public int transfers_in_event { get; set; }
        //public int loans_in { get; set; }
        //public int loans_out { get; set; }
        //public int loaned_in { get; set; }
        //public int loaned_out { get; set; }
        //public int total_points { get; set; }
        //public int event_points { get; set; }
        //public string points_per_game { get; set; }
        //public object ep_this { get; set; }
        //public string ep_next { get; set; }
        //public bool special { get; set; }
        //public int minutes { get; set; }
        //public int goals_scored { get; set; }
        //public int assists { get; set; }
        //public int clean_sheets { get; set; }
        //public int goals_conceded { get; set; }
        //public int own_goals { get; set; }
        //public int penalties_saved { get; set; }
        //public int penalties_missed { get; set; }
        //public int yellow_cards { get; set; }
        //public int red_cards { get; set; }
        //public int saves { get; set; }
        //public int bonus { get; set; }
        //public int bps { get; set; }
        //public string influence { get; set; }
        //public string creativity { get; set; }
        //public string threat { get; set; }
        //public string ict_index { get; set; }
        //public int ea_index { get; set; }
        //public int element_type { get; set; }
        //public int team { get; set; }
    }

    public class Formations
    {
    public List<List<int>> invalidname { get; set; }
    public List<List<int>> invalidname2 { get; set; }
    public List<List<int>> invalidname3 { get; set; }
    public List<List<int>> invalidname4 { get; set; }
    public List<List<int>> invalidname5 { get; set; }
    public List<List<int>> invalidname6 { get; set; }
    public List<List<int>> invalidname7 { get; set; }
    public List<List<int>> invalidname8 { get; set; }
    public List<List<int>> invalidname9 { get; set; }
}

public class Game
{
    public int scoring_ea_index { get; set; }
    public string league_prefix_public { get; set; }
    public int league_size_h2h_max { get; set; }
    public int bps_tackles { get; set; }
    public string league_h2h_tiebreak { get; set; }
    public int scoring_long_play { get; set; }
    public int bps_recoveries_limit { get; set; }
    public string facebook_app_id { get; set; }
    public int bps_tackled { get; set; }
    public bool sys_vice_captain_enabled { get; set; }
    public int squad_squadplay { get; set; }
    public int bps_errors_leading_to_goal { get; set; }
    public int bps_yellow_cards { get; set; }
    public bool ui_el_hide_currency_qi { get; set; }
    public int scoring_bonus { get; set; }
    public int bps_fouls { get; set; }
    public int squad_squadsize { get; set; }
    public int transfers_cost { get; set; }
    public bool ui_selection_short_team_names { get; set; }
    public int scoring_short_play { get; set; }
    public double transfers_sell_on_fee { get; set; }
    public string transfers_type { get; set; }
    public int bps_long_play { get; set; }
    public int bps_long_play_limit { get; set; }
    public int scoring_assists { get; set; }
    public int bps_pass_percentage_80 { get; set; }
    public int bps_own_goals { get; set; }
    public int scoring_long_play_limit { get; set; }
    public int bps_pass_percentage_70 { get; set; }
    public bool ui_show_home_away { get; set; }
    public bool ui_el_hide_currency_sy { get; set; }
    public int fifa_league_id { get; set; }
    public int bps_assists { get; set; }
    public int league_size_classic_max { get; set; }
    public int bps_big_chances_created { get; set; }
    public int scoring_red_cards { get; set; }
    public int squad_team_limit { get; set; }
    public int league_points_h2h_draw { get; set; }
    public int transfers_limit { get; set; }
    public int scoring_penalties_saved { get; set; }
    public int scoring_yellow_cards { get; set; }
    public string game_timezone { get; set; }
    public string static_game_url { get; set; }
    public string currency_symbol { get; set; }
    public int bps_target_missed { get; set; }
    public int bps_dribbles { get; set; }
    public int perform_league_id { get; set; }
    public int bps_penalties_saved { get; set; }
    public string support_email_address { get; set; }
    public int bps_offside { get; set; }
    public int cup_start_event_id { get; set; }
    public bool sys_cdn_cache_enabled { get; set; }
    public int currency_multiplier { get; set; }
    public int bps_red_cards { get; set; }
    public int bps_winning_goals { get; set; }
    public int scoring_saves { get; set; }
    public int league_join_private_max { get; set; }
    public int league_join_public_max { get; set; }
    public Formations formations { get; set; }
    public int league_points_h2h_lose { get; set; }
    public int currency_decimal_places { get; set; }
    public int bps_errors_leading_to_goal_attempt { get; set; }
    public bool sys_use_event_live_api { get; set; }
    public int ui_selection_price_gap { get; set; }
    public int scoring_concede_limit { get; set; }
    public List<List<int>> default_formation { get; set; }
    public int ui_selection_player_limit { get; set; }
    public int bps_key_passes { get; set; }
    public int bps_attempted_passes_limit { get; set; }
    public int scoring_penalties_missed { get; set; }
    public string photo_base_url { get; set; }
    public int scoring_bps { get; set; }
    public int bps_penalties_missed { get; set; }
    public int bps_penalties_conceded { get; set; }
    public int scoring_own_goals { get; set; }
    public int squad_total_spend { get; set; }
    public int bps_clearances_blocks_interceptions { get; set; }
    public int bps_short_play { get; set; }
    public int ui_element_wrap { get; set; }
    public int bps_pass_percentage_90 { get; set; }
    public int bps_big_chances_missed { get; set; }
    public int league_max_ko_rounds_h2h { get; set; }
    public int bps_recoveries { get; set; }
    public int bps_open_play_crosses { get; set; }
    public int league_points_h2h_win { get; set; }
    public int bps_saves { get; set; }
    public int bps_cbi_limit { get; set; }
    public int scoring_saves_limit { get; set; }
}

public class __invalid_type__1
{
    public int scoring_clean_sheets { get; set; }
    public int squad_min_play { get; set; }
    public int bps_clean_sheets { get; set; }
    public int scoring_goals_conceded { get; set; }
    public int scoring_goals_scored { get; set; }
    public int squad_max_play { get; set; }
    public int bps_goals_scored { get; set; }
    public bool ui_shirt_specific { get; set; }
    public int squad_select { get; set; }
    public List<int> sub_positions_locked { get; set; }
}

public class __invalid_type__2
{
    public int scoring_clean_sheets { get; set; }
    public int squad_min_play { get; set; }
    public int scoring_goals_conceded { get; set; }
    public int scoring_goals_scored { get; set; }
    public int squad_max_play { get; set; }
    public int bps_goals_scored { get; set; }
    public int bps_clean_sheets { get; set; }
    public int squad_select { get; set; }
}

public class __invalid_type__3
{
    public int scoring_clean_sheets { get; set; }
    public int squad_min_play { get; set; }
    public int scoring_goals_conceded { get; set; }
    public int scoring_goals_scored { get; set; }
    public int squad_max_play { get; set; }
    public int bps_goals_scored { get; set; }
    public int bps_clean_sheets { get; set; }
    public int squad_select { get; set; }
}

public class __invalid_type__4
{
    public int scoring_clean_sheets { get; set; }
    public int squad_min_play { get; set; }
    public int scoring_goals_conceded { get; set; }
    public int scoring_goals_scored { get; set; }
    public int squad_max_play { get; set; }
    public int bps_goals_scored { get; set; }
    public int bps_clean_sheets { get; set; }
    public int squad_select { get; set; }
}

public class ElementType
{
    public __invalid_type__1 __invalid_name__1 { get; set; }
    public __invalid_type__2 __invalid_name__2 { get; set; }
    public __invalid_type__3 __invalid_name__3 { get; set; }
    public __invalid_type__4 __invalid_name__4 { get; set; }
}

public class GameSettings
{
    public Game game { get; set; }
    public ElementType element_type { get; set; }
}

public class NextEventFixture
{
    public bool is_home { get; set; }
    public int day { get; set; }
    public int event_day { get; set; }
    public int month { get; set; }
    public int id { get; set; }
    public int opponent { get; set; }
}

public class Team
{
    public int id { get; set; }
    public List<object> current_event_fixture { get; set; }
    public List<NextEventFixture> next_event_fixture { get; set; }
    public string name { get; set; }
    public int code { get; set; }
    public string short_name { get; set; }
    public bool unavailable { get; set; }
    public int strength { get; set; }
    public int position { get; set; }
    public int played { get; set; }
    public int win { get; set; }
    public int loss { get; set; }
    public int draw { get; set; }
    public int points { get; set; }
    public object form { get; set; }
    public string link_url { get; set; }
    public int strength_overall_home { get; set; }
    public int strength_overall_away { get; set; }
    public int strength_attack_home { get; set; }
    public int strength_attack_away { get; set; }
    public int strength_defence_home { get; set; }
    public int strength_defence_away { get; set; }
    public int team_division { get; set; }
}

public class ElementType2
{
    public int id { get; set; }
    public string singular_name { get; set; }
    public string singular_name_short { get; set; }
    public string plural_name { get; set; }
    public string plural_name_short { get; set; }
}

public class Event
{
    public int id { get; set; }
    public string name { get; set; }
    public string deadline_time { get; set; }
    public int average_entry_score { get; set; }
    public bool finished { get; set; }
    public bool data_checked { get; set; }
    public object highest_scoring_entry { get; set; }
    public int deadline_time_epoch { get; set; }
    public int deadline_time_game_offset { get; set; }
    public string deadline_time_formatted { get; set; }
    public object highest_score { get; set; }
}

public class RootObject
{
    public List<Phase> phases { get; set; }
    public List<Element> elements { get; set; }
    public GameSettings gamesettings { get; set; }
    public int totalplayers { get; set; }
    public List<Team> teams { get; set; }
    public List<ElementType2> element_types { get; set; }
    public List<Event> events { get; set; }
}

    public class Footballer
    {
        public int id { get; set; }
        public string photo { get; set; }
        public string web_name { get; set; }
        public string status { get; set; }
        public int code { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string squad_number { get; set; }
        public string news { get; set; }
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
        public int total_points { get; set; }
        public int event_points { get; set; }
        public string points_per_game { get; set; }
        public object ep_this { get; set; }
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
        public int bps { get; set; }
        public string influence { get; set; }
        public string creativity { get; set; }
        public string threat { get; set; }
        public string ict_index { get; set; }
        public int ea_index { get; set; }
        public int element_type { get; set; }
        public int team { get; set; }
    }
    //public class FixtureHistory
    //{
    //    public List<List<object>> all { get; set; }
    //    public List<List<object>> summary { get; set; }
    //}

    //public class Fixtures
    //{
    //    public List<List<string>> all { get; set; }
    //    public List<List<object>> summary { get; set; }
    //}

    //public class Footballer
    //{
    //    public int id { get; set; }
    //    public string photo { get; set; }
    //    public string web_name { get; set; }
    //    public List<List<object>> event_explain { get; set; }
    //    public FixtureHistory fixture_history { get; set; }
    //    public List<List<object>> season_history { get; set; }
    //    public Fixtures fixtures { get; set; }
    //    public int event_total { get; set; }
    //    public string type_name { get; set; }
    //    public string team_name { get; set; }
    //    public string selected_by { get; set; }
    //    public int total_points { get; set; }
    //    public string current_fixture { get; set; }
    //    public string next_fixture { get; set; }
    //    public int team_code { get; set; }
    //    public string news { get; set; }
    //    public int team_id { get; set; }
    //    public string status { get; set; }
    //    public int code { get; set; }
    //    public string first_name { get; set; }
    //    public string second_name { get; set; }
    //    public int now_cost { get; set; }
    //    public object chance_of_playing_this_round { get; set; }
    //    public object chance_of_playing_next_round { get; set; }
    //    public string value_form { get; set; }
    //    public string value_season { get; set; }
    //    public int cost_change_start { get; set; }
    //    public int cost_change_event { get; set; }
    //    public int cost_change_start_fall { get; set; }
    //    public int cost_change_event_fall { get; set; }
    //    public bool in_dreamteam { get; set; }
    //    public int dreamteam_count { get; set; }
    //    public string selected_by_percent { get; set; }
    //    public string form { get; set; }
    //    public int transfers_out { get; set; }
    //    public int transfers_in { get; set; }
    //    public int transfers_out_event { get; set; }
    //    public int transfers_in_event { get; set; }
    //    public int loans_in { get; set; }
    //    public int loans_out { get; set; }
    //    public int loaned_in { get; set; }
    //    public int loaned_out { get; set; }
    //    public int event_points { get; set; }
    //    public string points_per_game { get; set; }
    //    public string ep_this { get; set; }
    //    public string ep_next { get; set; }
    //    public bool special { get; set; }
    //    public int minutes { get; set; }
    //    public int goals_scored { get; set; }
    //    public int assists { get; set; }
    //    public int clean_sheets { get; set; }
    //    public int goals_conceded { get; set; }
    //    public int own_goals { get; set; }
    //    public int penalties_saved { get; set; }
    //    public int penalties_missed { get; set; }
    //    public int yellow_cards { get; set; }
    //    public int red_cards { get; set; }
    //    public int saves { get; set; }
    //    public int bonus { get; set; }
    //    public int ea_index { get; set; }
    //    public int bps { get; set; }
    //    public int element_type { get; set; }
    //    public int team { get; set; }
    //}


    //public class Footballer
    //{
    //    public string FirstName { set; get; }
    //    public string Surname { set; get; }
    //    public string Position { set; get; }
    //    public string Team { set; get; }
    //    public int    Cost { set; get; }
    //    public int    PointsLstRnd { set; get; }
    //    public int    TotalPoints { set; get; }
    //    public decimal  AveragePoints { set; get; }
    //    public decimal  AvgPointsDollar { set; get; }
    //    public decimal  TotPointsDollar { set; get; }
    //    public int    WeekWeighting { set; get; }
    //    public int    TransfersOut { set; get; }
    //    public int    YellowCards { set; get; }
    //    public int    GoalsConceded { set; get; }
    //    public int    GoalsConcededPts { set; get; }
    //    public int    Saves { set; get; }
    //    public int    SavesPts { set; get; }
    //    public int    GoalsScored { set; get; }
    //    public int    GoalsScoredPts { set; get; }
    //    public float  ValueSeason { set; get; }
    //    public int    TransfersOutRnd { set; get; }
    //    public int    PriceRise { set; get; }
    //    public int    PriceFallRnd { set; get; }
    //    public int    LstSeasonPts { set; get; }
    //    public int    PriceFall { set; get; }
    //    public float  ValueForm { set; get; }
    //    public int    PenaltiesMissed { set; get; }
    //    public float  Form { set; get; }
    //    public int    Bonus { set; get; }
    //    public int    FanRating { set; get; }
    //    public int    CleanSheets { set; get; }
    //    public int    CleansheetsPts { set; get; }
    //    public int    Assists { set; get; }
    //    public float  SelectedByPcent { set; get; }
    //    public int    TransfersIn { set; get; }
    //    public int    OwnGoals { set; get; }
    //    public int    EAIndex { set; get; }
    //    public int    PenaltiesSaved { set; get; }
    //    public int    DreamTeamCount { set; get; }
    //    public int    MinutesPlayed { set; get; }
    //    public int    TransfersInRound { set; get; }
    //    public int    PriceRiseRound { set; get; }
    //    public int    RedCards { set; get; }
    //    public int    BPS { set; get; }
    //    public string NextFixture1 { set; get; }
    //    public string NextFixture2 { set; get; }
    //    public string NextFixture3 { set; get; }
    //    public string NextFixture4 { set; get; }
    //    public string NextFixture5 { set; get; }

    //public static void LoadFromCSV(StreamReader reader, List<Footballer> listA)
    //{
    //    //Cycle through my CSV file and load values into instances of Footballer Class
    //    // then save it in a List to be interrogated later

    //    // Read the header then we are ready for the actual data
    //    var line = reader.ReadLine();

    //    while (! reader.EndOfStream)
    //    {
    //        line = reader.ReadLine();
    //        var values = line.Split(',');

    //        var data = new Footballer();

    //        data.FirstName = values[0];
    //        data.Surname = values[1];
    //        data.Position = values[2];
    //        data.Team = values[3];
    //        data.Cost = int.Parse(values[4]);
    //        data.PointsLstRnd = int.Parse(values[5]);
    //        data.TotalPoints = int.Parse(values[6]);
    //        data.AveragePoints = decimal.Parse(values[7],NumberStyles.Any);
    //        data.AvgPointsDollar = (1000000 * decimal.Parse(values[8],NumberStyles.Any));
    //        data.TotPointsDollar = (1000000 * decimal.Parse(values[9],NumberStyles.Any));
    //        data.WeekWeighting = int.Parse(values[10]);
    //        data.TransfersOut = int.Parse(values[11]);
    //        data.YellowCards = int.Parse(values[12]);
    //        data.GoalsConceded = int.Parse(values[13]);
    //        data.GoalsConcededPts = int.Parse(values[14]);
    //        data.Saves = int.Parse(values[15]);
    //        data.SavesPts = int.Parse(values[16]);
    //        data.GoalsScored = int.Parse(values[17]);
    //        data.GoalsScoredPts = int.Parse(values[18]);
    //        data.ValueSeason = float.Parse(values[19]);
    //        data.TransfersOutRnd = int.Parse(values[20]);
    //        data.PriceRise = int.Parse(values[21]);
    //        data.PriceFallRnd = int.Parse(values[22]);
    //        data.LstSeasonPts = int.Parse(values[23]);
    //        data.PriceFall = int.Parse(values[24]);
    //        data.ValueForm = float.Parse(values[25]);
    //        data.PenaltiesMissed = int.Parse(values[26]);
    //        data.Form = float.Parse(values[27]);
    //        data.Bonus = int.Parse(values[28]);
    //        data.FanRating = int.Parse(values[29]);
    //        data.CleanSheets = int.Parse(values[30]);
    //        data.CleansheetsPts = int.Parse(values[31]);
    //        data.Assists = int.Parse(values[32]);
    //        data.SelectedByPcent = float.Parse(values[33]);
    //        data.TransfersIn = int.Parse(values[34]);
    //        data.OwnGoals = int.Parse(values[35]);
    //        data.EAIndex = int.Parse(values[36]);
    //        data.PenaltiesSaved = int.Parse(values[37]);
    //        data.DreamTeamCount = int.Parse(values[38]);
    //        data.MinutesPlayed = int.Parse(values[39]);
    //        data.TransfersInRound = int.Parse(values[40]);
    //        data.PriceRiseRound = int.Parse(values[41]);
    //        data.RedCards = int.Parse(values[42]);
    //        data.BPS = int.Parse(values[43]);
    //        data.NextFixture1 = values[44];
    //        data.NextFixture2 = values[45];
    //        data.NextFixture3 = values[46];
    //        data.NextFixture4 = values[47];
    //        data.NextFixture5 = values[48];

    //        listA.Add(data);
    //    }
    //}
    //}
}