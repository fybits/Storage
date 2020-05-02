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
    public partial class Catalog : Form {
        public Catalog() {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e) {
            List<Item> items = Item.FindAll("1 = 1");
            foreach (Item item in items) {
                ItemBox itemBox = new ItemBox(item);
                itemBox.TopLevel = false;
                itemsPanel.Controls.Add(itemBox);
                itemBox.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            itemsPanel.Controls.Clear();
            List<Item> items = Item.FindAll(string.Format("description ~* '{0}' or title ~* '{0}'", tbSearch.Text));
            foreach (Item item in items) {
                ItemBox itemBox = new ItemBox(item);
                itemBox.TopLevel = false;
                itemsPanel.Controls.Add(itemBox);
                itemBox.Show();
            }
        }
    }
}
