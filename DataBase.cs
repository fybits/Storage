using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage {
    static class DataBase {
        private static NpgsqlConnection connection;

        public static void Connect(string host, string username, string password, string database) {
            var connString = string.Format(
                "Host={0};Username={1};Password={2};Database={3}",
                host,
                username,
                password,
                database
            );

            connection = new NpgsqlConnection(connString);
            connection.Open();
        }

        public static NpgsqlDataReader Query(string query) {
            var cmd = new NpgsqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            reader.Read();
            return reader;
        }
    }
}
