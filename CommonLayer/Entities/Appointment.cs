using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Appointment
    {
        public int AppointmentsId {  get; set; }

        public DateTime DateAppointments { get; set; }

        public string Diagnosis { get; set; }

        public string Treatment { get; set; }
        
        public int PatientId { get; set; }  

        public int DoctorId { get; set; }

    }
}
