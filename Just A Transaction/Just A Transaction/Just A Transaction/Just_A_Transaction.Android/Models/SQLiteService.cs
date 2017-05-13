using System;
using Android.OS;
using Xamarin.Forms;
using Just_A_Transaction.Droid.Models;
using System.IO;
using Just_A_Transaction.Models;

[assembly: Dependency(typeof(SQLiteService))]
namespace Just_A_Transaction.Droid.Models
{
    public class SQLiteService : ISQLite
    {
        public SQLiteService()
        {
        }

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Transaction.db3";
            string documentsPath =
                   System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(plat, path);
            return connection;
        }
    }
}