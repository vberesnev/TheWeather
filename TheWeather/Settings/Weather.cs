using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Settings
{
    /// <summary>
    /// Класс настроек погоды (Используемые единицы измерения температуры, давления, показывать макс. и мин. температуру)
    /// </summary>
    public class Weather
    {
        [JsonProperty("units")]
        public string Units { get; set; }
        [JsonProperty("pressure_value")]
        public string PressureValue { get; set; }
        [JsonProperty("min_max_temp")]
        public bool MinMaxTemp { get; set; }
    }
}
