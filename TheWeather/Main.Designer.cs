namespace TheWeather
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.temp_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.humidity_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.pressure_label = new System.Windows.Forms.Label();
            this.cloudiness_label = new System.Windows.Forms.Label();
            this.wind_label = new System.Windows.Forms.Label();
            this.short_radioButton = new System.Windows.Forms.RadioButton();
            this.full_radioButton = new System.Windows.Forms.RadioButton();
            this.sunset_label = new System.Windows.Forms.Label();
            this.sunrise_label = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateNow_label = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.threedays_pictureBox = new System.Windows.Forms.PictureBox();
            this.minimize_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close_pictureBox = new System.Windows.Forms.PictureBox();
            this.settings_pictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.updateWeather_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wind_pictureBox = new System.Windows.Forms.PictureBox();
            this.icon_pictureBox = new System.Windows.Forms.PictureBox();
            this.icon6 = new System.Windows.Forms.PictureBox();
            this.icon5 = new System.Windows.Forms.PictureBox();
            this.icon4 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.time6_label = new System.Windows.Forms.Label();
            this.time5_label = new System.Windows.Forms.Label();
            this.time4_label = new System.Windows.Forms.Label();
            this.time1_label = new System.Windows.Forms.Label();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.time3_label = new System.Windows.Forms.Label();
            this.time2_label = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.temp4 = new System.Windows.Forms.Label();
            this.temp5 = new System.Windows.Forms.Label();
            this.temp6 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.temp3 = new System.Windows.Forms.Label();
            this.wind3 = new System.Windows.Forms.Label();
            this.wind2 = new System.Windows.Forms.Label();
            this.wind6 = new System.Windows.Forms.Label();
            this.wind5 = new System.Windows.Forms.Label();
            this.wind4 = new System.Windows.Forms.Label();
            this.wind1 = new System.Windows.Forms.Label();
            this.next18hours_panel = new System.Windows.Forms.Panel();
            this.wind_label_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threedays_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            this.next18hours_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // temp_label
            // 
            resources.ApplyResources(this.temp_label, "temp_label");
            this.temp_label.Name = "temp_label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Name = "label2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // city_label
            // 
            resources.ApplyResources(this.city_label, "city_label");
            this.city_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.city_label.Name = "city_label";
            this.city_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.city_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // humidity_label
            // 
            resources.ApplyResources(this.humidity_label, "humidity_label");
            this.humidity_label.Name = "humidity_label";
            // 
            // description_label
            // 
            resources.ApplyResources(this.description_label, "description_label");
            this.description_label.Name = "description_label";
            // 
            // pressure_label
            // 
            resources.ApplyResources(this.pressure_label, "pressure_label");
            this.pressure_label.Name = "pressure_label";
            // 
            // cloudiness_label
            // 
            resources.ApplyResources(this.cloudiness_label, "cloudiness_label");
            this.cloudiness_label.Name = "cloudiness_label";
            // 
            // wind_label
            // 
            resources.ApplyResources(this.wind_label, "wind_label");
            this.wind_label.Name = "wind_label";
            // 
            // short_radioButton
            // 
            resources.ApplyResources(this.short_radioButton, "short_radioButton");
            this.short_radioButton.Checked = true;
            this.short_radioButton.Name = "short_radioButton";
            this.short_radioButton.TabStop = true;
            this.short_radioButton.UseVisualStyleBackColor = true;
            this.short_radioButton.CheckedChanged += new System.EventHandler(this.short_radioButton_CheckedChanged);
            // 
            // full_radioButton
            // 
            resources.ApplyResources(this.full_radioButton, "full_radioButton");
            this.full_radioButton.Name = "full_radioButton";
            this.full_radioButton.UseVisualStyleBackColor = true;
            // 
            // sunset_label
            // 
            resources.ApplyResources(this.sunset_label, "sunset_label");
            this.sunset_label.Name = "sunset_label";
            // 
            // sunrise_label
            // 
            resources.ApplyResources(this.sunrise_label, "sunrise_label");
            this.sunrise_label.Name = "sunrise_label";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TheWeather.Properties.Resources.sunset;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TheWeather.Properties.Resources.humidity;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TheWeather.Properties.Resources.pressure;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TheWeather.Properties.Resources.sunrise;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TheWeather.Properties.Resources.clouds;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // dateNow_label
            // 
            resources.ApplyResources(this.dateNow_label, "dateNow_label");
            this.dateNow_label.Name = "dateNow_label";
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menu_panel.Controls.Add(this.threedays_pictureBox);
            this.menu_panel.Controls.Add(this.minimize_pictureBox);
            this.menu_panel.Controls.Add(this.label1);
            this.menu_panel.Controls.Add(this.close_pictureBox);
            this.menu_panel.Controls.Add(this.label2);
            this.menu_panel.Controls.Add(this.settings_pictureBox);
            this.menu_panel.Controls.Add(this.city_label);
            resources.ApplyResources(this.menu_panel, "menu_panel");
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.menu_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // threedays_pictureBox
            // 
            this.threedays_pictureBox.Image = global::TheWeather.Properties.Resources._3days;
            resources.ApplyResources(this.threedays_pictureBox, "threedays_pictureBox");
            this.threedays_pictureBox.Name = "threedays_pictureBox";
            this.threedays_pictureBox.TabStop = false;
            this.threedays_pictureBox.Click += new System.EventHandler(this.threedays_pictureBox_Click);
            // 
            // minimize_pictureBox
            // 
            this.minimize_pictureBox.Image = global::TheWeather.Properties.Resources.minimize;
            resources.ApplyResources(this.minimize_pictureBox, "minimize_pictureBox");
            this.minimize_pictureBox.Name = "minimize_pictureBox";
            this.minimize_pictureBox.TabStop = false;
            this.minimize_pictureBox.Click += new System.EventHandler(this.minimize_pictureBox_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // close_pictureBox
            // 
            this.close_pictureBox.Image = global::TheWeather.Properties.Resources.exit;
            resources.ApplyResources(this.close_pictureBox, "close_pictureBox");
            this.close_pictureBox.Name = "close_pictureBox";
            this.close_pictureBox.TabStop = false;
            this.close_pictureBox.Click += new System.EventHandler(this.close_pictureBox_Click);
            // 
            // settings_pictureBox
            // 
            this.settings_pictureBox.Image = global::TheWeather.Properties.Resources.settings;
            resources.ApplyResources(this.settings_pictureBox, "settings_pictureBox");
            this.settings_pictureBox.Name = "settings_pictureBox";
            this.settings_pictureBox.TabStop = false;
            this.settings_pictureBox.Click += new System.EventHandler(this.settings_pictureBox_Click);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // updateWeather_timer
            // 
            this.updateWeather_timer.Enabled = true;
            this.updateWeather_timer.Tick += new System.EventHandler(this.updateWeather_timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheWeather.Properties.Resources.wind;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheWeather.Properties.Resources.temp;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // wind_pictureBox
            // 
            resources.ApplyResources(this.wind_pictureBox, "wind_pictureBox");
            this.wind_pictureBox.Name = "wind_pictureBox";
            this.wind_pictureBox.TabStop = false;
            // 
            // icon_pictureBox
            // 
            resources.ApplyResources(this.icon_pictureBox, "icon_pictureBox");
            this.icon_pictureBox.Name = "icon_pictureBox";
            this.icon_pictureBox.TabStop = false;
            // 
            // icon6
            // 
            resources.ApplyResources(this.icon6, "icon6");
            this.icon6.Name = "icon6";
            this.icon6.TabStop = false;
            // 
            // icon5
            // 
            resources.ApplyResources(this.icon5, "icon5");
            this.icon5.Name = "icon5";
            this.icon5.TabStop = false;
            // 
            // icon4
            // 
            resources.ApplyResources(this.icon4, "icon4");
            this.icon4.Name = "icon4";
            this.icon4.TabStop = false;
            // 
            // icon1
            // 
            resources.ApplyResources(this.icon1, "icon1");
            this.icon1.Name = "icon1";
            this.icon1.TabStop = false;
            // 
            // time6_label
            // 
            resources.ApplyResources(this.time6_label, "time6_label");
            this.time6_label.ForeColor = System.Drawing.Color.Snow;
            this.time6_label.Name = "time6_label";
            // 
            // time5_label
            // 
            resources.ApplyResources(this.time5_label, "time5_label");
            this.time5_label.ForeColor = System.Drawing.Color.Snow;
            this.time5_label.Name = "time5_label";
            // 
            // time4_label
            // 
            resources.ApplyResources(this.time4_label, "time4_label");
            this.time4_label.ForeColor = System.Drawing.Color.Snow;
            this.time4_label.Name = "time4_label";
            // 
            // time1_label
            // 
            resources.ApplyResources(this.time1_label, "time1_label");
            this.time1_label.ForeColor = System.Drawing.Color.Snow;
            this.time1_label.Name = "time1_label";
            // 
            // icon3
            // 
            resources.ApplyResources(this.icon3, "icon3");
            this.icon3.Name = "icon3";
            this.icon3.TabStop = false;
            // 
            // icon2
            // 
            resources.ApplyResources(this.icon2, "icon2");
            this.icon2.Name = "icon2";
            this.icon2.TabStop = false;
            // 
            // time3_label
            // 
            resources.ApplyResources(this.time3_label, "time3_label");
            this.time3_label.ForeColor = System.Drawing.Color.Snow;
            this.time3_label.Name = "time3_label";
            // 
            // time2_label
            // 
            resources.ApplyResources(this.time2_label, "time2_label");
            this.time2_label.ForeColor = System.Drawing.Color.Snow;
            this.time2_label.Name = "time2_label";
            // 
            // temp1
            // 
            resources.ApplyResources(this.temp1, "temp1");
            this.temp1.ForeColor = System.Drawing.Color.Snow;
            this.temp1.Name = "temp1";
            // 
            // temp4
            // 
            resources.ApplyResources(this.temp4, "temp4");
            this.temp4.ForeColor = System.Drawing.Color.Snow;
            this.temp4.Name = "temp4";
            // 
            // temp5
            // 
            resources.ApplyResources(this.temp5, "temp5");
            this.temp5.ForeColor = System.Drawing.Color.Snow;
            this.temp5.Name = "temp5";
            // 
            // temp6
            // 
            resources.ApplyResources(this.temp6, "temp6");
            this.temp6.ForeColor = System.Drawing.Color.Snow;
            this.temp6.Name = "temp6";
            // 
            // temp2
            // 
            resources.ApplyResources(this.temp2, "temp2");
            this.temp2.ForeColor = System.Drawing.Color.Snow;
            this.temp2.Name = "temp2";
            // 
            // temp3
            // 
            resources.ApplyResources(this.temp3, "temp3");
            this.temp3.ForeColor = System.Drawing.Color.Snow;
            this.temp3.Name = "temp3";
            // 
            // wind3
            // 
            resources.ApplyResources(this.wind3, "wind3");
            this.wind3.ForeColor = System.Drawing.Color.Snow;
            this.wind3.Name = "wind3";
            // 
            // wind2
            // 
            resources.ApplyResources(this.wind2, "wind2");
            this.wind2.ForeColor = System.Drawing.Color.Snow;
            this.wind2.Name = "wind2";
            // 
            // wind6
            // 
            resources.ApplyResources(this.wind6, "wind6");
            this.wind6.ForeColor = System.Drawing.Color.Snow;
            this.wind6.Name = "wind6";
            // 
            // wind5
            // 
            resources.ApplyResources(this.wind5, "wind5");
            this.wind5.ForeColor = System.Drawing.Color.Snow;
            this.wind5.Name = "wind5";
            // 
            // wind4
            // 
            resources.ApplyResources(this.wind4, "wind4");
            this.wind4.ForeColor = System.Drawing.Color.Snow;
            this.wind4.Name = "wind4";
            // 
            // wind1
            // 
            resources.ApplyResources(this.wind1, "wind1");
            this.wind1.ForeColor = System.Drawing.Color.Snow;
            this.wind1.Name = "wind1";
            // 
            // next18hours_panel
            // 
            this.next18hours_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.next18hours_panel.Controls.Add(this.icon1);
            this.next18hours_panel.Controls.Add(this.wind3);
            this.next18hours_panel.Controls.Add(this.time1_label);
            this.next18hours_panel.Controls.Add(this.wind2);
            this.next18hours_panel.Controls.Add(this.time4_label);
            this.next18hours_panel.Controls.Add(this.wind6);
            this.next18hours_panel.Controls.Add(this.time5_label);
            this.next18hours_panel.Controls.Add(this.wind5);
            this.next18hours_panel.Controls.Add(this.time6_label);
            this.next18hours_panel.Controls.Add(this.wind4);
            this.next18hours_panel.Controls.Add(this.icon4);
            this.next18hours_panel.Controls.Add(this.wind1);
            this.next18hours_panel.Controls.Add(this.icon5);
            this.next18hours_panel.Controls.Add(this.wind_label_1);
            this.next18hours_panel.Controls.Add(this.icon6);
            this.next18hours_panel.Controls.Add(this.temp3);
            this.next18hours_panel.Controls.Add(this.time2_label);
            this.next18hours_panel.Controls.Add(this.temp2);
            this.next18hours_panel.Controls.Add(this.time3_label);
            this.next18hours_panel.Controls.Add(this.temp6);
            this.next18hours_panel.Controls.Add(this.icon2);
            this.next18hours_panel.Controls.Add(this.temp5);
            this.next18hours_panel.Controls.Add(this.icon3);
            this.next18hours_panel.Controls.Add(this.temp4);
            this.next18hours_panel.Controls.Add(this.temp1);
            resources.ApplyResources(this.next18hours_panel, "next18hours_panel");
            this.next18hours_panel.Name = "next18hours_panel";
            this.next18hours_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.next18hours_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // wind_label_1
            // 
            resources.ApplyResources(this.wind_label_1, "wind_label_1");
            this.wind_label_1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.wind_label_1.Name = "wind_label_1";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.sunset_label);
            this.Controls.Add(this.next18hours_panel);
            this.Controls.Add(this.sunrise_label);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dateNow_label);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pressure_label);
            this.Controls.Add(this.full_radioButton);
            this.Controls.Add(this.humidity_label);
            this.Controls.Add(this.short_radioButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cloudiness_label);
            this.Controls.Add(this.wind_pictureBox);
            this.Controls.Add(this.wind_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.icon_pictureBox);
            this.Controls.Add(this.temp_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threedays_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            this.next18hours_panel.ResumeLayout(false);
            this.next18hours_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label temp_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.PictureBox icon_pictureBox;
        private System.Windows.Forms.Label humidity_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label pressure_label;
        private System.Windows.Forms.Label cloudiness_label;
        private System.Windows.Forms.Label wind_label;
        private System.Windows.Forms.PictureBox wind_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton short_radioButton;
        private System.Windows.Forms.RadioButton full_radioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label sunset_label;
        private System.Windows.Forms.Label sunrise_label;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox settings_pictureBox;
        private System.Windows.Forms.PictureBox close_pictureBox;
        private System.Windows.Forms.Label dateNow_label;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minimize_pictureBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer updateWeather_timer;
        private System.Windows.Forms.PictureBox threedays_pictureBox;
        private System.Windows.Forms.PictureBox icon6;
        private System.Windows.Forms.PictureBox icon5;
        private System.Windows.Forms.PictureBox icon4;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.Label time6_label;
        private System.Windows.Forms.Label time5_label;
        private System.Windows.Forms.Label time4_label;
        private System.Windows.Forms.Label time1_label;
        private System.Windows.Forms.PictureBox icon3;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.Label time3_label;
        private System.Windows.Forms.Label time2_label;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label temp4;
        private System.Windows.Forms.Label temp5;
        private System.Windows.Forms.Label temp6;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Label temp3;
        private System.Windows.Forms.Label wind3;
        private System.Windows.Forms.Label wind2;
        private System.Windows.Forms.Label wind6;
        private System.Windows.Forms.Label wind5;
        private System.Windows.Forms.Label wind4;
        private System.Windows.Forms.Label wind1;
        private System.Windows.Forms.Panel next18hours_panel;
        private System.Windows.Forms.Label wind_label_1;
    }
}

