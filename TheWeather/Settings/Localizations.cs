using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWeather.Settings
{
    /// <summary>
    /// Языки в программе
    /// </summary>
    public enum Localizations
    {
        [Description("en-US")]
        English,
        [Description("ru-RU")]
        Russian
    }
}
