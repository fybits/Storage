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
    public partial class RegisterForm : Form {
        private LoginForm loginForm;

        public RegisterForm(LoginForm loginForm) {
            InitializeComponent();
            this.loginForm = loginForm;
        }
        
        private void btnRegister_Click(object sender, EventArgs e) {

        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            loginForm.Show();
            this.Close();
        }
    }
}
