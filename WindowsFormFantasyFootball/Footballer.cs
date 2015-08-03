namespace WindowsFormFantasyFootball
{
    using System.Collections.Generic;
    using System.IO;
    using System.Globalization;

    public class Footballer
    {
        public string FirstName { set; get; }
        public string Surname { set; get; }
        public string Position { set; get; }
        public string Team { set; get; }
        public int    Cost { set; get; }
        public int    PointsLstRnd { set; get; }
        public int    TotalPoints { set; get; }
        public decimal  AveragePoints { set; get; }
        public decimal  AvgPointsDollar { set; get; }
        public decimal  TotPointsDollar { set; get; }
        public int    WeekWeighting { set; get; }
        public int    TransfersOut { set; get; }
        public int    YellowCards { set; get; }
        public int    GoalsConceded { set; get; }
        public int    GoalsConcededPts { set; get; }
        public int    Saves { set; get; }
        public int    SavesPts { set; get; }
        public int    GoalsScored { set; get; }
        public int    GoalsScoredPts { set; get; }
        public float  ValueSeason { set; get; }
        public int    TransfersOutRnd { set; get; }
        public int    PriceRise { set; get; }
        public int    PriceFallRnd { set; get; }
        public int    LstSeasonPts { set; get; }
        public int    PriceFall { set; get; }
        public float  ValueForm { set; get; }
        public int    PenaltiesMissed { set; get; }
        public float  Form { set; get; }
        public int    Bonus { set; get; }
        public int    FanRating { set; get; }
        public int    CleanSheets { set; get; }
        public int    CleansheetsPts { set; get; }
        public int    Assists { set; get; }
        public float  SelectedByPcent { set; get; }
        public int    TransfersIn { set; get; }
        public int    OwnGoals { set; get; }
        public int    EAIndex { set; get; }
        public int    PenaltiesSaved { set; get; }
        public int    DreamTeamCount { set; get; }
        public int    MinutesPlayed { set; get; }
        public int    TransfersInRound { set; get; }
        public int    PriceRiseRound { set; get; }
        public int    RedCards { set; get; }
        public int    BPS { set; get; }
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
                data.Cost = int.Parse(values[4]);
                data.PointsLstRnd = int.Parse(values[5]);
                data.TotalPoints = int.Parse(values[6]);
                data.AveragePoints = decimal.Parse(values[7],NumberStyles.Any);
                data.AvgPointsDollar = (1000000 * decimal.Parse(values[8],NumberStyles.Any));
                data.TotPointsDollar = (1000000 * decimal.Parse(values[9],NumberStyles.Any));
                data.WeekWeighting = int.Parse(values[10]);
                data.TransfersOut = int.Parse(values[11]);
                data.YellowCards = int.Parse(values[12]);
                data.GoalsConceded = int.Parse(values[13]);
                data.GoalsConcededPts = int.Parse(values[14]);
                data.Saves = int.Parse(values[15]);
                data.SavesPts = int.Parse(values[16]);
                data.GoalsScored = int.Parse(values[17]);
                data.GoalsScoredPts = int.Parse(values[18]);
                data.ValueSeason = float.Parse(values[19]);
                data.TransfersOutRnd = int.Parse(values[20]);
                data.PriceRise = int.Parse(values[21]);
                data.PriceFallRnd = int.Parse(values[22]);
                data.LstSeasonPts = int.Parse(values[23]);
                data.PriceFall = int.Parse(values[24]);
                data.ValueForm = float.Parse(values[25]);
                data.PenaltiesMissed = int.Parse(values[26]);
                data.Form = float.Parse(values[27]);
                data.Bonus = int.Parse(values[28]);
                data.FanRating = int.Parse(values[29]);
                data.CleanSheets = int.Parse(values[30]);
                data.CleansheetsPts = int.Parse(values[31]);
                data.Assists = int.Parse(values[32]);
                data.SelectedByPcent = float.Parse(values[33]);
                data.TransfersIn = int.Parse(values[34]);
                data.OwnGoals = int.Parse(values[35]);
                data.EAIndex = int.Parse(values[36]);
                data.PenaltiesSaved = int.Parse(values[37]);
                data.DreamTeamCount = int.Parse(values[38]);
                data.MinutesPlayed = int.Parse(values[39]);
                data.TransfersInRound = int.Parse(values[40]);
                data.PriceRiseRound = int.Parse(values[41]);
                data.RedCards = int.Parse(values[42]);
                data.BPS = int.Parse(values[43]);
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