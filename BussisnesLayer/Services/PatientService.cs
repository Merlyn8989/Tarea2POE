using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using CommonLayer.Entities;

namespace BussisnesLayer.Services
{
    public class PatientService
    {
        private PatientsRepository _patientsRepository;

        public PatientService()
        {
            _patientsRepository = new PatientsRepository();
        }

        public DataTable GetAllPatients()
        {
            return _patientsRepository.GetPatients();
        }

        public void AddPatient(Patient patient)
        {
            _patientsRepository.AddPatients(patient);
        }

        public void EditPatient(Patient patient)
        {
            _patientsRepository.UpdatePatients(patient);
        }
        public void DeletePatient(int id)
        {
            _patientsRepository.DeletePatients(id);
        }
    }
}
