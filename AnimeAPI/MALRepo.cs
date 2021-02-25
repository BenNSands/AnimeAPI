using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeAPI.Models;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AnimeAPI
{
    public static class MALRepo //: IMALRepo
    {
        public static IEnumerable<Anime> GetAnime(string title)
        {
            //Parse string
            var parseTitle = title.Replace(" ", "%20");
            
            var key = System.IO.File.ReadAllText("apikey.txt");
            var client = new RestClient($"https://jikan1.p.rapidapi.com/search/anime?q={parseTitle}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("rapidapi-key", key);
            request.AddHeader("x-rapidapi-host", "jikan1.p.rapidapi.com");

            IRestResponse response = client.Execute(request);

            var obj = JObject.Parse(response.Content);

            var searchList = new List<Anime>();

            foreach (var anime in obj["results"])
            {
                var foundAnime = new Anime();
                foundAnime.Title = (string)anime["title"];
                foundAnime.MALID = (int)anime["mal_id"];
                foundAnime.ImgURL = (string)anime["image_url"];
                foundAnime.URL = (string)anime["url"];
                foundAnime.Score = (int)anime["score"];
                foundAnime.Rated = (string)anime["rated"];
                searchList.Add(foundAnime);
            }
            return searchList;
        }

    }
}
