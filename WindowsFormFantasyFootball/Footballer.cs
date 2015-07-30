namespace WindowsFormFantasyFootball
{
    using System.Collections.Generic;
    using System.IO;

    public class Footballer
    {
        public string FirstName { set; get; }
        public string Surname { set; get; }
        public string Position { set; get; }
        public string Team { set; get; }
        public string Cost { set; get; }
        public string PointsLstRnd { set; get; }
        public string TotalPoints { set; get; }
        public string AveragePoints { set; get; }
        public string AvgPointsDollar { set; get; }
        public string TotPointsDollar { set; get; }
        public string WeekWeighting { set; get; }
        public string TransfersOut { set; get; }
        public string YellowCards { set; get; }
        public string GoalsConceded { set; get; }
        public string GoalsConcededPts { set; get; }
        public string Saves { set; get; }
        public string SavesPts { set; get; }
        public string GoalsScored { set; get; }
        public string GoalsScoredPts { set; get; }
        public string ValueSeason { set; get; }
        public string TransfersOutRnd { set; get; }
        public string PriceRise { set; get; }
        public string PriceFallRnd { set; get; }
        public string LstSeasonPts { set; get; }
        public string PriceFall { set; get; }
        public string ValueForm { set; get; }
        public string PenaltiesMissed { set; get; }
        public string Form { set; get; }
        public string Bonus { set; get; }
        public string FanRating { set; get; }
        public string CleanSheets { set; get; }
        public string CleansheetsPts { set; get; }
        public int Assists { set; get; }
        public string SelectedByPcent { set; get; }
        public string TransfersIn { set; get; }
        public string OwnGoals { set; get; }
        public string EAIndex { set; get; }
        public string PenaltiesSaved { set; get; }
        public string DreamTeamCount { set; get; }
        public string MinutesPlayed { set; get; }
        public string TransfersInRound { set; get; }
        public string PriceRiseRound { set; get; }
        public string RedCards { set; get; }
        public string BPS { set; get; }
        public string NextFixture1 { set; get; }
        public string NextFixture2 { set; get; }
        public string NextFixture3 { set; get; }
        public string NextFixture4 { set; get; }
        public string NextFixture5 { set; get; }

        public static void LoadFromCSV(StreamReader reader, List<Footballer> listA)
        {
            //Cycle through my CSV file and load values into instances of Footballer Class
            // then save it in a List to be interrogated later

            // Read the header thenwe are ready for the actual data
            var line = reader.ReadLine();

            while (! reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line.Split(',');

                var data = new Footballer();

                data.FirstName = values[0];
                data.Surname = values[1];
                data.Position = values[2];
                data.Team = values[3];
                data.Cost = values[4];
                data.PointsLstRnd = values[5];
                data.TotalPoints = values[6];
                data.AveragePoints = values[7];
                data.AvgPointsDollar = values[8];
                data.TotPointsDollar = values[9];
                data.WeekWeighting = values[10];
                data.TransfersOut = values[11];
                data.YellowCards = values[12];
                data.GoalsConceded = values[13];
                data.GoalsConcededPts = values[14];
                data.Saves = values[15];
                data.SavesPts = values[16];
                data.GoalsScored = values[17];
                data.GoalsScoredPts = values[18];
                data.ValueSeason = values[19];
                data.TransfersOutRnd = values[20];
                data.PriceRise = values[21];
                data.PriceFallRnd = values[22];
                data.LstSeasonPts = values[23];
                data.PriceFall = values[24];
                data.ValueForm = values[25];
                data.PenaltiesMissed = values[26];
                data.Form = values[27];
                data.Bonus = values[28];
                data.FanRating = values[29];
                data.CleanSheets = values[30];
                data.CleansheetsPts = values[31];
                data.Assists = int.Parse(values[32]);
                data.SelectedByPcent = values[33];
                data.TransfersIn = values[34];
                data.OwnGoals = values[35];
                data.EAIndex = values[36];
                data.PenaltiesSaved = values[37];
                data.DreamTeamCount = values[38];
                data.MinutesPlayed = values[39];
                data.TransfersInRound = values[40];
                data.PriceRiseRound = values[41];
                data.RedCards = values[42];
                data.BPS = values[43];
                data.NextFixture1 = values[44];
                data.NextFixture2 = values[45];
                data.NextFixture3 = values[46];
                data.NextFixture4 = values[47];
                data.NextFixture5 = values[48];

                listA.Add(data);
            }
        }
    }
}