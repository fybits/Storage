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
    public partial class ExportImportForm : Form {
        public ExportImportForm() {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            pbStatus.Maximum = File.ReadLines(openFileDialog1.FileName).Count();
            pbStatus.Value = 0;
            DataBase.Query("DROP TABLE items;");
            DataBase.Migrate();
            foreach (string line in File.ReadLines(openFileDialog1.FileName)) {
                CSVTokenizer t = new CSVTokenizer(line);
                Item item = new Item(
                    int.Parse(t.NextToken()),
                    t.NextToken(),
                    t.NextToken(),
                    int.Parse(t.NextToken()),
                    t.NextToken(),
                    DateTime.Parse(t.NextToken())
                );
                item.Save();
                pbStatus.PerformStep();
            }
            info.Text = "Импортировано "+pbStatus.Maximum+" вхождений";
        }

        private void btnExport_Click(object sender, EventArgs e) {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {
            StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
            List<Item> items = Item.FindAll("1 = 1");
            pbStatus.Maximum = items.Count();
            pbStatus.Value = 0;
            foreach (Item item in items) {
                string line = string.Format(
                    "{0},\"{1}\",\"{2}\",{3},\"{4}\",{5}",
                    item.id,
                    item.title,
                    item.description,
                    item.amount,
                    item.image_name,
                    item.created_at.ToString()
                );
                sw.WriteLine(line);
                pbStatus.PerformStep();
            }
            info.Text = "Экспортировано "+pbStatus.Maximum+" вхождений";
            sw.Close();
        }
        
        private void btnClearItems_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Вы уверены что хотите очистить весь каталог? Данные могут быть потеряны навсегда.", "?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                DataBase.Query("DELETE FROM items;");
                info.Text = "Каталог был очищен";
            }
        }
    }
}
