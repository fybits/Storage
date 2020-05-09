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
    public partial class ItemBox : Form {
        Item item;

        public ItemBox(Item item) {
            InitializeComponent();
            this.item = item;
            title.Text = item.title;
            description.Text = item.description;
            available.Text = "в наличии " + item.amount;
            pictureBox1.Image = Image.FromFile();
            if (item.amount == 0) {
                btnAddToCart.Enabled = false;
            }
        }

        private void lnkMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            GlobalState.instance.mainForm.ChangeMainContentForm(new ProductForm(item));
        }
    }
}
