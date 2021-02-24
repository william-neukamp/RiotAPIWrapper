using System.Net.Http;
using System;
using RiotAPIWrapper.Enums;
using Newtonsoft.Json;
using RiotAPIWrapper.DTO;
using System.Collections.Generic;
using RiotAPIWrapper.Enums.Extensions;

namespace RiotAPIWrapper
{
    /// <summary>
    /// Base API requests and json functions
    /// </summary>
    public abstract class BaseAPI
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

        public BaseAPI()
        {
        }

        public string BuildURL(string url)
        {
            return null;
        }

        protected HttpResponseMessage GET(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(url);
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
            if (type == typeof(LeagueEntryDTO))
            {
                return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(content);
            }
            return null;
        }

    }

    /// <summary>
    /// Riot URI parser
    /// </summary>
    public  class RiotURI
    {
        public Region Region { get; set; }
        public Game Game { get; set; }
        public string Path { get; set; }
        private string Key { get; set; }
        private bool Param { get; set; }
        private string URL { get; set; }


        public RiotURI()
        {
            this.Param = false;
        }

        public RiotURI(Region region, Game game, string path, string apiKey)
        {
            this.Region = region;
            this.Game = game;
            this.Path = path;
            this.Key = apiKey;
            this.Param = false;
        }
        
        public RiotURI(Region region, Game game, string apiKey)
        {
            this.Region = region;
            this.Game = game;
            this.Key = apiKey;
            this.Param = false;
        }

        public void BuildUrl(Region region, Game game, string path, string key)
        {
            string baseUrl = "https://{region}.api.riotgames.com/{game}/{path}";
            baseUrl = baseUrl.Replace("{region}", region.Description());
            baseUrl = baseUrl.Replace("{game}", game.Description());
            baseUrl = baseUrl.Replace("{path}", path);
            this.Key = key;
            this.URL = baseUrl;
        }

        public void BuildUrl(string path)
        {
            BuildUrl(this.Region, this.Game, path, this.Key);
        }

        public void BuildUrl()
        {
            BuildUrl(this.Region, this.Game, this.Path, this.Key);
        }

        public void BuildUrl(Region region, Game game, string path, string key, string paramName, string paramValue)
        {
            BuildUrl(region, game, path, key);
            string baseUrl = this.URL + "?" + paramName + "=" + paramValue;
            this.Param = true;
            this.URL = baseUrl;
        }

        public void BuildUrl(string path, string paramName, string paramValue)
        {
            BuildUrl(this.Region, this.Game, path, this.Key, paramName, paramValue);
        }

        public void BuildUrl(string paramName, string paramValue)
        {
            BuildUrl(this.Region, this.Game, this.Path, this.Key, paramName, paramValue);
        }

        public string GetURL()
        {
            if (this.Param)
            {
                return this.URL + "&api_key=" + this.Key;
            }
            else
            {
                return this.URL + "?api_key=" + this.Key;
            }
        }
    }
}