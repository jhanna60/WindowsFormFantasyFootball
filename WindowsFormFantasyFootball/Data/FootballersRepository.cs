namespace WindowsFormFantasyFootball.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Collections;

    internal class FootballersRepository
    {
        WebClient client = new WebClient();
        WebClient client1 = new WebClient();
        WebClient client2 = new WebClient();
        WebClient client3 = new WebClient();
        WebClient client4 = new WebClient();
        WebClient client5 = new WebClient();

        List<Footballer> footballers = new List<Footballer>();

        RootObject root = new RootObject();

        public IEnumerable<Footballer> GetAll()
        {

            var proxy = client.Proxy;
            client.UseDefaultCredentials = true;
            client.Proxy.Credentials = CredentialCache.DefaultCredentials;

            ServicePointManager.DefaultConnectionLimit = 300;


            // I need to cycle through the JSON files and serialise them into Footballer objects here so
            // we can return it back to the calling class

            // Added in some threading so we can help spread the load

            Debug.WriteLine("Starting JSON read : {0} ", DateTime.Now);

            string url = "https://fantasy.premierleague.com/drf/bootstrap-static";
            Stream stream = client.OpenRead(url);

            using (StreamReader reader = new StreamReader(stream))
            {
                root = (RootObject)JsonConvert.DeserializeObject(reader.ReadLine(), typeof(RootObject));

                //Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                //footballers.Add(data);

                //IList roots = (IList)root;

                //foreach (var g in roots)
                //{
                    foreach (var s in root.elements)
                    {
                    //var converted = (Footballer)root.elements);
                    footballers.Add(s);
                    }
                //}



                //Thread t = new Thread(() => ProcessURLs(1, 100));
                //t.Start();

                //Thread t1 = new Thread(() => ProcessURLs2(101, 200));
                //t1.Start();

                //Thread t2 = new Thread(() => ProcessURLs3(201, 300));
                //t2.Start();

                //Thread t3 = new Thread(() => ProcessURLs4(151, 200));
                //t3.Start();

                //Thread t4 = new Thread(() => ProcessURLs5(201, 250));
                //t4.Start();

                //ProcessURLs1(301, 450);




                Debug.WriteLine("Stopping JSON read : {0} ", DateTime.Now);

                return footballers;
            }
        }

        void ProcessURLs(int i1, int i2)
        {
            while (i1 <= i2)
            {
                string url = "http://fantasy.premierleague.com/web/api/elements/" + i1;
                Stream stream = client.OpenRead(url);

                using (StreamReader reader = new StreamReader(stream))
                {
                    Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                    footballers.Add(data);
                }

                i1 += 1;
            }

        }

        void ProcessURLs1(int i1, int i2)
        {
            while (i1 <= i2)
            {
                string url = "http://fantasy.premierleague.com/web/api/elements/" + i1;
                Stream stream = client1.OpenRead(url);

                using (StreamReader reader = new StreamReader(stream))
                {
                    Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                    footballers.Add(data);
                }

                i1 += 1;
            }

        }

        void ProcessURLs2(int i1, int i2)
        {
            while (i1 <= i2)
            {
                string url = "http://fantasy.premierleague.com/web/api/elements/" + i1;
                Stream stream = client2.OpenRead(url);

                using (StreamReader reader = new StreamReader(stream))
                {
                    Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                    footballers.Add(data);
                }

                i1 += 1;
            }

        }

        void ProcessURLs3(int i1, int i2)
        {
            while (i1 <= i2)
            {
                string url = "http://fantasy.premierleague.com/web/api/elements/" + i1;
                Stream stream = client3.OpenRead(url);

                using (StreamReader reader = new StreamReader(stream))
                {
                    Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                    footballers.Add(data);
                }

                i1 += 1;
            }
        }

        void ProcessURLs4(int i1, int i2)
        {
            while (i1 <= i2)
            {
                string url = "http://fantasy.premierleague.com/web/api/elements/" + i1;
                Stream stream = client4.OpenRead(url);

                using (StreamReader reader = new StreamReader(stream))
                {
                    Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                    footballers.Add(data);
                }

                i1 += 1;
            }
        }

        void ProcessURLs5(int i1, int i2)
        {
            while (i1 <= i2)
            {
                string url = "http://fantasy.premierleague.com/web/api/elements/" + i1;
                Stream stream = client5.OpenRead(url);

                using (StreamReader reader = new StreamReader(stream))
                {
                    Footballer data = JsonConvert.DeserializeObject<Footballer>(reader.ReadLine());

                    footballers.Add(data);
                }

                i1 += 1;
            }
        }

    }
}