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
    public partial class Help2 : Form
    {
        public Help2()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Close button

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
                settingsToolStripMenuItem.Text = "Settings:";
                languageToolStripMenuItem.Text = "Language";
                lab_chlang.Text = "Change current language";
                lab_chtime.Text = "Change time format";
                lab_chdate.Text = "Change date format";
                lab_custbackgr.Text = "Select custom background";
                lab_24h.Text = "Choose 24h format";
                lab_12h.Text = "Choose 12h format";
                lab_ddmmyyyy.Text = "day-month-year format";
                lab_yyyymmdd.Text = "year-month-day format";
                lab_eng.Text = "Choose English";
                lab_rus.Text = "Choose Russian";
                lab_anybackgr.Text = "Allows manual selection of any background from the computer";
                lab_info.Text = "Information about settings";
                lab_closebutton.Text = "Button to close the window";

                //list may be continued
            }
            else if (languageCode == "ru")
            {

                settingsToolStripMenuItem.Text = "Настройки";
                languageToolStripMenuItem.Text = "Язык";
                lab_chlang.Text = "Поменять текущий язык";
                lab_chtime.Text = "Поменять формат времени";
                lab_chdate.Text = "Поменять формат даты";
                lab_custbackgr.Text = "Выбрать собственный фон";
                lab_24h.Text = "Выбрать 24х часовой формат";
                lab_12h.Text = "Выбрать 12ти часовой формат";
                lab_ddmmyyyy.Text = "День-месяц-год";
                lab_yyyymmdd.Text = "Год-месяц-день";
                lab_eng.Text = "Выбрать анлгийский";
                lab_rus.Text = "Выбрать русский";
                lab_anybackgr.Text = "Позволяет выбрать любой фон  компьютера";
                lab_info.Text = "Информация про настройки";
                lab_closebutton.Text = "Кнопка, чтобы закрыть окно";
                //list may be continued
            }
        }//Dictionary for all words
    }
}
