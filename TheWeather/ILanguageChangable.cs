using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWeather
{
    /// <summary>
    /// Интерфейс изменения языка формы
    /// </summary>

    interface ILanguageChangable
    {
        void ChangeFormLanguage(Settings.Localizations newLocalization);
    }
}
