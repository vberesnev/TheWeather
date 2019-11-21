using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using TheWeather.Settings;
using System.Globalization;

namespace TheWeather
{
    public partial class SettingsForm : Form, ILanguageChangable
    {
        //Словари со временем обновления погоды для Eng и Ru
        Dictionary<string, int> updTimeEng = new Dictionary<string, int>();
        Dictionary<string, int> updTimeRu = new Dictionary<string, int>();

        private BindingSource bs = new BindingSource();

        GetWeatherDel getWeatherDeleg; //делегат для применения новых настроек на главной форме
        ChangeFormLanguageDel changeFormLangDeleg; //делегат для изменения языка главной формы
        ChangeUpdTimeDel changeUpdTimeDeleg; //делегат для изменения таймера обновления

        public SettingsForm(GetWeatherDel sender_I, ChangeFormLanguageDel sender_II, ChangeUpdTimeDel sender_III)
        {
            InitializeComponent();

            if (SettingsHelper.IsAdministrator())
            {
                autoStart_checkBox.Enabled = true;
            }

            Settings.Settings set = JsonConvert.DeserializeObject<Settings.Settings>(File.ReadAllText(System.Environment.CurrentDirectory + @"\settings.json"));

            if (set.General.Language == "English")
            {
                ChangeFormLanguage(Localizations.English);
                updTimeEng.Add("5m", 5);
                updTimeEng.Add("10m", 10);
                updTimeEng.Add("15m", 15);
                updTimeEng.Add("20m", 20);
                updTimeEng.Add("30m", 30);
                updTimeEng.Add("45m", 45);
                updTimeEng.Add("1h", 60);
                updTimeEng.Add("1h 30m", 90);
                updTimeEng.Add("2h", 120);
                updTimeEng.Add("3h", 180);
                weatherUpdTime_comboBox.DataSource = updTimeEng.Keys.ToList<string>();
            }
            else
            {
                ChangeFormLanguage(Localizations.Russian);
                updTimeRu.Add("5м", 5);
                updTimeRu.Add("10м", 10);
                updTimeRu.Add("15м", 15);
                updTimeRu.Add("20м", 20);
                updTimeRu.Add("30м", 30);
                updTimeRu.Add("45м", 45);
                updTimeRu.Add("1ч", 60);
                updTimeRu.Add("1ч 30м", 90);
                updTimeRu.Add("2ч", 120);
                updTimeRu.Add("3ч", 180);
                weatherUpdTime_comboBox.DataSource = updTimeRu.Keys.ToList<string>();
            }

            getWeatherDeleg = sender_I;
            changeFormLangDeleg = sender_II;
            changeUpdTimeDeleg = sender_III;

            SetToolTips(set); // устанавливаю описание для всех параметров

            FillCitiesTable(); //заполняю таблицу городов

            SetSettings(set); //устанавливаю все парметры приложения из settings.json

        }

        private void SetToolTips(Settings.Settings set)
        {
            ToolTip tool = new ToolTip();
            if (set.General.Language == "English")
            {
                tool.SetToolTip(this.label6, "Metric (°C, meter/sec)\r\nImperial (°F, miles/hour)");
                tool.SetToolTip(this.label7, "mmHg - millimeters of mercury\r\nhPa - hectopascal");
                tool.SetToolTip(this.question_label, "For adding the programm to Windows autostart,\r\nyou need start the programm with administrator mode");
            }
            else
            {
                tool.SetToolTip(this.label6, "Metric (°C, метр/сек)\r\nImperial (°F, миль/час)");
                tool.SetToolTip(this.label7, "mmHg - миллиметров ртутного столба\r\nhPa - гектопаскаль");
                tool.SetToolTip(this.question_label, "Для добавления программы в автозагрузку,\r\nнеобходимо запустить её от имени администратора");
            }
            
        }

        
        //return key of updTime dicteonary by value
        private string GetKeyWeatheUpd(int value, Dictionary<string, int> dictionary)
        {
            foreach (var dict in dictionary)
            {
                if (dict.Value.Equals(value))
                {
                    return dict.Key;
                }
            }
            return dictionary.Keys.ElementAt(1);
        }

        private void SetSettings(Settings.Settings set)
        {
            foreach (DataGridViewRow row in cities_dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == set.City.Id)
                {
                    cities_dataGridView.ClearSelection();
                    cities_dataGridView.Rows[row.Index].Selected = true;
                    cities_dataGridView.CurrentCell = cities_dataGridView.Rows[row.Index].Cells[1];
                    break;
                }
            }
            if (set.General.Language == "English")
            {
                weatherUpdTime_comboBox.Text = GetKeyWeatheUpd(set.General.UpdateTime, updTimeEng);
            }
            else
            {
                weatherUpdTime_comboBox.Text = GetKeyWeatheUpd(set.General.UpdateTime, updTimeRu);
            }
            dataFormat_comboBox.Text = set.Weather.Units;
            pressureValue_comboBox.Text = set.Weather.PressureValue;
            minMaxTemp_checkBox.Checked = set.Weather.MinMaxTemp;
            autoStart_checkBox.Checked = set.General.WinAutostart;
            for (int i = 0; i<language_listBox.Items.Count; i++)
            {
                if (language_listBox.Items[i].ToString() == set.General.Language)
                {
                    language_listBox.SelectedIndex = i;
                }
            }
        }

