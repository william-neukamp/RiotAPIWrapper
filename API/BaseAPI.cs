using System.Net.Http;
using System;
using RiotAPIWrapper.Enums;
using Newtonsoft.Json;
using RiotAPIWrapper.API;

namespace RiotAPIWrapper
{
    /// <summary>
    /// Base API requests and json functions
    /// </summary>
    public class BaseAPI
    {
        protected string Key { get; set; }
        protected Region Region { get; set; }
        protected Game Game { get; set; }

        public BaseAPI(string key, Region region, Game game)
        {
            this.Key = key;
            this.Region = region;
            this.Game = game;
        }

        protected string GetURI(string path)
        {
            string region = Enum.GetName(typeof(Region), this.Region).ToLower();
            string game = Enum.GetName(typeof(Game), this.Game).ToLower();

            return "https://" + region + ".api.riotgames.com/" + game + "/" + path + "?api_key=" + this.Key;
        }

        protected HttpResponseMessage GET(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(GetURI(url));
                result.Wait();

                return result.Result;              
            }
        }

        protected Object JsonDeserialize(HttpResponseMessage response, Type type)
        {
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            string content = response.Content.ReadAsStringAsync().Result;

            if (type == typeof(SummonerDTO))
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            return null;
        }

    }
}
