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

            //Query("DROP TABLE users;");
            //Query("DROP TABLE items;");
            Migrate();
        }

        public static List<object[]> Query(string query) {
            var cmd = new NpgsqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            reader.Read();
            List<object[]> rows = new List<object[]>();
            if (reader.HasRows) {
                do {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    rows.Add(values);
                } while (reader.Read());
                reader.Close();
            } else {
                reader.Close();
            }
            return rows;
        }

        public static void Migrate() {
            try {
                Query("SELECT * FROM users;");
            } catch (PostgresException e) {
                Query(
                    "CREATE TABLE users (" +
                        "id serial PRIMARY KEY," +
                        "priv_level SMALLINT NOT NULL DEFAULT 1," +
                        "username VARCHAR(50) UNIQUE NOT NULL," +
                        "phone_number VARCHAR(15)," +
                        "password VARCHAR(256) NOT NULL," +
                        "created_at TIMESTAMP NOT NULL DEFAULT NOW()" +
                    ");"
                );
                SeedUsers();
            }
            try {
                Query("SELECT * FROM items;");
            } catch (PostgresException e) {
                Query(
                    "CREATE TABLE items (" +
                        "id serial PRIMARY KEY," +
                        "title VARCHAR(256) NOT NULL," +
                        "description VARCHAR(512) NOT NULL," +
                        "amount INTEGER NOT NULL DEFAULT 0," +
                        "image_name VARCHAR(256) DEFAULT NULL," +
                        "created_at TIMESTAMP NOT NULL DEFAULT NOW()" +
                    ");"
                );
                // SeedItems();
            }
        }

        public static void SeedUsers() {
            Query(
                "INSERT INTO users (priv_level, username, password)" +
                "VALUES (0, 'admin', 'f6e0a1e2ac41945a9aa7ff8a8aaa0cebc12a3bcc981a929ad5cf810a090e11ae');"
            );
        }
        public static void SeedItems() {
            Query(
                "INSERT INTO items (title, description, amount)" +
                "VALUES (" +
                    "'Plumbus'," +
                    "'A Plumbus is an all-purpose home device. Everyone knows what it does, so there is no reason to explain it.'," +
                    "42" +
                ");"
            );
            Query(
               "INSERT INTO items (title, description, amount)" +
               "VALUES (" +
                   "'Pile of shit'," +
                   "'Literally a pile of shit, nothing to see here.'," +
                   "10" +
               ");"
           );
           Query(
                "INSERT INTO items (title, description, amount)" +
                "VALUES (" +
                    "'Крутая штука'," +
                    "'Реально, как чечня.'," +
                    "10" +
                ");"
            );
        }
    }
}