        private void FillCitiesTable()
        {
            Settings.City[] cities = JsonConvert.DeserializeObject<Settings.City[]>(File.ReadAllText(System.Environment.CurrentDirectory + @"\city\city.json"));

            for (int i = 0; i < cities.Length; i++)
            {
                bs.Add(cities[i]);
            }
            cities_dataGridView.AutoGenerateColumns = false;
            cities_dataGridView.DataSource = bs;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Id";
            column.Name = "Id";
            column.Visible = false;
            cities_dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "City";
            column.Width = 100;
            cities_dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Country";
            column.Width = 70;
            cities_dataGridView.Columns.Add(column);
        }

        private void select_textBox_TextChanged(object sender, EventArgs e)
        {
            string findStr = select_textBox.Text;
            if (findStr.Length > 0)
            {
                Settings.City[] cities = JsonConvert.DeserializeObject<Settings.City[]>(File.ReadAllText(System.Environment.CurrentDirectory + @"\city\city.json"));
                BindingList<Settings.City> citiesBL = new BindingList<Settings.City>();
                for (int i = 0; i < cities.Length; i++)
                {
                    citiesBL.Add(cities[i]);
                }

                BindingList<Settings.City> citiesFilterBL = new BindingList<Settings.City>(citiesBL.Where(p => p.Name.Contains(FirstUpper(findStr))).ToList());
                cities_dataGridView.DataSource = citiesFilterBL;
            }
            else
            {
                cities_dataGridView.DataSource = bs;
            }
        }

        //метод возвращает ту же строку, но с заглвной буквы (для поиска горродов)
        private string FirstUpper(string str)
        {
            str = str.Substring(0, 1).ToUpper() + str.Remove(0, 1);
            return str;
        }

        //переключение в меню settings
        private void settings_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HidePanel();
            switch (settings_listBox.SelectedIndex)
            {
                case 0:
                    general_panel.Visible = true;
                    break;
                case 1:
                    city_panel.Visible = true;
                    break;
                case 2:
                    language_panel.Visible = true;
                    break;
                case 3:
                    about_panel.Visible = true;
                    break;
            }
        }

        //скрыть все панели настроек
        private void HidePanel()
        {
            general_panel.Visible = false;
            city_panel.Visible = false;
            language_panel.Visible = false;
            about_panel.Visible = false;
        }

        //save all changes
        private void OK_button_Click(object sender, EventArgs e)
        {
            Settings.Settings set = new Settings.Settings();
            Settings.City city = new Settings.City();
            Settings.General general = new Settings.General();
            Settings.Weather weather = new Settings.Weather();

            //default city
            if (cities_dataGridView.SelectedRows.Count == 0)
            {
                city.Id = 524901;
                city.Name = "Moscow";
                city.Country = "RU";
            }
            else
            {
                city.Id = Convert.ToInt64(cities_dataGridView.SelectedRows[0].Cells["Id"].Value);
                city.Name = cities_dataGridView.SelectedRows[0].Cells["City"].Value.ToString();
                city.Country = cities_dataGridView.SelectedRows[0].Cells["Country"].Value.ToString();
            }
            weather.Units = dataFormat_comboBox.Text;
            weather.PressureValue = pressureValue_comboBox.Text;
            weather.MinMaxTemp = minMaxTemp_checkBox.Checked;

            general.Language = language_listBox.SelectedItem.ToString();
            general.WinAutostart = autoStart_checkBox.Checked;
            if (updTimeEng.Count > 0)
            {
                general.UpdateTime = updTimeEng[weatherUpdTime_comboBox.Text];
            }
            else
            {
                general.UpdateTime = updTimeRu[weatherUpdTime_comboBox.Text];
            }

            set.City = city;
            set.General = general;
            set.Weather = weather;

            if (autoStart_checkBox.Enabled)
            {
                set.WinAutoStart();
            }
            set.SaveSettings();

            changeUpdTimeDeleg(general.UpdateTime);
            getWeatherDeleg(set);

            if (general.Language == "English")
            {
                ChangeFormLanguage(Localizations.English);
                changeFormLangDeleg(Localizations.English);
            }
            else
            {
                ChangeFormLanguage(Localizations.Russian);
                changeFormLangDeleg(Localizations.Russian);
            }
            this.Close();
        }

        //при запуске в меню настроек выбираю первый пункт
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings_listBox.SelectedIndex = 0;
        }

        //кнопка Отмена
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangeFormLanguage(Localizations newLocalization)
        {
            LanguageSettings LS = new LanguageSettings();
            LS.SetCulture(newLocalization);
            var resources = new ComponentResourceManager(typeof(SettingsForm));

            CultureInfo newCultureInfo = new CultureInfo(EnumDescriptionHelper.GetEnumDescription(newLocalization));

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
            }

            resources.ApplyResources(this, "$this", newCultureInfo);
        }

        private void post_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:vberesnev.job@gmail.com");
        }
    }
}
