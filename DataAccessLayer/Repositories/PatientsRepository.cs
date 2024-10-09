using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace DataAccessLayer.Repositories
{
    public class PatientsRepository
    {
        private SqlDataAccess _dbconection;

        public PatientsRepository() 
        {
            _dbconection = new SqlDataAccess();
        }

        public DataTable GetPatients()
        {
            DataTable patientsTable = new DataTable();

            using (var connection = _dbconection.GetConnection())
            {
                string query = "SELECT id, firstname, gender FROM Patients";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        patientsTable.Load(reader);
                    }
                }
            }

            return patientsTable;  
        }

    }
}
