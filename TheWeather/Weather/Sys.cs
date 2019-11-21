using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TheWeather.Weather
{
    /// <summary>
    /// Системный класс погоды OpenWeather API
    /// </summary>
    class Sys
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("message")]
        public double Message { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("sunrise")]
        public long SunriseUTC { get; set; }
        [JsonProperty("sunset")]
        public long SunsetUTC { get; set; }

        public DateTime SunriseLocal
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(SunriseUTC);
            }
        }

        public DateTime SunsetLocal
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(SunsetUTC);
            }
        }

    }
}
