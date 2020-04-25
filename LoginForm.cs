using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            DataBase.
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            RegisterForm form = new RegisterForm(this);
            form.Show();
        }

        private void lnkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }
    }
}
