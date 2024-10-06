using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services
{
    public class AppointmentService
    {
        private AppointmentRepository _appointmentRepository;

        public AppointmentService()
        {
            _appointmentRepository = new AppointmentRepository();
        }

        public DataTable GetAllAppointments()
        {
            return _appointmentRepository.GetAppointments();
        }

        public DataTable GetDoctors()
        {
            return _appointmentRepository.GetDoctors();
        }

        public DataTable GetPatients()
        {
            return _appointmentRepository.GetPatients();
        }

        public void AddAppointment(Appointment appointment)
        {
           _appointmentRepository.AddAppointments(appointment);
        }

        public void EditAppointment(Appointment appointment)
        {
            _appointmentRepository.UpdateAppointments(appointment);
        }

        public void DeleteAppointment(int id)
        {
            _appointmentRepository.DeleteAppointments(id);
        }

    }
}
