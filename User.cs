using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage {
    class User {
        public int id;
        public string username;
        public DateTime created_at;
        
        public static User Find(string query) {
            var reader = DataBase.Query(string.Format("SELECT * FROM users WHERE {0};", query));
            if (reader.HasRows) {
                User user = new User();
                user.id = reader.GetInt32(0);
                user.username = reader.GetString(1);
                user.created_at = reader.GetDateTime(3);
                reader.Close();
                return user;
            }
            reader.Close();
            return null;
        }
    }
}
