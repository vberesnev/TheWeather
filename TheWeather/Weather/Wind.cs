using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace TheWeather.Weather
{
    /// <summary>
    /// Класс ветра ищ OpenWeather API
    /// </summary>

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public Double DegInt { get; set; }

        public string DegStrEng
        {
            
            get
            {
                if      ((DegInt >= 338) || (DegInt < 23)) return "North";
                else if ((DegInt >= 23) && (DegInt < 67)) return "North-East";
                else if ((DegInt >= 67) && (DegInt < 113)) return "East";
                else if ((DegInt >= 113) && (DegInt < 157)) return "South-East";
                else if ((DegInt >= 157) && (DegInt < 203)) return "South";
                else if ((DegInt >= 203) && (DegInt < 247)) return "South-West";
                else if ((DegInt >= 247) && (DegInt < 293)) return "West";
                else if ((DegInt >= 293) && (DegInt < 338)) return "North-West";
                else return "Unknown";
            }
        }

        public string DegStrRu
        {

            get
            {
                if ((DegInt >= 338) || (DegInt < 23)) return "Северный";
                else if ((DegInt >= 23) && (DegInt < 67)) return "Северо-восточный";
                else if ((DegInt >= 67) && (DegInt < 113)) return "Восточный";
                else if ((DegInt >= 113) && (DegInt < 157)) return "Юго-восточный";
                else if ((DegInt >= 157) && (DegInt < 203)) return "Южный";
                else if ((DegInt >= 203) && (DegInt < 247)) return "Юго-западный";
                else if ((DegInt >= 247) && (DegInt < 293)) return "Западный";
                else if ((DegInt >= 293) && (DegInt < 338)) return "Северо-западный";
                else return "Неизвестно";
            }
        }

        public Image Img
        {
            get
            {
                string path = System.Environment.CurrentDirectory + @"\icons\wind\";
                if ((DegInt >= 338) || (DegInt < 23)) return Bitmap.FromFile(path + "w_n.png");
                else if ((DegInt >= 23) && (DegInt < 67)) return Bitmap.FromFile(path + "w_ne.png");
                else if ((DegInt >= 67) && (DegInt < 113)) return Bitmap.FromFile(path + "w_e.png");
                else if ((DegInt >= 113) && (DegInt < 157)) return Bitmap.FromFile(path + "w_se.png");
                else if ((DegInt >= 157) && (DegInt < 203)) return Bitmap.FromFile(path + "w_s.png");
                else if ((DegInt >= 203) && (DegInt < 247)) return Bitmap.FromFile(path + "w_sw.png");
                else if ((DegInt >= 247) && (DegInt < 293)) return Bitmap.FromFile(path + "w_w.png");
                else if ((DegInt >= 293) && (DegInt < 338)) return Bitmap.FromFile(path + "w_nw.png");
                else return Bitmap.FromFile(path + "w_quest.png");
            }

        }

    }
}
