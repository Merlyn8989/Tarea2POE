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
            //no borren esta
<<<<<<< HEAD
            _connectionString = "Data Source=YONATAN-CHICAS\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True;Trust Server Certificate=True";
=======
            //_connectionString = "Data Source=MERLYNRAJO\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True;Encrypt=False";
>>>>>>> c855e63af62b9a3352f20f30f520ff3cd8d7a2a3

            _connectionString = "Data Source=YONATAN-CHICAS\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True;Trust Server Certificate=True";
           
        }

        public SqlConnection GetConnection()
        {

            return new SqlConnection(_connectionString);
        }
    }
}