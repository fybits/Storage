using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage {
    class User {
        public int id;
        public int privLevel;
        public string username;
        public string phone_number;
        public DateTime created_at;
        
        public static User Find(string query) {
            List<object[]> entries = DataBase.Query(string.Format("SELECT * FROM users WHERE {0};", query));
            if (entries.Count != 0) {
                object[] values = entries[0];
                User user = new User();
                user.id = Convert.ToInt32(values[0]);
                user.privLevel = Convert.ToInt16(values[1]);
                user.username = Convert.ToString(values[2]);
                user.phone_number = Convert.ToString(values[3]);
                user.created_at = Convert.ToDateTime(values[5]);
                return user;
            }
            return null;
        }

        public static List<User> FindAll(string query) {
            List<object[]> entries = DataBase.Query(string.Format("SELECT * FROM users WHERE {0};", query));
            List<User> users = new List<User>();
            if (entries.Count != 0) {
                foreach (object[] itemValues in entries) {
                    User user = new User();
                    user.id = Convert.ToInt32(itemValues[0]);
                    user.privLevel = Convert.ToInt16(itemValues[1]);
                    user.username = Convert.ToString(itemValues[2]);
                    user.phone_number = Convert.ToString(itemValues[3]);
                    user.created_at = Convert.ToDateTime(itemValues[5]);
                    users.Add(user);
                }
            }
            return users;
        }

        public void Update() {
            DataBase.Query(string.Format(
                "UPDATE users SET username = '{1}', phone_number = '{2}', priv_level = {3} WHERE id = {0};",
                id,
                username,
                phone_number,
                privLevel
            ));
        }
    }
}
