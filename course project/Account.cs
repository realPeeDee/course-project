using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace course_project
{
    public partial class Account : Form
    {
        private SqlConnection connection;
        public Account()
        {
            InitializeComponent();
        }
        private void AccountForm_Load(object sender, EventArgs e)
        {
            account_Load(sender, e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AccountForm_Load(this, EventArgs.Empty);
        }
        private void account_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=userdata;Integrated Security=True;");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT TOP 1 Login, NameSurname, Email, PhoneNumber FROM dbo.Users", connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                TbLogin.Text = reader["Login"].ToString();
                TbNameSurname.Text = reader["NameSurname"].ToString();
                TbEmail.Text = reader["Email"].ToString();
                TbPhone.Text = reader["PhoneNumber"].ToString();
            }
            reader.Close();
            connection.Close();
        }//Load currently entered account
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Button go back function

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
                lab_log.Text = "Your login:";
                lab_namsurnam.Text = "Your name and surname:";
                lab_mail.Text = "Your email:";
                lab_phone.Text = "Your phone number:";
                settingsToolStripMenuItem.Text = "Settings:";
                languageToolStripMenuItem.Text = "Language";
                //list may be continued
            }
            else if (languageCode == "ru")
            {
                lab_log.Text = "Ваш логин:";
                lab_namsurnam.Text = "Ваше имя и фамилия:";
                lab_mail.Text = "Ваша почта:";
                lab_phone.Text = "Ваш номер телефона:";
                settingsToolStripMenuItem.Text = "Настройки";
                languageToolStripMenuItem.Text = "Язык";
                //list may be continued
            }
        }//Dictionary for all words

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string newLogin = TbLogin.Text;
            string newNameSurname = TbNameSurname.Text;
            string newEmail = TbEmail.Text;
            string newPhone = TbPhone.Text;

            connection = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=userdata;Integrated Security=True;");
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE dbo.Users SET Login = @Login, NameSurname = @NameSurname, Email = @Email, PhoneNumber = @PhoneNumber", connection);
            command.Parameters.AddWithValue("@Login", newLogin);
            command.Parameters.AddWithValue("@NameSurname", newNameSurname);
            command.Parameters.AddWithValue("@Email", newEmail);
            command.Parameters.AddWithValue("@PhoneNumber", newPhone);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Data updated successfully!");
            account_Load(sender, e);
        }//Button edit function
    }
}
