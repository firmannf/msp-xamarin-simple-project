using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Just_A_Transaction.Models
{
    public class SQLiteDataAccess
    {
        SQLiteConnection dbConnection;
        public SQLiteDataAccess()
        {
            dbConnection = DependencyService.Get<ISQLite>().GetConnection();
            dbConnection.CreateTable<Transaction>();
        }

        public List<Transaction> GetAllTransactions()
        {
            return dbConnection.Query<Transaction>("Select * From [Transaction]");
        }

        public int SaveTransaction(Transaction transaction)
        {
            return dbConnection.Insert(transaction);
        }

        public int DeleteTransaction(Transaction transaction)
        {
            return dbConnection.Delete(transaction);
        }

        public int EditTransaction(Transaction transaction)
        {
            return dbConnection.Update(transaction);
        }
    }
}