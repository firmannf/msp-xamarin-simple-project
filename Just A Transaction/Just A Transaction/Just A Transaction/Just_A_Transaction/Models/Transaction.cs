using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_A_Transaction.Models
{
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public long TransactionID { get; set; }

        [NotNull]
        public string TransactionName { get; set; }
        [NotNull]
        public string TransactionAmount { get; set; }
        [NotNull]
        public DateTime TransactionDate { get; set; }        
        public string TransactionInfo { get; set; }
    }
}
