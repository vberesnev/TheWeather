using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Weather
{
    /// <summary>
    /// Главный класс из OpenWeather API, куда сыпятся все данные
    /// </summary>
    class OpenWeatherNow
    {
        public Coord Coord;
        public Weather[] Weather;
        [JsonProperty("base")]
        public string Base { get; set; }
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public double Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        [JsonProperty("dt")]
        public double Dt { get; set; }
        public Sys Sys { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
