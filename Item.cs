using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage {
    public class Item {
        public int id;
        public string title;
        public string description;
        public int amount;
        public DateTime created_at;

        public Item() { }

        public Item(string title, string description, int amount = 0) {
            this.title = title;
            this.description = description;
            this.amount = amount;
        }

        public static Item Find(string query) {
            List<object[]> entries = DataBase.Query(string.Format("SELECT * FROM items WHERE {0};", query));
            if (entries.Count != 0) {
                object[] values = entries[0];
                Item item = new Item();
                item.id = Convert.ToInt32(values[0]);
                item.title = Convert.ToString(values[1]);
                item.description = Convert.ToString(values[2]);
                item.amount = Convert.ToInt32(values[3]);
                item.created_at = Convert.ToDateTime(values[4]);
                return item;
            }
            return null;
        }

        public static List<Item> FindAll(string query) {
            List<object[]> entries = DataBase.Query(string.Format("SELECT * FROM items WHERE {0};", query));
            List<Item> items = new List<Item>();
            if (entries.Count != 0) {
                foreach (object[] itemValues in entries) {
                    Item item = new Item();
                    item.id = Convert.ToInt32(itemValues[0]);
                    item.title = Convert.ToString(itemValues[1]);
                    item.description = Convert.ToString(itemValues[2]);
                    item.amount = Convert.ToInt32(itemValues[3]);
                    item.created_at = Convert.ToDateTime(itemValues[4]);
                    items.Add(item);
                }
                return items;
            }
            return null;
        }

        public void Save() {
            DataBase.Query(string.Format(
                "INSERT INTO items (title, description, amount)" +
                "VALUES ('{0}', '{1}', {2});",
                title,
                description,
                amount
            ));
        }
        public void Update() {
            DataBase.Query(string.Format(
                "UPDATE items" +
                "SET" +
                    "title = {0}," +
                    "description = {1}," +
                    "amount = {2}" +
                "WHERE id = {3};",
                title,
                description,
                amount,
                id
            ));
        }
    }
}
