﻿using System;
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
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            label1.Text = GlobalState.currentClient.username + " " + GlobalState.currentClient.privLevel;
            Catalog catalog = new Catalog();
            catalog.Dock = DockStyle.Fill;
            catalog.TopLevel = false;
            mainContentPanel.Controls.Add(catalog);
            catalog.Show();
        }
    }
}
