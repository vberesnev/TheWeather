using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;


namespace TheWeather.Settings
{
    public class Settings
    {
        /// <summary>
        /// Основной класс настроек программы, содержит настройки города, настройки отображения погоды, настройки программы 
        /// </summary>

        [JsonProperty("city")]
        public City City { get; set; }
        [JsonProperty("weather")]
        public Weather Weather { get; set; }
        [JsonProperty("general")]
        public General General { get; set; }

        public void SaveSettings()
        {
            File.WriteAllText(System.Environment.CurrentDirectory + @"\settings.json", JsonConvert.SerializeObject(this));
        }

        public bool  WinAutoStart()
        {
            if (SettingsHelper.IsAdministrator())
            {
                return AddToRegedit();
            }
            else
            {
                if (General.Language == "English")
                {
                    MessageBox.Show("For adding the programm to Windows autostart, you need start the programm with administrator mode", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Для добавления программы в автозагрузку, необходимо запустить её от имени администратора", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
        }

        private bool AddToRegedit()
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg1;
            RegistryKey reg2;
            reg1 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
            reg2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
            try
            {
                if (General.WinAutostart)
                {
                    reg1.SetValue("OpenWeather", ExePath);
                    reg1.SetValue("OpenWeather", ExePath);
                }

                else
                {
                    reg1.DeleteValue("OpenWeather");
                    reg2.DeleteValue("OpenWeather");
                }
                reg1.Close();
                reg2.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

       

    }
}
