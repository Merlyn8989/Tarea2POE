using System.Data;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _appointmentRepository;

        public AppointmentService()
        {
            _appointmentRepository = new AppointmentRepository();
        }

        public DataTable GetAllAppointments() => _appointmentRepository.GetAppointments();
        public DataTable GetDoctors() => _appointmentRepository.GetDoctors();
        public DataTable GetPatients() => _appointmentRepository.GetPatients();
        public void AddAppointment(Appointment appointment) => _appointmentRepository.AddAppointments(appointment);
        public void EditAppointment(Appointment appointment) => _appointmentRepository.UpdateAppointments(appointment);
        public void DeleteAppointment(int id) => _appointmentRepository.DeleteAppointments(id);
    }
}
