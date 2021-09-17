using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Repository
{
    public interface IDatabase
    {
        bool CheckConnection();
        bool CreateDatabase(SqlConnection connection, string txtDatabase);

        bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName);

        bool GrantAccess(string fullPath);

    }
}
