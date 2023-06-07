using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Close button

        private void btn_nextpage_Click(object sender, EventArgs e)
        {
            this.Close();
            Help2 newForm = new Help2();
            newForm.Show();
        }//Next "Help" page

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
                lab_sunrise.Text = "N/A";
                lab_sunset.Text = "N/A";
                lab_windspeed.Text = "N/A";
                lab_pressure.Text = "N/A";
                lab_info.Text = "Information about application";
                lab_typelocation.Text = "Type here location";
                lab_presstogetinfo.Text = "Press to get information";
                lab_tempaccording.Text = "Temperature according to location";
                lab_condition.Text = "Conditions in specified location";
                lab_detail.Text = "Details in specified location";
                lab_timesunrise.Text = "The time of sunrise";
                lab_timesunset.Text = "The time of sunset";
                lab_wind.Text = "Windspeed";
                lab_press.Text = "Pressure";
                lab_closebutton.Text = "Button to close the window";
                lab_presstoclock.Text = "Press to display the current time";
                lab_presstodate.Text = "Press to display the current time";
                lab_anotherforecast.Text = "Press to get another forecast";


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
                lab_sunrise.Text = "Н/О";
                lab_sunset.Text = "Н/О";
                lab_windspeed.Text = "Н/О";
                lab_pressure.Text = "Н/О";
                lab_info.Text = "Информация про приложение";
                lab_typelocation.Text = "Введите здесь локацию";
                lab_presstogetinfo.Text = "Нажмите, чтобы получить информацию";
                lab_tempaccording.Text = "Температура на выбранной локации";
                lab_condition.Text = "Обстоятельства на выбранной локации";
                lab_detail.Text = "Детали на выбранной локации";
                lab_timesunrise.Text = "Во сколько рассвет";
                lab_timesunset.Text = "Во сколько закат";
                lab_wind.Text = "Скорость ветра";
                lab_press.Text = "Давление";
                lab_closebutton.Text = "Кнопка, чтобы закрыть окно";
                lab_presstoclock.Text = "Нажмите, чтобы отобразить текущее время";
                lab_presstodate.Text = "Нажмите, чтобы отобразить текущую дату";
                lab_anotherforecast.Text = "Нажмите, чтобы получить новый прогноз";
                //list may be continued
            }
        }//Dictionary for all words
    }
}
