using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace course_project
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            this.Load += RegistrationForm_Load;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = TbLogin.Text;
            string password = TbPassword.Text;
            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=userdata;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    int userCount = (int)command.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Welcome!");
                        // Clear the form fields
                        TbLogin.Text = "";
                        TbPassword.Text = "";
                        this.Hide();
                        Main form = new Main();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login or password.");
                    }
                }
            }
        }//Code for login button functionality
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }//Code for hashing password 


        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            TbPassword.PasswordChar = '•';
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration form = new Registration();
            form.Show();
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TbPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }//Hiding password

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
                lab_login.Text = "Login:";
                lab_password.Text = "Password:";
                lab_showpassword.Text = "Show password";
                btn_registration.Text = "Create an account";

                
                //list may be continued
            }
            else if (languageCode == "ru")
            {
                settingsToolStripMenuItem.Text = "Настройки";
                languageToolStripMenuItem.Text = "Язык";
                lab_login.Text = "Логин:";
                lab_password.Text = "Пароль:";
                lab_showpassword.Text = "Показать пароль";
                btn_registration.Text = "Создать аккаунт";
                //list may be continued
            }
        }//Dictionary for all words
    }
}