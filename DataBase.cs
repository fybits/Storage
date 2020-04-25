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

            try {
                Query(
                    "SELECT * FROM users;"
                );
            } catch (PostgresException e) {
                Migrate();
            }
        }

        public static object[] Query(string query) {
            var cmd = new NpgsqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows) {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                reader.Close();
                return values;
            } else {
                reader.Close();
                return null;
            }
        }

        public static void Migrate() {
            Query(
                "CREATE TABLE users (" +
                    "id serial PRIMARY KEY," +
                    "priv_level SMALLINT NOT NULL DEFAULT 1," +
                    "username VARCHAR(50) UNIQUE NOT NULL," +
                    "password VARCHAR(256) NOT NULL," +
                    "created_at TIMESTAMP NOT NULL DEFAULT NOW()" +
                ");"
            );
        }
    }
}
