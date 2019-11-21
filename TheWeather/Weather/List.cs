using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Weather
{
    public class List
    {
        [JsonProperty("dt")]
        public double DtUTC;
        [JsonProperty("main")]
        public Main Main;
        [JsonProperty("weather")]
        public Weather[] Weather;
        [JsonProperty("clouds")]
        public Clouds Clouds;
        [JsonProperty("wind")]
        public Wind Wind;
        [JsonProperty("dt_txt")]
        public string DtTXT;

        public DateTime Date
        {
            get { return Convert.ToDateTime(DtTXT); }
        }
 
    }
}
