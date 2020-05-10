using System;
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
    public partial class EditProductForm : Form {

        private Item item;

        public EditProductForm(Item item) {
            InitializeComponent();
            this.item = item;
            tbTitle.Text = item.title;
            tbDescription.Text = item.description;
            nudAmount.Value = item.amount;
            if (!string.IsNullOrEmpty(item.image_name)) {
                pictureBox1.Image = Image.FromFile(Path.Combine(GlobalState.instance.imageDirectory, item.image_name));
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            item.title = tbTitle.Text;
            item.description = tbDescription.Text;
            item.amount = (int)nudAmount.Value;
            item.Update();
            GlobalState.instance.mainForm.ChangeMainContentForm(new Catalog());
        }

        private void btnAddPhoto_Click(object sender, EventArgs e) {
            fileDialogImage.ShowDialog();
        }

        private void fileDialogImage_FileOk(object sender, CancelEventArgs e) {
            if (!Directory.Exists(GlobalState.instance.imageDirectory)) {
                Directory.CreateDirectory(GlobalState.instance.imageDirectory);
            }
            item.image_name = Guid.NewGuid().ToString() + ".jpg";
            string newImagePath = Path.Combine(GlobalState.instance.imageDirectory, item.image_name);
            File.Copy(fileDialogImage.FileName, newImagePath);
            pictureBox1.Image = Image.FromFile(newImagePath);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            GlobalState.instance.mainForm.ChangeMainContentForm(new Catalog());
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DataBase.Query(string.Format("DELETE FROM items WHERE id = {0};", item.id));
            GlobalState.instance.mainForm.ChangeMainContentForm(new Catalog());
        }
    }
}
