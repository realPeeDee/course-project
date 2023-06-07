using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;

namespace course_project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.Load += RegistrationForm_Load;
        }
        private void btn_createaccount_Click(object sender, EventArgs e)
        {
            string email = TbEmail.Text;
            string username = TbLogin.Text;
            string password = TbPassword.Text;
            string confirmPassword = TbPassword1.Text;
            string nameSurname = TbNameSurname.Text;
            string phoneNumber = TbPhoneNumber.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (IsEmailExists(email))
            {
                MessageBox.Show("Email already registered.");
                return;
            }

            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already taken.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please choose another password.");
                return;
            }

            if (RegisterUser(email, username, password, nameSurname, phoneNumber))
            {
                MessageBox.Show("Welcome on board!");
                this.Hide();
                Authorization loginForm = new Authorization();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }//Account creating button

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            TbPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
            TbPassword1.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }//Hide password

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
        }//Function for password hashing

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            TbPassword.PasswordChar = '•';
            TbPassword1.PasswordChar = '•';
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }//Check email for right format

        private bool IsEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=userdata;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }//Check for repeated email

        private bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=userdata;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }//Check for repeated username

        private bool RegisterUser(string email, string username, string password, string nameSurname, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=REVISION-PC\SQLEXPRESS;Initial Catalog=userdata;Integrated Security=True;"))
            {
                connection.Open();

                string query = "INSERT INTO Users (Email, Login, Password, NameSurname, PhoneNumber) VALUES (@Email, @Username, @Password, @NameSurname, @PhoneNumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);

                    string hashedPassword = HashPassword(password);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    command.Parameters.AddWithValue("@NameSurname", nameSurname);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }//Add new data to database function

        private void btn_backtologin_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization form = new Authorization();
            form.Show();
        }//Go back to login button

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                lab_login.Text = "Login:";
                lab_password.Text = "Password:";
                lab_showpassword.Text = "Show password";
                lab_reppassword.Text = "Repeat password:";
                lab_namesurname.Text = "Name Surname:";
                lab_email.Text = "Email address:";
                lab_phone.Text = "Phone number:";
                //list may be continued
            }
            else if (languageCode == "ru")
            {
                settingsToolStripMenuItem.Text = "Настройки";
                languageToolStripMenuItem.Text = "Язык";
                lab_login.Text = "Логин:";
                lab_password.Text = "Пароль:";
                lab_showpassword.Text = "Показать пароль";
                lab_reppassword.Text = "Повторите пароль:";
                lab_namesurname.Text = "Имя фамилия:";
                lab_email.Text = "Электронная почта:";
                lab_phone.Text = "Номер телефона:";

                //list may be continued
            }
        }//Dictionary for all words
    }
}