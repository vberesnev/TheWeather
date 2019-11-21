using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWeather.Settings;

namespace TheWeather
{
    public partial class FiveDayWeather : Form, ILanguageChangable
    {
        string temp = "";
        string wind = "";
        string pressure = "";

        public FiveDayWeather(Weather.OpenWeatherFiveDays OWFD, Settings.Settings set, string str, Point p)
        {
            InitializeComponent();
            this.Location = p;

            Settings.SettingsHelper.GetWeatherParams(set, ref temp, ref wind, ref pressure);

            wind_label_1.Text += " " + wind;
            wind_label_2.Text += " " + wind;
            wind_label_3.Text += " " + wind;

            int start = GetFirstTomorrow(OWFD);
            //date
            if (set.General.Language == "English")
            {
                this.Text = "Next 3 days weather";
                first_date_label.Text = String.Format("{0}, {1}", OWFD.List[start].Date.DayOfWeek.ToString().ToUpper(), OWFD.List[start].Date.ToString("d MMM yyyy", new CultureInfo("en-US")));
                second_date_label.Text = String.Format("{0}, {1}", OWFD.List[start + 8].Date.DayOfWeek.ToString().ToUpper(), OWFD.List[start + 8].Date.ToString("d MMM yyyy", new CultureInfo("en-US")));
                third_date_label.Text = String.Format("{0}, {1}", OWFD.List[start + 16].Date.DayOfWeek.ToString().ToUpper(), OWFD.List[start + 16].Date.ToString("d MMM yyyy", new CultureInfo("en-US")));
            }
            else
            {
                this.Text = "Погода на следующие 3 дня";
                first_date_label.Text = String.Format("{0}, {1}", OWFD.List[start].Date.ToString("dddd", new CultureInfo("ru-RU")).ToUpper(), OWFD.List[start].Date.ToString("d MMM yyyy", new CultureInfo("ru-RU")));
                second_date_label.Text = String.Format("{0}, {1}", OWFD.List[start+8].Date.ToString("dddd", new CultureInfo("ru-RU")).ToUpper(), OWFD.List[start+8].Date.ToString("d MMM yyyy", new CultureInfo("ru-RU")));
                third_date_label.Text = String.Format("{0}, {1}", OWFD.List[start+16].Date.ToString("dddd", new CultureInfo("ru-RU")).ToUpper(), OWFD.List[start+16].Date.ToString("d MMM yyyy", new CultureInfo("ru-RU")));
            }

            //icon
            first_icon_n.Image = OWFD.List[start].Weather[0].IconPath;
            first_icon_m.Image = OWFD.List[start + 2].Weather[0].IconPath;
            first_icon_a.Image = OWFD.List[start + 4].Weather[0].IconPath;
            first_icon_e.Image = OWFD.List[start + 6].Weather[0].IconPath;

            second_icon_n.Image = OWFD.List[start + 8].Weather[0].IconPath;
            second_icon_m.Image = OWFD.List[start + 10].Weather[0].IconPath;
            second_icon_a.Image = OWFD.List[start + 12].Weather[0].IconPath;
            second_icon_e.Image = OWFD.List[start + 14].Weather[0].IconPath;

            third_icon_n.Image = OWFD.List[start + 16].Weather[0].IconPath;
            third_icon_m.Image = OWFD.List[start + 18].Weather[0].IconPath;
            third_icon_a.Image = OWFD.List[start + 20].Weather[0].IconPath;
            third_icon_e.Image = OWFD.List[start + 22].Weather[0].IconPath;

            //temp
            first_temp_n.Text = Math.Round(OWFD.List[start].Main.Temp, 0) + temp;
            first_temp_m.Text = Math.Round(OWFD.List[start + 2].Main.Temp, 0) + temp;
            first_temp_a.Text = Math.Round(OWFD.List[start + 4].Main.Temp, 0) + temp;
            first_temp_e.Text = Math.Round(OWFD.List[start + 6].Main.Temp, 0) + temp;

            second_temp_n.Text = Math.Round(OWFD.List[start + 8].Main.Temp, 0) + temp;
            second_temp_m.Text = Math.Round(OWFD.List[start + 10].Main.Temp, 0) + temp;
            second_temp_a.Text = Math.Round(OWFD.List[start + 12].Main.Temp, 0) + temp;
            second_temp_e.Text = Math.Round(OWFD.List[start + 14].Main.Temp, 0) + temp;

            third_temp_n.Text = Math.Round(OWFD.List[start + 16].Main.Temp, 0) + temp;
            third_temp_m.Text = Math.Round(OWFD.List[start + 18].Main.Temp, 0) + temp;
            third_temp_a.Text = Math.Round(OWFD.List[start + 20].Main.Temp, 0) + temp;
            third_temp_e.Text = Math.Round(OWFD.List[start + 22].Main.Temp, 0) + temp;

            //wind
            first_wind_n.Text = Math.Round(OWFD.List[start].Wind.Speed, 0).ToString();
            first_wind_m.Text = Math.Round(OWFD.List[start + 2].Wind.Speed, 0).ToString();
            first_wind_a.Text = Math.Round(OWFD.List[start + 4].Wind.Speed, 0).ToString();
            first_wind_e.Text = Math.Round(OWFD.List[start + 6].Wind.Speed, 0).ToString();

            second_wind_n.Text = Math.Round(OWFD.List[start + 8].Wind.Speed, 0).ToString();
            second_wind_m.Text = Math.Round(OWFD.List[start + 10].Wind.Speed, 0).ToString();
            second_wind_a.Text = Math.Round(OWFD.List[start + 12].Wind.Speed, 0).ToString();
            second_wind_e.Text = Math.Round(OWFD.List[start + 14].Wind.Speed, 0).ToString();

            third_wind_n.Text = Math.Round(OWFD.List[start + 16].Wind.Speed, 0).ToString();
            third_wind_m.Text = Math.Round(OWFD.List[start + 18].Wind.Speed, 0).ToString();
            third_wind_a.Text = Math.Round(OWFD.List[start + 20].Wind.Speed, 0).ToString();
            third_wind_e.Text = Math.Round(OWFD.List[start + 22].Wind.Speed, 0).ToString();

            //humidity
            first_humidity_n.Text = OWFD.List[start].Main.Humidity.ToString();
            first_humidity_m.Text = OWFD.List[start + 2].Main.Humidity.ToString();
            first_humidity_a.Text = OWFD.List[start + 4].Main.Humidity.ToString();
            first_humidity_e.Text = OWFD.List[start + 6].Main.Humidity.ToString();

            second_humidity_n.Text = OWFD.List[start + 8].Main.Humidity.ToString();
            second_humidity_m.Text = OWFD.List[start + 10].Main.Humidity.ToString();
            second_humidity_a.Text = OWFD.List[start + 12].Main.Humidity.ToString();
            second_humidity_e.Text = OWFD.List[start + 14].Main.Humidity.ToString();

            third_humidity_n.Text = OWFD.List[start + 16].Main.Humidity.ToString();
            third_humidity_m.Text = OWFD.List[start + 18].Main.Humidity.ToString();
            third_humidity_a.Text = OWFD.List[start + 20].Main.Humidity.ToString();
            third_humidity_e.Text = OWFD.List[start + 22].Main.Humidity.ToString();

            //cloudeness
            first_cloudiness_n.Text = OWFD.List[start].Clouds.All.ToString();
            first_cloudiness_m.Text = OWFD.List[start + 2].Clouds.All.ToString();
            first_cloudiness_a.Text = OWFD.List[start + 4].Clouds.All.ToString();
            first_cloudiness_e.Text = OWFD.List[start + 6].Clouds.All.ToString();

            second_cloudiness_n.Text = OWFD.List[start + 8].Clouds.All.ToString();
            second_cloudiness_m.Text = OWFD.List[start + 10].Clouds.All.ToString();
            second_cloudiness_a.Text = OWFD.List[start + 12].Clouds.All.ToString();
            second_cloudiness_e.Text = OWFD.List[start + 14].Clouds.All.ToString();

            third_cloudiness_n.Text = OWFD.List[start + 16].Clouds.All.ToString();
            third_cloudiness_m.Text = OWFD.List[start + 18].Clouds.All.ToString();
            third_cloudiness_a.Text = OWFD.List[start + 20].Clouds.All.ToString();
            third_cloudiness_e.Text = OWFD.List[start + 22].Clouds.All.ToString();
        }

        public void ChangeFormLanguage(Localizations newLocalization)
        {
            LanguageSettings LS = new LanguageSettings();
            LS.SetCulture(newLocalization);
            var resources = new ComponentResourceManager(typeof(Main));

            CultureInfo newCultureInfo = new CultureInfo(EnumDescriptionHelper.GetEnumDescription(newLocalization));

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
            }

            resources.ApplyResources(this, "$this", newCultureInfo);
        }

        private void FiveDayWeather_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = this.Owner as Main;
            if (main != null)
            {
                main.Show();
            }
        }

        private int GetFirstTomorrow(Weather.OpenWeatherFiveDays OWFD)
        {
            string today = DateTime.Now.ToShortDateString();
            for (int i = 0; i < OWFD.List.Length; i++)
            {
                if (OWFD.List[i].Date.ToShortDateString() == DateTime.Now.AddDays(1).ToShortDateString()) return i;
            }
            return 0;
        }

    }
}
