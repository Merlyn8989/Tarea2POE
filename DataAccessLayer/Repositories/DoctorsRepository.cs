using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer.Repositories
{
    public class DoctorsRepository
    {
        private SqlDataAccess _dbConnection;

        public DoctorsRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetDoctors()
        {
            DataTable doctorsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT id, firstName, specialty FROM Doctors";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        doctorsTable.Load(reader);
                    }
                }
            }

            return doctorsTable;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Doctors (firstName, specialty) VALUES (@firstName, @specialty)";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@firstName", doctor.FirstName);
                    sqlCommand.Parameters.AddWithValue("@specialty", doctor.Specialty);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteDoctor(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Doctors WHERE id = @id";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Doctors
                                SET firstName = @firstName,
                                    specialty = @specialty
                                WHERE id = @id";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@id", doctor.Id);
                    sqlCommand.Parameters.AddWithValue("@firstName", doctor.FirstName);
                    sqlCommand.Parameters.AddWithValue("@specialty", doctor.Specialty);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}