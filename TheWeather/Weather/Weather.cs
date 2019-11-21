using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace TheWeather.Weather
{
    public class Weather
    {
        /// <summary>
        /// Класс описания погоды OpenWeather API.
        /// </summary>

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("main")]
        public string Main { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string IconImg { get; set; }

        public Image IconPath
        {
            get
            {
                return Bitmap.FromFile(System.Environment.CurrentDirectory + @"\icons\weather\" + IconImg +".png");
            }
        }
    }
}
