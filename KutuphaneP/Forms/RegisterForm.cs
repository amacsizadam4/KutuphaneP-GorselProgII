using LibraryManagementSystem.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneP.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void txtUsename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Username", username);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (exists > 0)
                {
                    MessageBox.Show("Kullanıcı adı zaten mevcut.");
                    return;
                }

                string insertQuery = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@PasswordHash", password); // no hash yet

                int result = insertCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı kayıt edilemedi.");
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
