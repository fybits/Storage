using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage {
    public partial class RegisterForm : Form {
        private LoginForm loginForm;

        public RegisterForm(LoginForm loginForm) {
            InitializeComponent();
            this.loginForm = loginForm;
        }
        
        private void btnRegister_Click(object sender, EventArgs e) {
            string login = tbLogin.Text;
            string password = tbPass.Text;
            string confirmation = tbPassConfirmation.Text;
            if (password == confirmation) {
                User user = User.Find(string.Format("username = '{0}'", login));
                if (user == null) {
                    SHA256 sha = SHA256.Create();
                    byte[] bytes = Encoding.ASCII.GetBytes(password);
                    string hash = Utils.ToHexString(sha.ComputeHash(bytes));
                    DataBase.Query(string.Format(
                        "INSERT INTO users (priv_level, username, phone_number, password)" +
                        "VALUES (1, '{0}', '{1}', '{2}');",
                        login,
                        mtbPhone.Text,
                        hash
                    ));
                    this.Hide();
                    loginForm.Show();
                }
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            loginForm.Show();
            this.Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e) {
            loginForm.Show();
        }
    }
}
