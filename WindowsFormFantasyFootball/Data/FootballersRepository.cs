namespace WindowsFormFantasyFootball.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;

    internal class FootballersRepository
    {
        WebClient client = new WebClient();

        List<Footballer> footballers = new List<Footballer>();

        RootObject root = new RootObject();

        public IEnumerable<Footballer> GetAll(out List<Event> events)
        {
            var proxy = client.Proxy;
            client.UseDefaultCredentials = true;
            client.Proxy.Credentials = CredentialCache.DefaultCredentials;

            ServicePointManager.DefaultConnectionLimit = 300;

            // I need to Deserialise the JSON API object into RootObject, then I need to pick
            // out the Footballers and return them, also I can return the Events list

            Stream stream = client.OpenRead("https://fantasy.premierleague.com/drf/bootstrap-static");

            using (StreamReader reader = new StreamReader(stream))
            {
                root = (RootObject)JsonConvert.DeserializeObject(reader.ReadLine(), typeof(RootObject));

                foreach (var s in root.elements)
                {
                footballers.Add(s);
                }
                events = root.events;
                return footballers;
            }
        }
    }
}