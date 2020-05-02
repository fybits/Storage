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
    public partial class AddProductForm : Form {
        public AddProductForm() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Item newItem = new Item(tbTitle.Text, tbDescription.Text, (int)nudAmount.Value);
            newItem.Save();
            GlobalState.mainForm.ChangeMainContentForm(new Catalog());
        }
    }
}
