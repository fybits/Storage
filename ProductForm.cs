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
    public partial class ProductForm : Form {
        public ProductForm(Item item) {
            InitializeComponent();
            title.Text = item.title;
            description.Text = item.description;
            available.Text = "в наличии " + item.amount;
            if (item.amount == 0) {
                btnAddToCart.Enabled = false;
            }
            if (GlobalState.currentClient.privLevel != 0) {
                btnEdit.Hide();
            }
        }
    }
}
