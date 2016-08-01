namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Data;
    using System.Reflection;
    using System.Globalization;

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IEnumerable<Footballer> footballers = null;
            try
            {
                var repo = new FootballersRepository();
                footballers = repo.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error retrieving footballer details:{0}Message: {1}",
                    Environment.NewLine,
                    e.Message));
            }

            if (footballers != null)
            {
                var footballersDataTable = new FootballersDataSet().Footballers;

                foreach (var footballer in footballers)
                {
                    var row = footballersDataTable.NewFootballersRow();

                    row.FirstName = footballer.first_name;
                    row.Surname = footballer.second_name;
                    row.Position = ((Positions) footballer.element_type).ToString();
                    //footballer.element_type.ToString(); 
                    row.Team =  ((Teams) footballer.team).ToString();
                    row.Cost = footballer.now_cost;
                    row.PointsLstRnd = footballer.event_points;
                    row.TotalPoints = footballer.total_points;
                    row.AveragePoints = decimal.Parse(footballer.points_per_game, NumberStyles.Any);
                    //row.AvgPointsPound = footballer.AvgPointsDollar;
                    //row.TotPointsPound = footballer.TotPointsDollar;
                    //row.WeekWeighting = footballer.WeekWeighting;
                    row.TransfersOut = footballer.transfers_out;
                    row.YellowCards = footballer.yellow_cards;
                    row.GoalsConceded = footballer.goals_conceded;
                    //row.GoalsConcededPts = footballer.GoalsConcededPts;
                    row.Saves = footballer.saves;
                    //row.SavesPts = footballer.SavesPts;
                    row.GoalsScored = footballer.goals_scored;
                    //row.GoalsScoredPts = footballer.GoalsScoredPts;
                    row.ValueSeason = float.Parse(footballer.value_season);
                    row.TransfersOutRnd = footballer.transfers_out_event;
                    row.PriceRise = footballer.cost_change_start;
                    row.PriceFallRnd = footballer.cost_change_event_fall;
                    //row.LstSeasonPts = footballer.;
                    row.PriceFall = footballer.cost_change_start_fall;
                    row.ValueForm = float.Parse(footballer.value_form);
                    row.PenaltiesMissed = footballer.penalties_missed;
                    row.Form = float.Parse(footballer.form);
                    row.Bonus = footballer.bonus;
                    //row.FanRating = footballer.FanRating;
                    row.CleanSheets = footballer.clean_sheets;
                    //row.CleansheetsPts = footballer.CleansheetsPts;
                    row.Assists = footballer.assists;
                    row.SelectedByPcent = float.Parse(footballer.selected_by_percent);
                    row.TransfersIn = footballer.transfers_in;
                    row.OwnGoals = footballer.own_goals;
                    row.EAIndex = footballer.ea_index;
                    row.PenaltiesSaved = footballer.penalties_saved;
                    row.DreamTeamCount = footballer.dreamteam_count;
                    row.MinutesPlayed = footballer.minutes;
                    row.TransfersInRound = footballer.transfers_in_event;
                    row.PriceRiseRound = footballer.cost_change_event;
                    row.RedCards = footballer.red_cards;
                    row.BPS = footballer.bps;
                    row.News = footballer.news;
                    //row.NextFixture1 = footballer.current_fixture;
                    //row.NextFixture2 = footballer.next_fixture;
                    //row.NextFixture3 = footballer.NextFixture3;
                    //row.NextFixture4 = footballer.NextFixture4;
                    //row.NextFixture5 = footballer.NextFixture5;

                    footballersDataTable.AddFootballersRow(row);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(footballersDataTable));
            }
        }
    }

    //Helper methods
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        { 
            Type dgvType = dgv.GetType();  
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);  
            pi.SetValue(dgv, setting, null);  
        }  
    } 
}