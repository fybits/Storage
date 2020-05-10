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
    public partial class ProductForm : Form {
        Item item;

        public ProductForm(Item item) {
            InitializeComponent();
            this.item = item;
            title.Text = item.title;
            description.Text = item.description;
            available.Text = "в наличии " + item.amount;
            if (item.amount == 0 || GlobalState.instance.currentClient.privLevel == 2) {
                btnAddToCart.Enabled = false;
            }
            if (!string.IsNullOrEmpty(item.image_name)) {
                pictureBox1.Image = Image.FromFile(Path.Combine(GlobalState.instance.imageDirectory, item.image_name));
            }
            if (GlobalState.instance.currentClient.privLevel != 0) {
                btnEdit.Hide();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            GlobalState.instance.mainForm.ChangeMainContentForm(new EditProductForm(item));
        }
    }
}
