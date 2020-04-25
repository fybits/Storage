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
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string login = tbLogin.Text;
            string password = tbPass.Text;

            SHA256 sha = SHA256.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(password);
            string hash = Utils.ToHexString(sha.ComputeHash(bytes));

            User user = User.Find(string.Format("username = '{0}' AND password = '{1}'", login, hash));
            if (user == null) {
                
            } else {
                this.Hide();
                MainForm form = new MainForm();
                GlobalState.currentClient = user;
                form.Show();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            RegisterForm form = new RegisterForm(this);
            form.Show();
        }

        private void lnkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            MainForm form = new MainForm();
            User user = new User();
            user.username = "Гость";
            user.privLevel = 2;
            user.id = -1;
            GlobalState.currentClient = user;
            form.Show();
        }
    }
}
