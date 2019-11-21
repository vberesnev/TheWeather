using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Weather
{
    /// <summary>
    /// Основной информационный погодный класс OpenWeather API
    /// </summary>

    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
        [JsonProperty("pressure")]
        public double Pressure_hPa { get; set; }

        public double Pressure
        {
            get
            {
                return Pressure_hPa / 1.33322;
            }
        }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
    }
}
