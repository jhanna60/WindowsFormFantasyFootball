namespace WindowsFormFantasyFootball.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;

    internal class FootballersRepository
    {
        public IEnumerable<Footballer> GetAll()
        {
            var webRequest = WebRequest.Create(@"http://fantasyoverlord.com/FPL/Data");

            var proxy = webRequest.Proxy;
            if (proxy != null)
            {
                var proxyUri = proxy.GetProxy(webRequest.RequestUri).ToString();
                webRequest.UseDefaultCredentials = true;
                webRequest.Proxy = new WebProxy(proxyUri, false);
                webRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
            }

            using (var response = webRequest.GetResponse())
            {
                var footballers = new List<Footballer>();
                var responseStream = response.GetResponseStream();
                var streamReader = new StreamReader(responseStream);
                Footballer.LoadFromCSV(streamReader, footballers);
                return footballers;
            }
        }
    }
}