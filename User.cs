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
        public DateTime created_at;
        
        public static User Find(string query) {
            object[] values = DataBase.Query(string.Format("SELECT * FROM users WHERE {0};", query));
            if (values != null) {
                User user = new User();
                user.id = Convert.ToInt32(values[0]);
                user.privLevel = Convert.ToInt16(values[1]);
                user.username = Convert.ToString(values[2]);
                user.created_at = Convert.ToDateTime(values[4]);
                return user;
            }
            return null;
        }
    }
}
