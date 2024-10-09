using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussisnesLayer.Services
{
    public class DoctorService
    {
        private DoctorsRepository _doctorsRepository;

        public DoctorService()
        {
            _doctorsRepository = new DoctorsRepository();
        }

        public DataTable GetAllDoctors()
        {
            return _doctorsRepository.GetDoctors();
        }

        public void AddDoctor(Doctor doctor)
        {
            _doctorsRepository.AddDoctor(doctor);
        }

        public void EditDoctor(Doctor doctor)
        {
            _doctorsRepository.UpdateDoctor(doctor);
        }

        public void DeleteDoctor(int id)
        {
            _doctorsRepository.DeleteDoctor(id);
        }
    }
}
