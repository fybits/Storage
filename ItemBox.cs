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
        public ItemBox(Item item) {
            InitializeComponent();
            title.Text = item.title;
            description.Text = item.description;
        }
    }
}
