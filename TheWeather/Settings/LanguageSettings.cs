using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TheWeather.Settings
{
    /// <summary>
    /// Класс настроек языка (CultureInfo)
    /// </summary>

    public class LanguageSettings
    {
        public Localizations CurrentLocalization;

        internal CultureInfo GetCulture()
        {
            return new CultureInfo(EnumDescriptionHelper.GetEnumDescription(CurrentLocalization));
        }

        internal void SetCulture(Localizations newLocalization)
        {
            CurrentLocalization = newLocalization;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(EnumDescriptionHelper.GetEnumDescription(CurrentLocalization));
        }
    }
}
