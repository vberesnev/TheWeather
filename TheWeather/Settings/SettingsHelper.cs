using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace TheWeather.Settings
{
    static class SettingsHelper
    {
        public static void GetWeatherParams(Settings settings, ref string tempValue, ref string windValue, ref string pressureValue)
        {
            if (settings.General.Language == "English")
            {
                if (settings.Weather.Units == "Metric")
                {
                    tempValue = "°C";
                    windValue = "meter/sec";
                }
                else
                {
                    tempValue = "°F";
                    windValue = "miles/hour";
                }
                if (settings.Weather.PressureValue == "mmHg")
                {
                    pressureValue = "mmHg";
                }
                else
                {
                    pressureValue = "hPa";
                }
            }
            else
            {
                if (settings.Weather.Units == "Metric")
                {
                    tempValue = "°C";
                    windValue = "метр/сек";
                }
                else
                {
                    tempValue = "°F";
                    windValue = "миль/час";
                }
                if (settings.Weather.PressureValue == "mmHg")
                {
                    pressureValue = "мм рт.ст.";
                }
                else
                {
                    pressureValue = "гПа";
                }
            }
        }

        public static string GetLanguage(Settings settings)
        {
            if (settings.General.Language == "English")
            {
                return "en";
            }
            else
            {
                return "ru";
            }
        }

        //Is programm working with administrator mode
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            if (identity == null) return false;
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
