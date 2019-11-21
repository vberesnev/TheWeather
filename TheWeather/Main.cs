using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using TheWeather.Settings;
using System.Globalization;

namespace TheWeather
{
    public delegate void GetWeatherDel(Settings.Settings set);
    public delegate void ChangeFormLanguageDel(Localizations newLocalization);
    public delegate void ChangeUpdTimeDel(int t);


    public partial class Main : Form, ILanguageChangable
    {
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


        //Координаты мышки для движения формы
        private int x = 0;
        private int y = 0;

        const string APPID = "284736d7aa6652238e2598fa8ce6dd15";

        public Main()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
            this.Resize += Main_Resize;
            Settings.Settings set = JsonConvert.DeserializeObject<Settings.Settings>(File.ReadAllText(System.Environment.CurrentDirectory + @"\settings.json"));
            ChengeUpdTime(set.General.UpdateTime); //обновляю время таймера обновления
            if (set.General.Language == "English")
            {
                ChangeFormLanguage(Localizations.English);
            }
            else
            {
                ChangeFormLanguage(Localizations.Russian);
            }
            GetWeatherNow(set);
            SetToolTips(set);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon1.Visible = false;           
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        public void ChengeUpdTime(int i)
        {
            updateWeather_timer.Interval = i * 60 * 1000;
        }

        private string FirstUpper(string str)
        {
            str = str.Substring(0, 1).ToUpper() + str.Remove(0, 1);
            return str;
        }

        

        private async void GetWeatherFiveDays(Settings.Settings set)
        {
            string req = String.Format("http://api.openweathermap.org/data/2.5/forecast?id={0}&lang={3}&units={1}&APPID={2}", set.City.Id, set.Weather.Units, APPID, Settings.SettingsHelper.GetLanguage(set));
            WebRequest request = WebRequest.Create(req);
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";
            WebResponse response = await request.GetResponseAsync();

            string answer = "";

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    answer = await sr.ReadToEndAsync();
                }
            }
            response.Close();

            Weather.OpenWeatherFiveDays OWFD = JsonConvert.DeserializeObject<Weather.OpenWeatherFiveDays>(answer);

