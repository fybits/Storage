﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage {
    public partial class AddProductForm : Form {
        public AddProductForm() {
            InitializeComponent();
        }
        string imageName = "";

        private void btnSave_Click(object sender, EventArgs e) {
            Item newItem = new Item(tbTitle.Text, tbDescription.Text, imageName,(int)nudAmount.Value);
            newItem.Save();
            GlobalState.instance.mainForm.ChangeMainContentForm(new Catalog());
        }

        private void btnAddPhoto_Click(object sender, EventArgs e) {
            fileDialogImage.ShowDialog();
        }

        private void fileDialogImage_FileOk(object sender, CancelEventArgs e) {
            string baseImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "/Images/");
            if (!Directory.Exists(baseImagePath)) {
                Directory.CreateDirectory(baseImagePath);
            }
            imageName = Guid.NewGuid().ToString() + ".jpg";
            string newImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "/Images/" + imageName);
            File.Copy(fileDialogImage.FileName, newImagePath);
            pictureBox1.Image = Image.FromFile(newImagePath);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            GlobalState.instance.mainForm.ChangeMainContentForm(new Catalog());
        }
    }
}
