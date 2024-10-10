using System;
using System.Data;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class AppointmentRepository
    {
        private readonly SqlDataAccess _dbConnection;

        public AppointmentRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        /// <summary>
        /// Obtiene la lista de doctores desde la base de datos.
        /// </summary>
        /// <returns>DataTable con los datos de los doctores.</returns>
        public DataTable GetDoctors()
        {
            DataTable doctorsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Id, firstName AS Doctors FROM Doctors";
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

       
        public DataTable GetPatients()
        {
            DataTable patientsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Id, CONCAT(firstName, ' ', lastName) AS Patients FROM Patients";
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

       
        public DataTable GetAppointments()
        {
            DataTable appointmentsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    a.id,
                                    a.appointmentDate,
                                    a.diagnosis,
                                    a.treatment,
                                    a.patientId, -- Incluir el ID del paciente
                                    a.doctorId, -- Incluir el ID del doctor
                                    CONCAT(p.firstName, ' ', p.lastName) AS Patients,
                                    d.firstName AS Doctors
                                 FROM Appointments AS a
                                 INNER JOIN Patients AS p ON a.patientId = p.id
                                 INNER JOIN Doctors AS d ON a.doctorId = d.id";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        appointmentsTable.Load(reader);
                    }
                }
            }
            return appointmentsTable;
        }

       
        public void AddAppointments(Appointment appointment)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Appointments (appointmentDate, diagnosis, treatment, patientId, doctorId)
                                 VALUES (@appointmentDate, @diagnosis, @treatment, @idPatient, @idDoctor)";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@appointmentDate", appointment.DateAppointments);
                    sqlCommand.Parameters.AddWithValue("@diagnosis", appointment.Diagnosis);
                    sqlCommand.Parameters.AddWithValue("@treatment", appointment.Treatment);
                    sqlCommand.Parameters.AddWithValue("@idPatient", appointment.PatientId);
                    sqlCommand.Parameters.AddWithValue("@idDoctor", appointment.DoctorId);

                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

       
        public void DeleteAppointments(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Appointments WHERE id = @id";
                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

       
        public void UpdateAppointments(Appointment appointment)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Appointments 
                                 SET appointmentDate = @appointmentDate, 
                                     diagnosis = @diagnosis,
                                     treatment = @treatment,
                                     patientId = @idPatient,
                                     doctorId = @idDoctor
                                 WHERE id = @id";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@appointmentDate", appointment.DateAppointments);
                    sqlCommand.Parameters.AddWithValue("@diagnosis", appointment.Diagnosis);
                    sqlCommand.Parameters.AddWithValue("@treatment", appointment.Treatment);
                    sqlCommand.Parameters.AddWithValue("@idPatient", appointment.PatientId);
                    sqlCommand.Parameters.AddWithValue("@idDoctor", appointment.DoctorId);
                    sqlCommand.Parameters.AddWithValue("@id", appointment.AppointmentsId);

                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
