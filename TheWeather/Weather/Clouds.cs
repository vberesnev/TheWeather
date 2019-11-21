using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Weather
{
    /// <summary>
    /// Класс облачности из OpenWeather API
    /// </summary>
    public class Clouds
    {
        [JsonProperty("all")]
        public double All { get; set; }
    }
}
