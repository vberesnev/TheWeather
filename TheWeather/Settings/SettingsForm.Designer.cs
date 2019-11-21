namespace TheWeather
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.settings_listBox = new System.Windows.Forms.ListBox();
            this.city_panel = new System.Windows.Forms.Panel();
            this.cities_dataGridView = new System.Windows.Forms.DataGridView();
            this.select_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.general_panel = new System.Windows.Forms.Panel();
            this.question_label = new System.Windows.Forms.Label();
            this.autoStart_checkBox = new System.Windows.Forms.CheckBox();
            this.pressureValue_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataFormat_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minMaxTemp_checkBox = new System.Windows.Forms.CheckBox();
            this.weatherUpdTime_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.language_panel = new System.Windows.Forms.Panel();
            this.language_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.about_panel = new System.Windows.Forms.Panel();
            this.post_linkLabel = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.city_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cities_dataGridView)).BeginInit();
            this.general_panel.SuspendLayout();
            this.language_panel.SuspendLayout();
            this.about_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_listBox
            // 
            resources.ApplyResources(this.settings_listBox, "settings_listBox");
            this.settings_listBox.FormattingEnabled = true;
            this.settings_listBox.Items.AddRange(new object[] {
            resources.GetString("settings_listBox.Items"),
            resources.GetString("settings_listBox.Items1"),
            resources.GetString("settings_listBox.Items2"),
            resources.GetString("settings_listBox.Items3")});
            this.settings_listBox.Name = "settings_listBox";
            this.settings_listBox.SelectedIndexChanged += new System.EventHandler(this.settings_listBox_SelectedIndexChanged);
            // 
            // city_panel
            // 
            this.city_panel.Controls.Add(this.cities_dataGridView);
            this.city_panel.Controls.Add(this.select_textBox);
            this.city_panel.Controls.Add(this.label1);
            resources.ApplyResources(this.city_panel, "city_panel");
            this.city_panel.Name = "city_panel";
            // 
            // cities_dataGridView
            // 
            this.cities_dataGridView.AllowUserToAddRows = false;
            this.cities_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cities_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cities_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cities_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.cities_dataGridView, "cities_dataGridView");
            this.cities_dataGridView.MultiSelect = false;
            this.cities_dataGridView.Name = "cities_dataGridView";
            this.cities_dataGridView.ReadOnly = true;
            this.cities_dataGridView.RowHeadersVisible = false;
            this.cities_dataGridView.RowTemplate.Height = 18;
            this.cities_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // select_textBox
            // 
            resources.ApplyResources(this.select_textBox, "select_textBox");
            this.select_textBox.Name = "select_textBox";
            this.select_textBox.TextChanged += new System.EventHandler(this.select_textBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // OK_button
            // 
            resources.ApplyResources(this.OK_button, "OK_button");
            this.OK_button.Name = "OK_button";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // cancel_button
            // 
            resources.ApplyResources(this.cancel_button, "cancel_button");
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // general_panel
            // 
            this.general_panel.Controls.Add(this.question_label);
            this.general_panel.Controls.Add(this.autoStart_checkBox);
            this.general_panel.Controls.Add(this.pressureValue_comboBox);
            this.general_panel.Controls.Add(this.label7);
            this.general_panel.Controls.Add(this.dataFormat_comboBox);
            this.general_panel.Controls.Add(this.label6);
            this.general_panel.Controls.Add(this.label5);
            this.general_panel.Controls.Add(this.minMaxTemp_checkBox);
            this.general_panel.Controls.Add(this.weatherUpdTime_comboBox);
            this.general_panel.Controls.Add(this.label4);
            this.general_panel.Controls.Add(this.label2);
            resources.ApplyResources(this.general_panel, "general_panel");
            this.general_panel.Name = "general_panel";
            // 
            // question_label
            // 
            resources.ApplyResources(this.question_label, "question_label");
            this.question_label.Name = "question_label";
            // 
            // autoStart_checkBox
            // 
            resources.ApplyResources(this.autoStart_checkBox, "autoStart_checkBox");
            this.autoStart_checkBox.Name = "autoStart_checkBox";
            this.autoStart_checkBox.UseVisualStyleBackColor = true;
            // 
            // pressureValue_comboBox
            // 
            this.pressureValue_comboBox.FormattingEnabled = true;
            this.pressureValue_comboBox.Items.AddRange(new object[] {
            resources.GetString("pressureValue_comboBox.Items"),
            resources.GetString("pressureValue_comboBox.Items1")});
            resources.ApplyResources(this.pressureValue_comboBox, "pressureValue_comboBox");
            this.pressureValue_comboBox.Name = "pressureValue_comboBox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // dataFormat_comboBox
            // 
            this.dataFormat_comboBox.FormattingEnabled = true;
            this.dataFormat_comboBox.Items.AddRange(new object[] {
            resources.GetString("dataFormat_comboBox.Items"),
            resources.GetString("dataFormat_comboBox.Items1")});
            resources.ApplyResources(this.dataFormat_comboBox, "dataFormat_comboBox");
            this.dataFormat_comboBox.Name = "dataFormat_comboBox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // minMaxTemp_checkBox
            // 
            resources.ApplyResources(this.minMaxTemp_checkBox, "minMaxTemp_checkBox");
            this.minMaxTemp_checkBox.Name = "minMaxTemp_checkBox";
            this.minMaxTemp_checkBox.UseVisualStyleBackColor = true;
            // 
            // weatherUpdTime_comboBox
            // 
            this.weatherUpdTime_comboBox.FormattingEnabled = true;
            resources.ApplyResources(this.weatherUpdTime_comboBox, "weatherUpdTime_comboBox");
            this.weatherUpdTime_comboBox.Name = "weatherUpdTime_comboBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // language_panel
            // 
            this.language_panel.Controls.Add(this.language_listBox);
            this.language_panel.Controls.Add(this.label3);
            this.language_panel.Controls.Add(this.label11);
            resources.ApplyResources(this.language_panel, "language_panel");
            this.language_panel.Name = "language_panel";
            // 
            // language_listBox
            // 
            resources.ApplyResources(this.language_listBox, "language_listBox");
            this.language_listBox.FormattingEnabled = true;
            this.language_listBox.Items.AddRange(new object[] {
            resources.GetString("language_listBox.Items"),
            resources.GetString("language_listBox.Items1")});
            this.language_listBox.Name = "language_listBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // about_panel
            // 
            this.about_panel.Controls.Add(this.post_linkLabel);
            this.about_panel.Controls.Add(this.label13);
            this.about_panel.Controls.Add(this.label12);
            this.about_panel.Controls.Add(this.label10);
            this.about_panel.Controls.Add(this.label9);
            resources.ApplyResources(this.about_panel, "about_panel");
            this.about_panel.Name = "about_panel";
            // 
            // post_linkLabel
            // 
            resources.ApplyResources(this.post_linkLabel, "post_linkLabel");
            this.post_linkLabel.Name = "post_linkLabel";
            this.post_linkLabel.TabStop = true;
            this.post_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.post_linkLabel_LinkClicked);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.about_panel);
            this.Controls.Add(this.language_panel);
            this.Controls.Add(this.general_panel);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.city_panel);
            this.Controls.Add(this.settings_listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.city_panel.ResumeLayout(false);
            this.city_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cities_dataGridView)).EndInit();
            this.general_panel.ResumeLayout(false);
            this.general_panel.PerformLayout();
            this.language_panel.ResumeLayout(false);
            this.language_panel.PerformLayout();
            this.about_panel.ResumeLayout(false);
            this.about_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.ListBox settings_listBox;
        private System.Windows.Forms.Panel city_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox select_textBox;
        private System.Windows.Forms.Panel general_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox weatherUpdTime_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox autoStart_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox minMaxTemp_checkBox;
        private System.Windows.Forms.ComboBox dataFormat_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox pressureValue_comboBox;
        private System.Windows.Forms.DataGridView cities_dataGridView;
        private System.Windows.Forms.Panel language_panel;
        private System.Windows.Forms.ListBox language_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel about_panel;
        private System.Windows.Forms.LinkLabel post_linkLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label question_label;
    }
}