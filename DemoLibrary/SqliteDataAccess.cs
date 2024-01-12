using Dapper;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess
    {
        public static List<ItemModel> LoadItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ItemModel>("select * from Item", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<DiscountModel> LoadDiscounts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<DiscountModel>("select * from Discount", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveItem(ItemModel item)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Item (Name, Price_Amount, Price_Currency) values (@Name, @Price_Amount, @Price_Currency)", item);
            }
        }
        public static int findOrderItemIdByName(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select Id from Item where Name = @name", new { name = name }).FirstOrDefault();
                return int.Parse(output);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
