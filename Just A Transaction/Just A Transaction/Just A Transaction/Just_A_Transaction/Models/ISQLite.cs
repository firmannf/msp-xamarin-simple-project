using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_A_Transaction.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
