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
    public partial class UsersForm : Form {
        public UsersForm() {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e) {
            List<User> users = User.FindAll("1 = 1");
            foreach (User user in users) {
                object[] userData = new object[4];
                userData[0] = user.id;
                userData[1] = user.username;
                userData[2] = user.phone_number;
                userData[3] = (user.privLevel == 0) ? "Администратор" : "Пользователь";
                tableUsers.Rows.Add(userData);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            tableUsers.Rows[0].Cells
                User user = new User();
                object[] userData = new object[4];
                int i = 0;
                foreach (DataGridViewCell cell in row.Cells) {
                    userData[i++] = cell.Value;
                }
                user.id = Convert.ToInt32(userData[0]);
                user.username = Convert.ToString(userData[1]);
                user.phone_number = Convert.ToString(userData[2]);
                user.privLevel = (Convert.ToString(userData[3]) == "Администратор") ? 0 : 1;
                user.Update();
            }
        }
    }
}
