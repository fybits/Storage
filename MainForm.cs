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
            GlobalState.instance.mainForm = this;
            
        }

        private void MainForm_Load(object sender, EventArgs e) {
            username.Text = GlobalState.instance.currentClient.username + " " + GlobalState.instance.currentClient.privLevel;
            Catalog catalog = new Catalog();
            catalog.Dock = DockStyle.Fill;
            catalog.TopLevel = false;
            mainContentPanel.Controls.Add(catalog);
            catalog.Show();
            if (GlobalState.instance.currentClient.privLevel != 0) {
                btnAddProduct.Hide();
                btnUsers.Hide();
                btnExportImport.Hide();
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

        private void btnUsers_Click(object sender, EventArgs e) {
            ChangeMainContentForm(new UsersForm());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var result = MessageBox.Show("Вы уверены что хотите выйти из аккаунта?", "Выход из аккаунта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Application.Restart();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            var result = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void btnExportImport_Click(object sender, EventArgs e) {
            ChangeMainContentForm(new ExportImportForm());

        }
    }
}
