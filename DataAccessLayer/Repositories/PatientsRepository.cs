using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using CommonLayer.Entities;

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
                string query = "SELECT id, firstName, lastName, dateOfBirth, gender FROM Patients";

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
        public void AddPatients(Patient patient)
        {
            using(var connection = _dbconection.GetConnection())
            {
                string query = @"INSERT INTO Patients (firstName, lastName, dateOfBirth, gender) VALUES (@firstName, @lastName, @dateOfBirth, @gender)";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    sqlCommand.Parameters.AddWithValue("@firstName", patient.FirstName);
                    sqlCommand.Parameters.AddWithValue("@lastName", patient.LastName);
                    sqlCommand.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth);
                    sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePatients(Patient patient)
        {
            using (var connetion = _dbconection.GetConnection())
            {
                string query = @"UPDATE Patients SET 
                                            firstName = @firstName,
                                            lastName = @lastName,
                                            dateOfBirth = @dateOfBirth,
                                            gender = @gender
                                            WHERE id = @id";
                using (var sqlCommand = new SqlCommand(query, connetion))
                {
                    connetion.Open();

                    sqlCommand.Parameters.AddWithValue("@id", patient.Id);
                    sqlCommand.Parameters.AddWithValue("@firstName", patient.FirstName);
                    sqlCommand.Parameters.AddWithValue("@lastName", patient.LastName);
                    sqlCommand.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth);
                    sqlCommand.Parameters.AddWithValue("@gender", patient.Gender);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatients(int id)
        {
            using (var connection = _dbconection.GetConnection())
            {
                string query = "DELETE FROM Patients WHERE id = @id";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.ExecuteNonQuery();

                }
            }

        }

    }
}
