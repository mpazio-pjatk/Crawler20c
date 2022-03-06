using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            if (args.Length < 1) throw new ArgumentNullException();
            var websiteUrl = args[0];

            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(websiteUrl);

            var content = await response.Content.ReadAsStringAsync();

            Regex regex = new Regex(@"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+");

            MatchCollection matchCollection = regex.Matches(content);

            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }


        }
    }
}
