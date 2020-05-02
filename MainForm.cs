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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            GlobalState.mainForm = this;
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            username.Text = GlobalState.currentClient.username + " " + GlobalState.currentClient.privLevel;
            Catalog catalog = new Catalog();
            catalog.Dock = DockStyle.Fill;
            catalog.TopLevel = false;
            mainContentPanel.Controls.Add(catalog);
            catalog.Show();
            if (GlobalState.currentClient.privLevel != 0) {
                btnAddProduct.Hide();
            }
        }

        public void ChangeMainContentForm(Form form) {
            mainContentPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            mainContentPanel.Controls.Add(form);
            form.Show();
        }

        private void btnCatalog_Click(object sender, EventArgs e) {
            ChangeMainContentForm(new Catalog());
        }

        private void btnAddProduct_Click(object sender, EventArgs e) {
            ChangeMainContentForm(new AddProductForm());
        }
    }
}
