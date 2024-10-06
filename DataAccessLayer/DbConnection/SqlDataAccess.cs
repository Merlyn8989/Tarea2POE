using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=MERLYNRAJO\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetConnection() {
            
            return new SqlConnection(_connectionString);
        }
    }
}
