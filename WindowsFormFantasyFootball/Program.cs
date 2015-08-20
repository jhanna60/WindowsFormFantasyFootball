namespace WindowsFormFantasyFootball
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Data;

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

                    row.FirstName = footballer.FirstName;
                    row.Surname = footballer.Surname;
                    row.Position = footballer.Position;
                    row.Team = footballer.Team;
                    row.Cost = footballer.Cost;
                    row.PointsLstRnd = footballer.PointsLstRnd;
                    row.TotalPoints = footballer.TotalPoints;
                    row.AveragePoints = footballer.AveragePoints;
                    row.AvgPointsPound = footballer.AvgPointsDollar;
                    row.TotPointsPound = footballer.TotPointsDollar;
                    //row.WeekWeighting = footballer.WeekWeighting;
                    row.TransfersOut = footballer.TransfersOut;
                    row.YellowCards = footballer.YellowCards;
                    row.GoalsConceded = footballer.GoalsConceded;
                    //row.GoalsConcededPts = footballer.GoalsConcededPts;
                    row.Saves = footballer.Saves;
                    //row.SavesPts = footballer.SavesPts;
                    row.GoalsScored = footballer.GoalsScored;
                    //row.GoalsScoredPts = footballer.GoalsScoredPts;
                    row.ValueSeason = footballer.ValueSeason;
                    row.TransfersOutRnd = footballer.TransfersOutRnd;
                    row.PriceRise = footballer.PriceRise;
                    row.PriceFallRnd = footballer.PriceFallRnd;
                    row.LstSeasonPts = footballer.LstSeasonPts;
                    row.PriceFall = footballer.PriceFall;
                    row.ValueForm = footballer.ValueForm;
                    row.PenaltiesMissed = footballer.PenaltiesMissed;
                    row.Form = footballer.Form;
                    row.Bonus = footballer.Bonus;
                    //row.FanRating = footballer.FanRating;
                    row.CleanSheets = footballer.CleanSheets;
                    //row.CleansheetsPts = footballer.CleansheetsPts;
                    row.Assists = footballer.Assists;
                    row.SelectedByPcent = footballer.SelectedByPcent;
                    row.TransfersIn = footballer.TransfersIn;
                    row.OwnGoals = footballer.OwnGoals;
                    row.EAIndex = footballer.EAIndex;
                    row.PenaltiesSaved = footballer.PenaltiesSaved;
                    row.DreamTeamCount = footballer.DreamTeamCount;
                    row.MinutesPlayed = footballer.MinutesPlayed;
                    row.TransfersInRound = footballer.TransfersInRound;
                    row.PriceRiseRound = footballer.PriceRiseRound;
                    row.RedCards = footballer.RedCards;
                    row.BPS = footballer.BPS;
                    row.NextFixture1 = footballer.NextFixture1;
                    row.NextFixture2 = footballer.NextFixture2;
                    row.NextFixture3 = footballer.NextFixture3;
                    row.NextFixture4 = footballer.NextFixture4;
                    row.NextFixture5 = footballer.NextFixture5;

                    footballersDataTable.AddFootballersRow(row);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(footballersDataTable));
            }
        }
    }
}