            Point p = this.Location;
            FiveDayWeather FDW = new FiveDayWeather(OWFD, set, answer, p);
            FDW.Owner = this;          
            this.Hide();
            FDW.Show();

        }


        private async void GetWeatherNow(Settings.Settings set)
        {
            // WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=Syktyvkar&lang=en&units=metric&APPID=284736d7aa6652238e2598fa8ce6dd15");
            string req1 = String.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&lang={3}&units={1}&APPID={2}", set.City.Id, set.Weather.Units, APPID, Settings.SettingsHelper.GetLanguage(set));
            string req2 = String.Format("http://api.openweathermap.org/data/2.5/forecast?id={0}&lang={3}&units={1}&APPID={2}", set.City.Id, set.Weather.Units, APPID, Settings.SettingsHelper.GetLanguage(set));
            WebRequest request = WebRequest.Create(req1);
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            try
            {
                WebResponse response = await request.GetResponseAsync();

                string answer = "";

                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        answer = await sr.ReadToEndAsync();
                    }
                }
                response.Close();

                Weather.OpenWeatherNow OWN = JsonConvert.DeserializeObject<Weather.OpenWeatherNow>(answer);

                request = WebRequest.Create(req2);
                response = await request.GetResponseAsync();
                answer = "";
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        answer = await sr.ReadToEndAsync();
                    }
                }
                response.Close();
                Weather.OpenWeatherFiveDays OWFD = JsonConvert.DeserializeObject<Weather.OpenWeatherFiveDays>(answer);

                SetWeatherParams(OWN, OWFD, set);
            }
            catch
            {
                if (set.General.Language == "English")
                {
                    SetWeatherParams("Сonnection problemю. No data", set);
                }
                else
                {
                    SetWeatherParams("Проблемы с подключением. Нет данных", set);
                }
            }
            
          
        }

        private  void SetWeatherParams(string str,  Settings.Settings set)
        {
            city_label.Text = set.City.Name;
            description_label.Text = str;
            temp_label.Text = String.Empty;
            pressure_label.Text = String.Empty;

            wind_label.Text = String.Empty;
            dateNow_label.Text = String.Empty;
            humidity_label.Text = String.Empty;
            cloudiness_label.Text = String.Empty;
            sunrise_label.Text = String.Empty;
            sunset_label.Text = String.Empty;
          
        }

        private void SetWeatherParams(Weather.OpenWeatherNow OWN, Weather.OpenWeatherFiveDays OWFD, Settings.Settings set)
        {
            //OWN VALUES
            string tempValue = "";
            string windValue = "";
            string pressureValue = "";
            Settings.SettingsHelper.GetWeatherParams(set, ref tempValue, ref windValue, ref pressureValue);

            if (set.General.Language == "English")
            {
                if (set.Weather.MinMaxTemp)
                {
                    temp_label.Text = String.Format("{0}{3} (Min temp {1}{3}, Max temp {2}{3})", Math.Round(OWN.Main.Temp, 0), OWN.Main.TempMin, OWN.Main.TempMax, tempValue);
                }
                else
                {
                    temp_label.Text = String.Format("{0}{1}", Math.Round(OWN.Main.Temp, 0), tempValue);
                }

                wind_label.Text = String.Format("{0}, speed: {1} {2}", OWN.Wind.DegStrEng, OWN.Wind.Speed, windValue);
                wind_label_1.Text = "Wind speed, " + windValue;
                dateNow_label.Text = DateTime.Now.ToString("d MMM yyyy", new CultureInfo("en-US"));
            }
            else
            {
                if (set.Weather.MinMaxTemp)
                {
                    temp_label.Text = String.Format("{0}{3} (Мин. темп. {1}{3}, Макс. темп. {2}{3})", OWN.Main.Temp, OWN.Main.TempMin, OWN.Main.TempMax, tempValue);
                }
                else
                {
                    temp_label.Text = String.Format("{0}{1}", OWN.Main.Temp, tempValue);
                }
                wind_label.Text = String.Format("{0}, скорость: {1} {2}", OWN.Wind.DegStrRu, OWN.Wind.Speed, windValue);
                wind_label_1.Text = "Скорость ветра, " + windValue;
                dateNow_label.Text = DateTime.Now.ToString("D", new CultureInfo("ru-RU"));
            }

            city_label.Text = OWN.Name;
            humidity_label.Text = OWN.Main.Humidity.ToString() + "%";
            pressure_label.Text = String.Format("{0} {1}", Math.Round(OWN.Main.Pressure, 0), pressureValue);
            description_label.Text = FirstUpper(OWN.Weather[0].Description);
            icon_pictureBox.Image = OWN.Weather[0].IconPath;
            cloudiness_label.Text = OWN.Clouds.All + "%";
            wind_pictureBox.Image = OWN.Wind.Img;
            sunrise_label.Text = OWN.Sys.SunriseLocal.ToString("t");
            sunset_label.Text = OWN.Sys.SunsetLocal.ToString("t");

            //OWFD VALUES
            
            //time
            time1_label.Text = OWFD.List[1].Date.ToString("t");
            time2_label.Text = OWFD.List[2].Date.ToString("t");
            time3_label.Text = OWFD.List[3].Date.ToString("t");
            time4_label.Text = OWFD.List[4].Date.ToString("t");
            time5_label.Text = OWFD.List[5].Date.ToString("t");
            time6_label.Text = OWFD.List[6].Date.ToString("t");
            //icons
            icon1.Image = OWFD.List[1].Weather[0].IconPath;
            icon2.Image = OWFD.List[2].Weather[0].IconPath;
            icon3.Image = OWFD.List[3].Weather[0].IconPath;
            icon4.Image = OWFD.List[4].Weather[0].IconPath;
            icon5.Image = OWFD.List[5].Weather[0].IconPath;
            icon6.Image = OWFD.List[6].Weather[0].IconPath;
            //temp
            temp1.Text = Math.Round(OWFD.List[1].Main.Temp, 0) + tempValue;
            temp2.Text = Math.Round(OWFD.List[2].Main.Temp, 0) + tempValue;
            temp3.Text = Math.Round(OWFD.List[3].Main.Temp, 0) + tempValue;
            temp4.Text = Math.Round(OWFD.List[4].Main.Temp, 0) + tempValue;
            temp5.Text = Math.Round(OWFD.List[5].Main.Temp, 0) + tempValue;
            temp6.Text = Math.Round(OWFD.List[6].Main.Temp, 0) + tempValue;
            //wind
            wind1.Text = Math.Round(OWFD.List[1].Wind.Speed, 0).ToString();
            wind2.Text = Math.Round(OWFD.List[2].Wind.Speed, 0).ToString();
            wind3.Text = Math.Round(OWFD.List[3].Wind.Speed, 0).ToString();
            wind4.Text = Math.Round(OWFD.List[4].Wind.Speed, 0).ToString();
            wind5.Text = Math.Round(OWFD.List[5].Wind.Speed, 0).ToString();
            wind6.Text = Math.Round(OWFD.List[6].Wind.Speed, 0).ToString();
        }

        private void short_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (short_radioButton.Checked)
            {
                Height = 175;
            }
            else
            {
                Height = 375;
            }
        }

        private void close_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settings_pictureBox_Click(object sender, EventArgs e)
        {
            SettingsForm SF = new SettingsForm(new GetWeatherDel(GetWeatherNow), new ChangeFormLanguageDel(ChangeFormLanguage), new ChangeUpdTimeDel(ChengeUpdTime));
            SF.ShowDialog();
            Settings.Settings set = JsonConvert.DeserializeObject<Settings.Settings>(File.ReadAllText(System.Environment.CurrentDirectory + @"\settings.json"));
            short_radioButton.Checked = true;
            SetToolTips(set);
        }



        private void minimize_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



    #region ДВИЖЕНИЕ ФОРМЫ МЫШКОЙ
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        #endregion

        private void updateWeather_timer_Tick(object sender, EventArgs e)
        {
            Settings.Settings set = JsonConvert.DeserializeObject<Settings.Settings>(File.ReadAllText(System.Environment.CurrentDirectory + @"\settings.json"));
            GetWeatherNow(set);
        }

        private void threedays_pictureBox_Click(object sender, EventArgs e)
        {
            Settings.Settings set = JsonConvert.DeserializeObject<Settings.Settings>(File.ReadAllText(System.Environment.CurrentDirectory + @"\settings.json"));
            GetWeatherFiveDays(set);
        }

        private void SetToolTips(Settings.Settings set)
        {
            ToolTip tool = new ToolTip();
            if (set.General.Language == "English")
            {
                tool.SetToolTip(this.pictureBox1, "Temperature");
                tool.SetToolTip(this.pictureBox2, "Wind");
                tool.SetToolTip(this.pictureBox3, "Cloudiness");
                tool.SetToolTip(this.pictureBox4, "Humidity");
                tool.SetToolTip(this.pictureBox5, "Pressure");
                tool.SetToolTip(this.pictureBox6, "Sunrise");
                tool.SetToolTip(this.pictureBox7, "Sunset");
                tool.SetToolTip(this.city_label, "Your city");
            }
            else
            {
                tool.SetToolTip(this.pictureBox1, "Температура воздуха");
                tool.SetToolTip(this.pictureBox2, "Ветер");
                tool.SetToolTip(this.pictureBox3, "Облачность");
                tool.SetToolTip(this.pictureBox4, "Влажность");
                tool.SetToolTip(this.pictureBox5, "Давление");
                tool.SetToolTip(this.pictureBox6, "Восход");
                tool.SetToolTip(this.pictureBox7, "Закат");
                tool.SetToolTip(this.city_label, "Ваш город");
            }
        }

       
    }
}
