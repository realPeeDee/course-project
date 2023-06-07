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
using System.Net;
using System.Reflection.Emit;
using System.Data.SqlTypes;

namespace course_project
{
    public partial class Main : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }//loading main form
        public Main()
        {
            InitializeComponent();

        }
        string APIkey = "2285bf877406c43d60ce11885e3c4f5d"; //apikey which was given after registration on website
        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }//search button function

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIkey);
                var json = web.DownloadString(url);
                weatherinfo.root Info = JsonConvert.DeserializeObject<weatherinfo.root>(json);
                double temperatureKelvin = Info.main.temp; // temp holds the temperature in kelvin
                double temperatureCelsius = temperatureKelvin - 273.15; // convert temperature to celsius
                lab_temp.Text = temperatureCelsius.ToString("0.0°C");
                lab_conditions.Text = Info.weather[0].main;
                lab_details.Text = Info.weather[0].description;
                lab_sunset.Text = convertDateTime (Info.sys.sunset).ToString();
                lab_sunrise.Text = convertDateTime (Info.sys.sunrise).ToString();
                lab_windspeed.Text = Info.wind.speed.ToString("0.0m/s");
                lab_pressure.Text = Info.main.pressure.ToString("0hPa");

            }
        }//getting weather info from website openweathermap.com
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970,1,1,0,0,0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }//date and time converter



        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }//this application close button

        private void backgroundChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image|*.png;*.jpg;*.jpeg;*.gif;*.bmp|all files|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    Image backgroundImage = Image.FromFile(imagePath);
                    this.BackgroundImage = backgroundImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Change background button

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }//Change Language - eng

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ru");
        }//Change Language - rus
        private void ChangeLanguage(string languageCode)
        {
            if (languageCode == "en")
            {
                lab_temperature.Text = "Temperature:";
                lab_temp.Text = "N/A";
                lab_location.Text = "Location:";
                lab_conditions.Text = "Conditions:";
                lab_details.Text = "Details:";
                settingsToolStripMenuItem.Text = "Settings:";
                languageToolStripMenuItem.Text = "Language";
                timeToolStripMenuItem.Text = "Time format";
                backgroundChangeToolStripMenuItem.Text = "Change background";
                lab_sunrise.Text = "N/A";
                lab_sunset.Text = "N/A";
                lab_windspeed.Text = "N/A";
                lab_pressure.Text = "N/A";
                format24hStripMenuItem.Text = "24h";
                format12hStripMenuItem.Text = "12h";
                dateToolStripMenuItem.Text = "Date format";
                usdateToolStripMenuItem.Text = "YYYY-MM-DD";
                nrmldateToolStripMenuItem.Text = "DD-MM-YYYY";
                //list may be continued
            }
            else if (languageCode == "ru")
            {
                lab_temperature.Text = "Температура:";
                lab_temp.Text = "Н/О";
                lab_location.Text = "Локация:";
                lab_conditions.Text = "Обстоятельства:";
                lab_details.Text = "Детали:";
                settingsToolStripMenuItem.Text = "Настройки";
                languageToolStripMenuItem.Text = "Язык";
                timeToolStripMenuItem.Text = "Формат времени";
                backgroundChangeToolStripMenuItem.Text = "Изменить фон";
                lab_sunrise.Text = "Н/О";
                lab_sunset.Text = "Н/О";
                lab_windspeed.Text = "Н/О";
                lab_pressure.Text = "Н/О";
                format24hStripMenuItem.Text = "24 ч";
                format12hStripMenuItem.Text = "12 ч";
                dateToolStripMenuItem.Text = "Формат даты";
                usdateToolStripMenuItem.Text = "ГГГГ-ММ-ДД";
                nrmldateToolStripMenuItem.Text = "ДД-ММ-ГГГГ";
                //list may be continued
            }
        }//Dictionary for all words
        public enum TimeFormat
        {
            Format24Hour,
            Format12Hour
        }//time formats

        private void format24hStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTimeFormat(TimeFormat.Format24Hour);
        }//lines for setting 24h format time by click

        private void format12hToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetTimeFormat(TimeFormat.Format12Hour);
        }//lines for setting 12h format time by click
        private void SetTimeFormat(TimeFormat format)
        {
            if (format == TimeFormat.Format24Hour)
            {
                lab_time.Text = DateTime.Now.ToString("HH:mm");
            }
            else if (format == TimeFormat.Format12Hour)
            {
                lab_time.Text = DateTime.Now.ToString("h:mm tt"); //добавить вторую h при отсутсвии одной из цифр во время двухзначного часа
            }
        }//time format converter from 12 to 24...


        private void btn_clock_Click(object sender, EventArgs e)
        {
            lab_time.Text = DateTime.Now.ToString("HH:mm");
        }//pic button for curent time 

        private void btn_date_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            lab_date.Text = currentDate.ToString("dd.MM.yyyy");
        }// pic button for current date

        private void nrmldateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab_date.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }//change date to DD.MM.YYYY format

        private void usdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab_date.Text = DateTime.Now.ToString("yyyy.MM.dd");
        }//change date to YYYY.MM.DD format
        private void btn_newforecast_Click(object sender, EventArgs e)
        {
            Main newForecastForm = new Main();
            newForecastForm.Show(); 
        }//pic button for new forecast application

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }//Help button

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Account newForm = new Account();
            newForm.Show();
        }//Profile button

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Go back button
    }
}