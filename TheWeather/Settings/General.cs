using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TheWeather.Settings
{
    /// <summary>
    /// Класс основных настроек (времени обновления, записи ПО в автозагрузку, языка)
    /// </summary>

    public class General
    {
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }
        [JsonProperty("autostart")]
        public bool WinAutostart { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }

        
    }
}
