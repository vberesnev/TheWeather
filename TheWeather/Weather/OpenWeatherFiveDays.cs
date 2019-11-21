using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Weather
{
    public class OpenWeatherFiveDays
    {

        [JsonProperty("city")]
        public Settings.City City;
        [JsonProperty("coord")]
        public Coord Coord;
        [JsonProperty("country")]
        public string Country;
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public double Message { get; set; }
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        [JsonProperty("list")]
        public List[] List;
        
    }
}
